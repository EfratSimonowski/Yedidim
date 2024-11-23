using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class cityTable :GeneralTable
    {
        public cityTable() : base("city")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new city(item));
            }
        }

        public List<city> GetList()
        { return list.ConvertAll(x => (city)x); }

    }
}
