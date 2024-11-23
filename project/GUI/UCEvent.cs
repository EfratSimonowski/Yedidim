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
    public partial class UCEvent : UserControl
    {
        string id;
        TblEvent currentevent;
        TblVolanteer currentvolanteer;
        public UCEvent()
        {
            InitializeComponent();
            comboBox1.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            currentevent = new TblEvent();
            currentvolanteer = new TblVolanteer();
            if ( MyDB.Event.GetList().FirstOrDefault(x => x.Volanteerid == id&&x.Statuscode==2)!=null)
            {
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Volanteerid == id&&x.Statuscode==2).Select(x => new {קוד=x.Eventcode, זהות = x.Volanteerid, תאריך=x.Datevent, שעה=x.Eventime, שם=x.Clientname, רחוב=x.Streetc, בית=x.Housenumc, סיבה=x.Reason, פלאפון=x.Clientphone }).OrderByDescending(x=>x.תאריך).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
                btnsta.Visible = true;
                button1.Visible = false; 
            }
            else
            {
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Statuscode == 1 && DateTime.Now.Day - x.Datevent.Day <= 1 && x.Datevent.Month == DateTime.Now.Month && x.Datevent.Year == DateTime.Now.Year).Select(x => new { קוד = x.Eventcode, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
         
        }
        public UCEvent(string id)
        {
            InitializeComponent();
            this.id = id;
            currentevent = new TblEvent();
            currentvolanteer = new TblVolanteer();
            comboBox1.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            if (MyDB.Event.GetList().FirstOrDefault(x => x.Volanteerid == id&&x.Statuscode==2) != null)
            {
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Volanteerid == id && x.Statuscode == 2 ).Select(x => new { קוד = x.Eventcode, זהות = x.Volanteerid, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
                btnsta.Visible = true;
                button1.Visible = false;
            }
            else
            {
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Statuscode == 1 && DateTime.Now.Day- x.Datevent.Day <= 1 && x.Datevent.Month == DateTime.Now.Month && x.Datevent.Year == DateTime.Now.Year).Select(x => new { קוד = x.Eventcode, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                //currentevent = MyDB.Event.GetList().FirstOrDefault(x => x.Eventcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
                currentevent.Volanteerid = id;
                currentevent.Statuscode = 2;
                MyDB.Event.UpdateItem(currentevent);
                MyDB.Event.SaveChanges();
                MessageBox.Show("הקריאה עודכנה בהצלחה");
            }
            else
            {
                MessageBox.Show("לא נבחרה קריאה");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                //currentevent = MyDB.Event.GetList().FirstOrDefault(x => x.Eventcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
                currentevent.Statuscode = 3;
                currentvolanteer = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == id);
                currentvolanteer.Points = currentvolanteer.Points + 2;
                MyDB.Volanteer.UpdateItem(currentvolanteer);
                MyDB.Volanteer.SaveChanges();
                MyDB.Event.UpdateItem(currentevent);
                MyDB.Event.SaveChanges();
                MessageBox.Show("הקריאה נסגרה בהצלחה");
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Statuscode == 1 && DateTime.Now.Day - x.Datevent.Day <= 1 && x.Datevent.Month == DateTime.Now.Month && x.Datevent.Year == DateTime.Now.Year).Select(x => new { קוד = x.Eventcode, זהות = x.Volanteerid, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                btnsta.Visible = false;
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("לא נבחר ארוע");
            }
        }

        private void UCEvent_Load(object sender, EventArgs e)
        {

        }
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyDB.Event.GetList().FirstOrDefault(x => x.Volanteerid == id && x.Statuscode == 2) != null)
            {
                string c = comboBox1.SelectedItem.ToString();
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Volanteerid == id && x.city.Cityname== c && x.Statuscode == 2 && DateTime.Now.Day - x.Datevent.Day <= 1 && x.Datevent.Month == DateTime.Now.Month && x.Datevent.Year == DateTime.Now.Year).Select(x => new { קוד = x.Eventcode, זהות = x.Volanteerid, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
            else
            {
                string c = comboBox1.SelectedItem.ToString();
                dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Statuscode == 1 && x.city.Cityname==c && DateTime.Now.Day - x.Datevent.Day <= 1 && x.Datevent.Month == DateTime.Now.Month && x.Datevent.Year == DateTime.Now.Year).Select(x => new { קוד = x.Eventcode, תאריך = x.Datevent, שעה = x.Eventime, שם = x.Clientname, רחוב = x.Streetc, בית = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(id);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentevent = MyDB.Event.GetList().FirstOrDefault(x => x.Eventcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
        }
    }
}
