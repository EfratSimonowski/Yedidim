using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblDonationsTable:GeneralTable
    {
        public TblDonationsTable() : base("TblDonations")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblDonations(item));
            }
        }
        public List<TblDonations> GetList()
        { return list.ConvertAll(x => (TblDonations)x); }

        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Donations.GetList().Max(x => x.Donationcode) + 1;
        }
    }
}
