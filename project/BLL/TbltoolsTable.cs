using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblToolsTable:GeneralTable
    {
        public TblToolsTable() : base("TblTools")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblTools(item));
            }
        }

        public List<TblTools> GetList()
        { return list.ConvertAll(x => (TblTools)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Tools.GetList().Max(x => x.Toolcode) + 1;
        }
    }
}
