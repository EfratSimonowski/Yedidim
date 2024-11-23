using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblKilometerTable : GeneralTable
    {
        public TblKilometerTable() : base("TblKilometer")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblKilometer(item));
            }
        }

        public List<TblKilometer> GetList()
        { return list.ConvertAll(x => (TblKilometer)x); }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Kilometer.GetList().Max(x => x.Moneydonationcode) + 1;
        }
    }
}
