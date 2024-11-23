using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.GUI
{
    public partial class UCProductVo : UserControl
    {
        public UCProductVo()
        {
            InitializeComponent();
        }

        private void ba_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void addm_Click(object sender, EventArgs e)
        {
            UCAddProduct up = new UCAddProduct();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }
    }
}
