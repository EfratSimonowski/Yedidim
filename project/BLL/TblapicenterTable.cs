using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblApicenterTable:GeneralTable
    {
        public TblApicenterTable() : base("TblApicenter")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblApicenter(item));
            }
        }

        public List<TblApicenter> GetList()
        { return list.ConvertAll(x => (TblApicenter)x); }

        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Apicenter.GetList().Max(x => x.Apicentercode) + 1;
        }

    }
}
