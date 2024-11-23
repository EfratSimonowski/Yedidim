using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;

namespace project.GUI
{
    public partial class UCManager : UserControl
    {
        TblVolanteer v;
      
        public UCManager()
        {
            TblVolanteer v = new TblVolanteer();
            InitializeComponent();   
            
            dataGridView1.DataSource = MyDB.Volanteer.GetList().Where(x=>x.Statusv==0).Select(x=> new {משפחה=x.Lastname, שם = x.Firstname, זהות = x.Volanteerid, רחוב = x.Street, מספר = x.Volanteerphone,עיר=x.City.Cityname ,פלאפון = x.Volanteerphone }).ToList();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {


            if (dataGridView1.RowCount != 0)
            {
                DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך לדחות את הבקשה?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    v = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == dataGridView1.CurrentRow.Cells["זהות"].Value.ToString());
                    v.Statusv = 2;
                    MyDB.Volanteer.UpdateItem(v);
                    MyDB.Volanteer.SaveChanges();
                    dataGridView1.DataSource = MyDB.Volanteer.GetList().Where(x => x.Statusv == 0).Select(x => new { משפחה = x.Lastname, שם = x.Firstname, זהות = x.Volanteerid, רחוב = x.Street, מספר = x.Volanteerphone, עיר = x.City.Cityname, פלאפון = x.Volanteerphone }).ToList();
                    MessageBox.Show("הבקשה נדחתה בהצלחה!");
                }
                else
                {

                }
            }

            else
            {
                MessageBox.Show("לא נבחר מתנדב");
            }

        }
         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                v = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == dataGridView1.CurrentRow.Cells["זהות"].Value.ToString());
                v.Statusv = 1;
              
                MyDB.Volanteer.UpdateItem(v);
                MyDB.Volanteer.SaveChanges();
                dataGridView1.DataSource = MyDB.Volanteer.GetList().Where(x => x.Statusv == 0).Select(x => new { משפחה = x.Lastname, שם = x.Firstname, זהות = x.Volanteerid, רחוב = x.Street, מספר = x.Volanteerphone, עיר = x.City.Cityname, פלאפון = x.Volanteerphone }).ToList();
                MessageBox.Show("המתנדב נוסף בהצלחה!");
            }
            else
            {
                MessageBox.Show("לא נבחר מתנדב");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UCAddApi up = new UCAddApi();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UCAddProductApi up = new UCAddProductApi();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCDeletapi up = new UCDeletapi();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCDeletproapi up = new UCDeletproapi();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UCRandom up = new UCRandom();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void UCManager_Load(object sender, EventArgs e)
        {

        }
    }
}
