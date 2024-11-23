using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class ApicenterTable:GeneralTable
    {
        public ApicenterTable() : base("Apicenter")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Apicenter(item));
            }
        }

        public List<Apicenter> GetList()
        { return list.ConvertAll(x => (Apicenter)x); }

    }
}
