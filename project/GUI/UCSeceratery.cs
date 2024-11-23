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
    public partial class UCSeceratery : UserControl
    {
        public UCSeceratery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCAddEvent us=new UCAddEvent();
            (this.ParentForm as FrmMain).panel1.Controls.Add(us);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);

        }
    }
}
