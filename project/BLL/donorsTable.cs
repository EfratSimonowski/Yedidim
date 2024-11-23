using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace project.BLL
{
  public  class donorsTable:GeneralTable
    {
        public donorsTable() : base("donors")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new donors(item));
            }
        }

        public List<donors> GetList()
        { return list.ConvertAll(x => (donors)x); }

    }
}
