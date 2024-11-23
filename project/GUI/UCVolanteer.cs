using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;

namespace project.GUI
{
   
   
    public partial class UCVolanteer : UserControl
    {
  
        TblVolanteer currentvolan;
        TblVolanteer currentvolanteer;
      
        string vId;
      
        public UCVolanteer()
        {
            InitializeComponent();
            currentvolanteer = new TblVolanteer();
          
            currentvolan = new TblVolanteer();
            if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vId && DateTime.Now.Year - x.Dateloanepicenter.Year > 1) != null)
            {
                label1.Visible = true;
            }
            else if (MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId && DateTime.Now.Year - x.Dateofloan.Year > 1) != null)
            {
                label2.Visible = true;
            }
            if (MyDB.Volanteer.GetList().FirstOrDefault(x =>x.Volanteerid==vId && x.Message != "" ) != null)
            {
                currentvolan = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId && x.Message != "");
                label3.Visible = true;
                label3.Text = currentvolan.Message;
            }
        }
      
        
       
        public UCVolanteer(string id)
        {
            InitializeComponent();
          
            this.vId = id;          
            currentvolanteer = new TblVolanteer();           
            currentvolan=new TblVolanteer();
            if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vId && DateTime.Now.Year - x.Dateloanepicenter.Year > 1) != null)
            {
                label1.Visible = true;
            }
            else if(MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId&&DateTime.Now.Year - x.Dateofloan.Year > 1) != null) 
            {
                label2.Visible = true;
            }
            if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId && x.Message != "") != null)
            {
                currentvolan = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId && x.Message != "");
                label3.Visible = true;
                label3.Text = currentvolan.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCEvent up=new UCEvent(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button7.Visible=true;  
            button8.Visible=false;
            button9.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button9.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UCProduct up = new UCProduct(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UCStatus up = new UCStatus(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            וןןן up = new וןןן(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UCReturnv up = new UCReturnv(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vId&&x.Returnedproduct==false) != null && MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId&&x.Raturned==false) != null)
            {
                MessageBox.Show("ברשותך מוצר מושאל ממתנדב וממוקד עליך להחזירו לביטול ההתנדבות");
            }
            else
            {
                if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vId&&x.Returnedproduct==false) == null)
                {
                    if (MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId&&x.Raturned==false) == null)
                    {
                        currentvolan = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId);
                        DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך לצאת לגמרי ממערך המתנדבים?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            MyDB.Volanteer.DeleteItem(currentvolan);
                            MyDB.Volanteer.SaveChanges();
                            MessageBox.Show("המתנדב יצא בהצלחה!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ברשותך מוצר מושאל ממתנדב עליך להחזירו לביטול ההתנדבות");
                    }

                }
                else
                {
                    MessageBox.Show("ברשותך מוצר מושאל ממוקד עליך להחזירו לביטול ההתנדבות");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            currentvolanteer =MyDB.Volanteer.GetList().FirstOrDefault(x=>x.Volanteerid == vId);
            UCApvolanteer up = new UCApvolanteer(vId, currentvolanteer);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }
       
    }
}
