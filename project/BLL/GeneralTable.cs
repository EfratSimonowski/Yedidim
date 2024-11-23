using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public abstract class GeneralTable
    {
        protected DataTable table;
        protected List<GeneralRow> list;

        private static Connection connect = new Connection();

        public GeneralTable(string nameTable)
        {
            table = connect.GetTable(nameTable);
            list = new List<GeneralRow>();
        }


        public void AddItem(GeneralRow item)
        {
            list.Add(item);
            item.row = table.NewRow();
            item.FillDataRow();
            table.Rows.Add(item.row);
        }

        public void UpdateItem(GeneralRow item)
        {
            item.FillDataRow();
        }
        public void DeleteItem(GeneralRow item)
        {
            item.row.Delete();
            list.Remove(item);
        }

        public void SaveChanges()
        {
            connect.UpdateTable(this.table.TableName);
        }

    }
}
