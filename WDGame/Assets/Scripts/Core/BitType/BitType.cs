﻿using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public delegate void BitTypeHandle(BitType type);

#pragma warning disable CS0659 // 类型重写 Object.Equals(object o)，但不重写 Object.GetHashCode()
    public class BitType
    {
        /*
         * 00000001 -module1
         * 00000010 -module2
         * 00000100 -module3 
         * ...
         */
        private bool _canModify;
        private int[] mBuffer;
        private IBitTypeQuery mBitTypeQuery;

        public IBitTypeQuery GetBitTypeQuery()
        {
            return mBitTypeQuery;
        }

        public BitType(int index,IBitTypeQuery bt,bool canModify)
        {
            _canModify = canModify; 
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
        private BitType(int[] buffer,IBitTypeQuery bt,bool canModify)
        {
            mBuffer = buffer;
            mBitTypeQuery = bt;
            _canModify = canModify;
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

        private bool ModifyCheck(BitType targetType)
        {
            if (!_canModify)
            {
                Log.Error(ErrorLevel.Critical, "ModifyCheck Error, CAN NOT MODIFY!");
                return false;
            }

            if (targetType == null)
            {
                Log.Error(ErrorLevel.Critical, "ModifyCheck Error, targetType is null!");
                return false;
            }

            var targetBitTypeQuery = targetType.GetBitTypeQuery();

            if (mBitTypeQuery == null || targetBitTypeQuery == null)
            {
                Log.Error(ErrorLevel.Critical, "ModifyCheck Error,BitTypeQuery is null!");
                return false;
            }

            if (mBitTypeQuery.GetHashCode() != targetBitTypeQuery.GetHashCode())
            {
                Log.Error(ErrorLevel.Critical, "ModifyCheck Error, can not modify bitType with different BitTypeQuery!");
                return false;
            }

            return true;
        }

        public void RemoveBitType(BitType targetType)
        {
            if (!ModifyCheck(targetType))
                return;

            for (int i = 0; i < mBuffer.Length; i++)
            {
                mBuffer[i] &= ~targetType.GetTypeBufferAt(i);
            }
        }

        public void BindBitType(BitType targetType)
        {
            if (!ModifyCheck(targetType))
                return;

            for (int i = 0; i < mBuffer.Length; i++)
            {
                mBuffer[i] |= targetType.GetTypeBufferAt(i);
            }
        }

        public static BitType BindWithBitTypes(BitType type1, BitType type2, bool canModify)
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

            if (btQuery1.GetHashCode() != btQuery2.GetHashCode())
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
            return new BitType(buffer, btQuery1, canModify);
        }

        public static BitType BindWithBitTypes(BitType[] bts, bool canModify)
        {
            if (bts == null) return null;
            if (bts.Length == 0) return null;
            if (bts.Length == 1) return bts[0];

            for (int i = 0; i < bts.Length - 1; i++)
            {
                IBitTypeQuery foward = bts[i].GetBitTypeQuery();
                IBitTypeQuery backward = bts[i + 1].GetBitTypeQuery();
                if (foward == null || backward == null)
                {
                    Log.Error(ErrorLevel.Critical, "BindBitTypes Error, can not bind bitType with different bitTypeQuery!");
                    return null;
                }
            }

            IBitTypeQuery btQuery = bts[0].GetBitTypeQuery();
            int maxSize = btQuery.GetBufferMaxSize();
            int[] buffer = new int[maxSize];
            for (int i = 0; i < bts.Length; i++)
            {
                BitType src = bts[i];
                for (int j = 0; j < maxSize; j++)
                {
                    buffer[j] |= src.GetTypeBufferAt(j);
                }
            }
            return new BitType(buffer, btQuery, canModify);
        }

        public bool HasType(BitType evt)
        {
            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            for (int i = 0; i < maxSize; i++)
            {
                int data = mBuffer[i];
                int temp = data &= evt.GetTypeBuffer()[i];
                if (temp > 0)
                    return true;
            }

            return false;
        }

        public BitType Clone(bool canModify)
        {
            int maxSize = mBitTypeQuery.GetBufferMaxSize();
            int[] buffer = new int[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                buffer[i] = mBuffer[i];
            }
            return new BitType(buffer, mBitTypeQuery, canModify);
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
                mTempBitType = new BitType(tempBuffer,mBitTypeQuery,false);
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
                    BitType bt = new BitType(buffer, mBitTypeQuery,false);
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
