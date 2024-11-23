using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class donationsTable:GeneralTable
    {
        public donationsTable() : base("donation")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new donations(item));
            }
        }
        public List<donations> GetList()
        { return list.ConvertAll(x => (donations)x); }
    }
}
