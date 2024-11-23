using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblVolanteerTable:GeneralTable
    {
        public TblVolanteerTable() : base("TblVolanteer")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblVolanteer(item));
            }
        }

        public List<TblVolanteer> GetList()
        { return list.ConvertAll(x => (TblVolanteer)x); }
      
    }
}
