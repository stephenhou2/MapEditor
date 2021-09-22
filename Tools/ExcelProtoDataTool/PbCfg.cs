﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TableProto
{
    public class PbCfg
    {
        public static PbCfg Ins;

        public Dictionary<int, MonsterCfg> mMonsterCfgs = new Dictionary<int, MonsterCfg>();


        public static void CreatePbCfg()
        {
            Ins = new PbCfg();
            Ins.LoadAllPbCfgs();
        }

        private void LoadAllPbCfgs()
        {

        }

        public static void ClearPbCfg()
        {

        }

        public MonsterCfg GetMonsterCfg(int id)
        {
            MonsterCfg cfg;
            if (mMonsterCfgs.TryGetValue(id, out cfg))
            {
                return cfg;
            }

            Log.Error("Get MonsterCfg Failed, key = {0}", id);
            return null;
        }
    }
}
