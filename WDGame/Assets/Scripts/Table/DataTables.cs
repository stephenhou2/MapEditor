﻿using System.Collections.Generic;

namespace TableProto
{
    public partial class DataTables
    {
        public static DataTables Ins;

        public static void CreateDataTables()
        {
            Ins = new DataTables();
            Ins.LoadAllDataTables();
            Ins.LoadAllTableRedefines();
        }

        private void LoadAllDataTables()
        {
			LoadTestSheet();
			LoadTest2();
			LoadMonsterCfg();
			LoadMonsterCfg222();

        }

        public void ClearAllDataTables()
        {
			ClearTestSheet();
			ClearTest2();
			ClearMonsterCfg();
			ClearMonsterCfg222();

        }

        public void LoadAllTableRedefines()
        {
			LoadTestSheetRedefine();
			LoadTest2Redefine();
			LoadMonsterCfgRedefine();
			LoadMonsterCfg222Redefine();

        }
    }
}
