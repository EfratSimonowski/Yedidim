using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace project.BLL
{
    public class TblDonorsTable : GeneralTable
    {
        public TblDonorsTable() : base("TblDonors")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblDonors(item));
            }
        }

        public List<TblDonors> GetList()
        { return list.ConvertAll(x => (TblDonors)x); }


        
    }
}
