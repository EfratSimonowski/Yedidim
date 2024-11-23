using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class EventTable:GeneralTable
    {
        public EventTable() : base("Event")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Event(item));
            }
        }

        public List<Event> GetList()
        { return list.ConvertAll(x => (Event)x); }
    }
}
