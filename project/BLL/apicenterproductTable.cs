using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class apicenterproductTable:GeneralTable
    {
        public apicenterproductTable():base("apicenterproduct")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new apicenterproduct(item));
            }
            
        }
        public List<apicenterproduct> GetList()
        {
            return list.ConvertAll(x => (apicenterproduct)x);
        }
    }
}
