using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblProductVolanteerTable:GeneralTable
    {
        public TblProductVolanteerTable() : base("TblProductVolanteer")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblProductVolanteer(item));
            }
        }

        public List<TblProductVolanteer> GetList()
        { return list.ConvertAll(x => (TblProductVolanteer)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.ProductVolanteer.GetList().Max(x => x.Productcode) + 1;
        }
    }
}
