using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblapicenterproductTable:GeneralTable
    {
        public TblapicenterproductTable():base("Tblapicenterproduct")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Tblapicenterproduct(item));
            }
            
        }
        public List<Tblapicenterproduct> GetList()
        {
            return list.ConvertAll(x => (Tblapicenterproduct)x);
        }
    }
}
