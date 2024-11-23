using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;

namespace project.GUI
{
    public partial class UCPrevious : UserControl
    {
        public UCPrevious()
        {
            InitializeComponent();
            dataGridView3.DataSource = MyDB.Event.GetList();
        }
    }
}
