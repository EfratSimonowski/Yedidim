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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project.GUI
{
    public partial class UCAddApi : UserControl
    {
        TblApicenter currentapicenter;
        public UCAddApi()
        {
            InitializeComponent();
            currentapicenter = new TblApicenter();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtstreet.TextLength < 2 )
            {
                errorProvider2.SetError(txtstreet, " שם הרחוב שהוקש אינו תקין");
                txtstreet.Text = "";
            }

            else
            {
                if (numerih.Text == "" || numerih.Value == 0)
                {
                    errorProvider3.SetError(numerih, "הערך שהוקש אינו תקין");
                    numerih.Text = "";
                }

                else
                {
                    if (!Validation.CheckId(txtnump.Text) )
                    {
                        errorProvider1.SetError(txtnump, "תעודת הזהות שהוקשה שגויה");
                        txtnump.Text = "";
                    }
                    else
                    {

                        currentapicenter.Apicentercode = MyDB.Apicenter.GetNextKey();
                        if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtnump.Text) != null)
                        {
                            if (MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicenterstreet == txtstreet.Text && x.city.Cityname == combocity.Text) == null)
                            {

                                currentapicenter.Managerphone = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtnump.Text).Volanteerphone;
                                currentapicenter.Citycode = combocity.SelectedIndex + 1;
                                currentapicenter.Apicenterstreet = txtstreet.Text;
                                currentapicenter.Apicenterhousenum = Convert.ToInt32(numerih.Value);
                                MyDB.Apicenter.AddItem(currentapicenter);
                                MyDB.Apicenter.SaveChanges();
                                MessageBox.Show("המוקד נוסף לרשימה בהצלחה");
                            }
                            else
                            {
                                MessageBox.Show("ברחוב זה קיים מוקד ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("מתנדב לא קיים ");
                        }
                    }
                }
            }
        }
        public void FillObj() 
        {
           
        }
        private void txtnump_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
        private void UCAddApi_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UCManager up = new UCManager();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void txtstreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
