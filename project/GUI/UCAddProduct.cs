using project.BLL;
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
    public partial class UCAddProduct : UserControl
    {
        TblProductVolanteer currentproductv;
        string volenteerId;
        TblVolanteer currentvolanteer;
        public UCAddProduct()
        {
            InitializeComponent();
            currentvolanteer = new TblVolanteer();
            currentproductv = new TblProductVolanteer();
            comboBox1.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
        }

        public UCAddProduct(string volenteerId) : this()
        {
            this.volenteerId = volenteerId;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void UCAddProduct_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCStatus up = new UCStatus();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "" || numericUpDown1.Value == 0)
            {
                errorProvider1.SetError(numericUpDown1, "הערך שהוקש שגוי");
                numericUpDown1.Text = "";
            }
            else
            {
                FillObj1();
                currentvolanteer = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == volenteerId);
                int numr = 3 * Convert.ToInt32(numericUpDown1.Text);
                currentvolanteer.Points = currentvolanteer.Points + numr;
                MyDB.Volanteer.UpdateItem(currentvolanteer);
                MyDB.Volanteer.SaveChanges();
                MyDB.ProductVolanteer.AddItem(currentproductv);
                MyDB.ProductVolanteer.SaveChanges();
                MessageBox.Show("המוצר נוסף בהצלחה");
            }
        }
        public void FillObj1()
        {
            currentproductv.Productcode=MyDB.ProductVolanteer.GetNextKey();
            currentproductv.Toolcode = MyDB.Tools.GetList().FirstOrDefault(X => X.Toolname == comboBox1.SelectedValue.ToString()).Toolcode;
            currentproductv.Volanteerid = volenteerId;
            currentproductv.Amountprov = Convert.ToInt32(numericUpDown1.Value);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
