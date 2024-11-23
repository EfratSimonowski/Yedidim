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
    public partial class UCDeletapi : UserControl
    {
        TblApicenter currentapicenter;
        public UCDeletapi()
        {
            InitializeComponent();
            currentapicenter = new TblApicenter();
            dataGridView1.DataSource = MyDB.Apicenter.GetList().Select(x => new { עיר = x.city.Cityname,קוד=x.Apicentercode,רחוב=x.Apicenterstreet,פלאפון=x.Managerphone,בית=x.Apicenterhousenum }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
            comboBox1.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.Apicenter.GetList().Where(x => x.city.Cityname == c).Select(x => new {קוד =x.Apicentercode,עיר = x.city.Cityname, רחוב = x.Apicenterstreet, פלאפון = x.Managerphone, בית = x.Apicenterhousenum }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המוקד?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
            currentapicenter = MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicentercode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
            MyDB.Apicenter.DeleteItem(currentapicenter);
            MyDB.Apicenter.SaveChanges();
            dataGridView1.DataSource = MyDB.Apicenter.GetList().Select(x => new { קוד = x.Apicentercode, עיר = x.city.Cityname, רחוב = x.Apicenterstreet, פלאפון = x.Managerphone, בית = x.Apicenterhousenum }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
                MessageBox.Show("המוקד נמחק בהצלחה!");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCManager up = new UCManager();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }
    }
}
