using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class epicenterTable:GeneralTable
    {
        public epicenterTable() : base("epicenter")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new epicenter(item));
            }
        }

        public List<epicenter> GetList()
        { return list.ConvertAll(x => (epicenter)x); }

    }
}
