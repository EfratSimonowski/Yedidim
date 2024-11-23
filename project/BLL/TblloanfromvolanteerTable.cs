using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblLoanFromVolanteerTable:GeneralTable
    {
        public TblLoanFromVolanteerTable() : base("TblLoanFromVolanteer")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblLoanFromVolanteer(item));
            }
        }

        public List<TblLoanFromVolanteer> GetList()
        { return list.ConvertAll(x => (TblLoanFromVolanteer)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.LoanFromVolanteer.GetList().Max(x => x.Loancode) + 1;
        }
    }
}
