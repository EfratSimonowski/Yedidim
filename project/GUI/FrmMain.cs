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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            panel1.Focus();
            
        }

        //פונים
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCApplication up=new UCApplication();
            panel1.Controls.Add(up);
            
        }

        //הוספת מתנדב
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCNewVolanteer uv = new UCNewVolanteer();
            panel1.Controls.Add(uv);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button8.Visible = true;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDonations ud = new UCDonations();
            panel1.Controls.Add(ud);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button7.Visible = true;          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            panel1.Focus();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCAddEvent ue = new UCAddEvent();
            panel1.Controls.Add(ue);
        }
        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "123")
            {
                panel1.Controls.Clear();
                UCManager um = new UCManager();
                panel1.Controls.Add(um);
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox1, "הקוד שהוקש שגוי");
                textBox1.Text = "";
            }
            panel1.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {                     
            if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == textBox2.Text) != null)
            {
                panel1.Controls.Clear();
                UCVolanteer rt = new UCVolanteer(textBox2.Text);
                panel1.Controls.Add(rt);
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox2, "המתנדב אינו קיים במערכת");
                textBox2.Text = "";
            }
            panel1.Visible = true;

        }
     
        int p = MyDB.Event.GetList().Where(x => x.Statuscode == 3).Count();
        int r = MyDB.Volanteer.GetList().Where(x => x.Statusv == 1).Count();
        int q = MyDB.Donations.GetList().Count()+MyDB.Kilometer.GetList().Count();

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = r + "";
            label6.Text = q + "";
            label4.Text = p + "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
