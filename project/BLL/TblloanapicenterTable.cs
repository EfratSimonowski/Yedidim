using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblLoanApicenterTable : GeneralTable
    {
        public TblLoanApicenterTable() : base("TblLoanApicenter")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblLoanApicenter(item));
            }
        }

        public List<TblLoanApicenter> GetList()
        { return list.ConvertAll(x => (TblLoanApicenter)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.LoanApicenter.GetList().Max(x => x.Loanapicentercode) + 1;
        }
    }


} 
