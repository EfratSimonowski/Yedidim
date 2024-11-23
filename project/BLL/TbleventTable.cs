using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblEventTable : GeneralTable
    {
        public TblEventTable() : base("TblEvent")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new TblEvent(item));
            }
        }

        public List<TblEvent> GetList()
        { return list.ConvertAll(x => (TblEvent)x); }

        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return MyDB.Event.GetList().Max(x => x.Eventcode) + 1;
        }
    }
}
