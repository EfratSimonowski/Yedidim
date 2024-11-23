using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblStatusTable:GeneralTable
    {
        public TblStatusTable() : base("TblStatus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblStatus(item));
            }
        }

        public List<TblStatus> GetList()
        { return list.ConvertAll(x => (TblStatus)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Status.GetList().Max(x => x.Statuscode) + 1;
        }
    }
}
