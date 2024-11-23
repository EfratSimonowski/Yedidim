using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblApicenterProductTable : GeneralTable
    {
        public TblApicenterProductTable() : base("TblApicenterProduct")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblApicenterProduct(item));
            }

        }
        public List<TblApicenterProduct> GetList()
        {
            return list.ConvertAll(x => (TblApicenterProduct)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.ApicenterProduct.GetList().Max(x => x.Apicenterproductcode) + 1;
        }
    }
}
