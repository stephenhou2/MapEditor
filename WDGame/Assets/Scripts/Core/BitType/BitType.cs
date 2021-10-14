﻿using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public delegate void BitTypeHandle(BitType type);

    public class BitType
    {
        /*
         * 00000001 -module1
         * 00000010 -module2
         * 00000100 -module3 
         * ...
         */
        private int[] mBuffer;
        private IBitTypeQuery mBitTypeQuery;

        public IBitTypeQuery GetBitTypeQuery()
        {
            return mBitTypeQuery;
        }

        public BitType(int index,IBitTypeQuery bt)
        {
            int maxSize = bt.GetBufferMaxSize();
            mBitTypeQuery = bt;
            mBuffer = new int[maxSize];
            int index_1 = index / CoreDefine.buffeSizeOfInt;
            int index_2 = index % CoreDefine.buffeSizeOfInt;

            int value = (int)(1 << index_2);

            if (index_1 >= 0 && index_1 < maxSize)
            {
                mBuffer[index_1] = value;
            }
            else
            {
                Log.Error(ErrorLevel.Fatal, "BiTypeBuffer Create failed,index \'{0}\' out of range!", index);
            }
        }
        private BitType(int[] buffer,IBitTypeQuery bt)
        {
            mBuffer = buffer;
            mBitTypeQuery = bt;
        }

        private int[] GetTypeBuffer()
        {
            return mBuffer;
        }

        public int GetTypeBufferAt(int index)
        {
            if (index < 0 || index >= mBuffer.Length)
            {
                Log.Error(ErrorLevel.Fatal, "GetTypeBufferAt Error,index out of range!");
                return 0;
            }

            return mBuffer[index];
        }

        public override string ToString()
        {
            if (mBitTypeQuery != null)
            {
                return mBitTypeQuery.BitTypeTranslate(this);
            }

            return string.Empty;
        }

        public static BitType BindBitTypes(BitType type1, BitType type2)
        {
            if (type1 == null || type2 == null)
            {
                Log.Error(ErrorLevel.Critical, "BindBitTypes Error, can not bind null bitType!");
                return null;
            }

            var btQuery1 = type1.GetBitTypeQuery();
            var btQuery2 = type2.GetBitTypeQuery();

            if (btQuery1 == null || btQuery2 == null)
            {
                Log.Error(ErrorLevel.Critical, "BindBitTypes Error, can not bind bitType without bitTypeQuery!");
                return null;
            }

            if(btQuery1.GetHashCode() !=  btQuery2.GetHashCode())
            {
                Log.Error(ErrorLevel.Critical, "BindBitTypes Error, can not bind bitType with different bitTypeQuery!");
                return null;
            }

            int maxSize = btQuery1.GetBufferMaxSize();
            int[] buffer = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                buffer[i] = type1.GetTypeBufferAt(i) | type2.GetTypeBufferAt(i);
            }
            return new BitType(buffer, btQuery1);
        }

        public static BitType BindBitTypes(List<BitType> bts)
        {
            if (bts == null) return null;
            if (bts.Count == 0) return null;
            if (bts.Count == 1) return bts[0];

            for(int i = 0;i<bts.Count - 1;i++)
            {
                IBitTypeQuery foward = bts[i].GetBitTypeQuery();
                IBitTypeQuery backward = bts[i + 1].GetBitTypeQuery();
                if(foward == null || backward == null)
                {
                    Log.Error(ErrorLevel.Critical, "BindBitTypes Error, can not bind bitType with different bitTypeQuery!");
                    return null;
                }
            }

            IBitTypeQuery btQuery = bts[0].GetBitTypeQuery();
            int maxSize = btQuery.GetBufferMaxSize();
            int[] buffer = new int[maxSize];
            for (int i = 0; i < bts.Count; i++)
            {
                BitType src = bts[i];
                for (int j = 0; j < maxSize; j++)
                {
                    buffer[j] |= src.GetTypeBufferAt(j);
                }
            }
            return new BitType(buffer, btQuery);
        }

        public bool HasEvent(BitType evt)
        {
            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            for (int i = 0; i < maxSize; i++)
            {
                int temp = mBuffer[i] &= evt.GetTypeBuffer()[i];
                if (temp > 0)
                    return true;
            }

            return false;
        }

        public BitType Clone()
        {
            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            int[] buffer = new int[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                buffer[i] = mBuffer[i];
            }
            return new BitType(buffer, mBitTypeQuery);
        }


        /// <summary>
        /// 遍历时用的类型
        /// </summary>
        private BitType mTempBitType;
        private BitType GetTempBitType()
        {
            if (mTempBitType == null)
            {
                int maxSize = mBitTypeQuery.GetBufferMaxSize();
                int[] tempBuffer = new int[maxSize];
                mTempBitType = new BitType(tempBuffer,mBitTypeQuery);
            }

            return mTempBitType;
        }

        /// <summary>
        /// 处理包含的所有类型，使用内部动态缓存，外部不能存储，用后即丢
        /// </summary>
        /// <param name="handle"></param>
        public void ForEachSingleType(BitTypeHandle handle)
        {
            if (handle == null)
                return;

            BitType bt = GetTempBitType();
            for (int i = 0; i < mBuffer.Length; i++)
            {
                int data = mBuffer[i];
                while (data > 0)
                {
                    int bit = data & (~(data - 1)); // 取最后一位非零位的int值

                    bt.mBuffer[i] = bit;
                    handle(bt);

                    // 清除数据
                    bt.mBuffer[i] = 0;

                    // 剔除最后一位非零位
                    data = data ^ bit;
                }
            }
        }


        /// <summary>
        /// 处理包含的所有类型，类型不复用，外部可以缓存，但是不推荐使用
        /// </summary>
        /// <param name="handle"></param>
        public void ForEachSingleTypeClone(BitTypeHandle handle)
        {
            if (handle == null)
                return;

            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            for (int i = 0; i < mBuffer.Length; i++)
            {
                int data = mBuffer[i];
                while (data > 0)
                {
                    int bit = data & (~(data - 1)); // 取最后一位非零位的int值

                    int[] buffer = new int[maxSize];

                    buffer[i] = bit;
                    BitType bt = new BitType(buffer, mBitTypeQuery);
                    handle(bt);

                    // 剔除最后一位非零位
                    data = data ^ bit;
                }
            }
        }

        public override bool Equals(object obj)
        {
            BitType target = obj as BitType;
            if (null == target)
                return false;

            if(GetHashCode() == target.GetHashCode())
                return true;

            if (mBitTypeQuery.GetHashCode() != target.GetBitTypeQuery().GetHashCode())
                return false;

            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            for (int i = 0; i < maxSize; i++)
            {
                if(GetTypeBufferAt(i) != target.GetTypeBufferAt(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
