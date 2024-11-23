using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblCityTable :GeneralTable
    {
        public TblCityTable() : base("TblCity")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblCity(item));
            }
        }

        public List<TblCity> GetList()
        { return list.ConvertAll(x => (TblCity)x); }

    }
}
