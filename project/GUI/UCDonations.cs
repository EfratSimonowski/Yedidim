using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;

namespace project.GUI
{
    public partial class UCDonations : UserControl
    {
        TblTools currenttool;
        TblDonors currentdonor;
        TblDonations currentdonations;
        TblApicenterProduct currentproduct;
        TblKilometer currentdkilometer;
        public UCDonations()
        {
            InitializeComponent();
            currentdkilometer = new TblKilometer();
            currentproduct = new TblApicenterProduct();
            currentdonor = new TblDonors();
            currentdonations = new TblDonations();
            currenttool = new TblTools();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboproduct.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
            comboapicity.DataSource = MyDB.Apicenter.GetList().Select(x => x.city.Cityname).ToList();/*MyDB.City.GetList().Select(X => X.Cityname).ToList();*/
            comboapi.DataSource = MyDB.Apicenter.GetList().Select(X => X.Apicenterstreet).ToList();
        }
        public UCDonations(TblDonors don) : this()
        {
            InitializeComponent();
            currentdonor = don;
            currentproduct = new TblApicenterProduct();
            FillFields(); 
            currentproduct = new TblApicenterProduct();
            comboproduct.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(txtnamef.TextLength < 2&& txtfirstn.TextLength < 2&&txtaddress.TextLength < 2)
                    {
             
                errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                txtfirstn.Text = "";
                errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                txtnamef.Text = "";
                errorProvider5.SetError(txtaddress, "הרחוב שהוקש אינו תקין");
                txtaddress.Text = "";

            }
            if (txtnamef.TextLength < 2)
            {
                errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                txtnamef.Text = "";
            }

            else
            {
                if (txtfirstn.TextLength < 2)
                {
                  errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                txtfirstn.Text = "";
                }

                else
                {
                    if (txtaddress.TextLength < 2)
                    {
                        errorProvider5.SetError(txtaddress, "הרחוב שהוקש אינו תקין");
                        txtaddress.Text = "";
                    }

                    else
                    {
                        if (!Validation.IsPelepon(txtphone.Text) && !Validation.CheckId(textBox1.Text))
                        {
                            errorProvider1.SetError(txtphone, "הפלאפון שהוקש שגוי");
                            txtphone.Text = "";
                            errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגויה");
                            textBox1.Text = "";
                        }
                        else
                        {
                            if (!Validation.IsPelepon(txtphone.Text))
                            {
                                errorProvider1.SetError(txtphone, "הפלאפון שהוקש שגוי");
                                txtphone.Text = "";
                            }
                            else
                            {
                                if (!Validation.CheckId(textBox1.Text))
                                {
                                    errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגויה");
                                    textBox1.Text = "";
                                }
                                else
                                {
                                    if (MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text) != null)
                                    {

                                        FillObj();
                                        MyDB.Donors.UpdateItem(currentdonor);
                                        MyDB.Donors.SaveChanges();
                                        MessageBox.Show("הלקוח עודכן בהצלחה!");
                                    }
                                    else
                                    {
                                        button1.Visible = true;
                                        button2.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        public void ShowDonationFields()
        {
            apicity.Visible = true;
            comboapicity.Visible = true;
            product.Visible = true;
            comboproduct.Visible = true;
            amount.Visible = true;
            numericUpDown1.Visible = true;
            api.Visible = true;
            comboapi.Visible = true;
            sum.Visible = true;
            txtsum.Visible = true;

            numc.Visible = true;
            txtnumc.Visible = true;

            cvv.Visible = true;
            txtcvv.Visible = true;
            btnok.Visible = true;
        }
        public void FillObj()
        {
            currentdonor.Donorcode = textBox1.Text;
            currentdonor.Firstnamedonor = txtfirstn.Text;
            currentdonor.Lastnamedonor = txtnamef.Text;
            currentdonor.Donorphone = txtphone.Text;
            currentdonor.Donorstreet = txtaddress.Text;
            currentdonor.Citycode = combocity.SelectedIndex + 1;
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckId(textBox1.Text))
            {
                errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגויה");
                textBox1.Text = "";
            }
            else
            {
                if (MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text) != null)
                {
                    currentdonor = MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text);
                    FillFields();
                    okd.Text = "עדכון";
                    button1.Visible = true; button2.Visible = true;
                    namef.Visible = true;
                    txtnamef.Visible = true;
                    phone.Visible = true;
                    txtphone.Visible = true;
                    address.Visible = true;
                    txtaddress.Visible = true;
                    city.Visible = true;
                    combocity.Visible = true;
                    okd.Visible = true;
                    firstn.Visible = true;
                    txtfirstn.Visible = true;
                }
                else
                {
                    txtnamef.Text = "";
                    txtphone.Text = "";
                    txtaddress.Text = "";
                    txtfirstn.Text = "";
                    namef.Visible = true;
                    txtnamef.Visible = true;
                    phone.Visible = true;
                    txtphone.Visible = true;
                    address.Visible = true;
                    txtaddress.Visible = true;
                    city.Visible = true;
                    combocity.Visible = true;
                    okd.Visible = true;
                    firstn.Visible = true;
                    txtfirstn.Visible = true;
                }
            }
        }
        public void FillFields()
        {
            txtfirstn.Text = currentdonor.Firstnamedonor;
            txtnamef.Text = currentdonor.Lastnamedonor;
            combocity.SelectedIndex = currentdonor.Citycode - 1;
            txtaddress.Text = currentdonor.Donorstreet;
            txtphone.Text = currentdonor.Donorphone;
        }
        private void UCDonations_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text==""||numericUpDown1.Value==0)
            {
                errorProvider10.SetError(numericUpDown1, "הערך שהוכנס אינו תקין");
                numericUpDown1.Text = "";
            }
            else { 
            if (txtnumc.TextLength != 16 && txtcvv.TextLength!= 3)
            {
                errorProvider8.SetError(txtnumc, "מספר האשראי שהוקש אינו תקין");
                txtnumc.Text = "";

                errorProvider9.SetError(txtcvv, "  שהוקש אינו תקין cvv");
                txtcvv.Text = "";

            }
            if (txtnumc.TextLength != 16 )
            {
                errorProvider8.SetError(txtnumc, "מספר האשראי שהזנת אינו תקין");
                txtnumc.Text = "";
            }

            else
            {

                    if (txtcvv.TextLength != 3)
                    {
                        errorProvider9.SetError(txtcvv, "cvv שהוקש אינו תקין");
                        txtcvv.Text = "";
                    }

                    else
                    {

                      
                        if (numericUpDown1.Value * (MyDB.Tools.GetList().FirstOrDefault(X => X.Toolname == comboproduct.SelectedValue.ToString()).Toolprice) != Convert.ToInt32(txtsum.Text))
                        {
                            MessageBox.Show("הסכום לא תואם למוצרים שנבחרו");

                        }
                        else
                        {
                            if (MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text) == null)
                            {
                                if (txtnamef.TextLength < 2 && txtfirstn.TextLength < 2 && txtaddress.TextLength < 2)
                                {
                                    errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                                    txtnamef.Text = "";
                                    errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                                    txtfirstn.Text = "";
                                    errorProvider5.SetError(txtaddress, "הרחוב שהוקש אינו תקין");
                                    txtaddress.Text = "";

                                }
                                if (txtnamef.TextLength < 2)
                                {
                                    errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                                    txtnamef.Text = "";
                                }

                                else
                                {
                                    if (txtfirstn.TextLength < 2)
                                    {
                                        errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                                        txtfirstn.Text = "";
                                    }

                                    else
                                    {
                                        if (txtaddress.TextLength < 2)
                                        {
                                            errorProvider5.SetError(txtaddress, "הרחוב שהוקש אינו תקין");
                                            txtaddress.Text = "";
                                        }

                                        else
                                        {

                                            if (!Validation.IsPelepon(txtphone.Text)  && !Validation.CheckId(textBox1.Text))
                                            {
                                                errorProvider1.SetError(txtphone, "הפלאפון שהוקש שגוי");
                                                txtphone.Text = "";
                                                errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגויה");
                                                textBox1.Text = "";
                                            }
                                            else
                                            {
                                                if (!Validation.IsPelepon(txtphone.Text))
                                                {
                                                    errorProvider1.SetError(txtphone, "הפלאפון שהוקש שגוי");
                                                    txtphone.Text = "";
                                                }
                                                else
                                                {
                                                    if (!Validation.CheckId(textBox1.Text))
                                                    {
                                                        errorProvider2.SetError(textBox1, "תעודת זהות שהוקשה שגויה");
                                                        textBox1.Text = "";
                                                    }
                                                    else
                                                    {

                                                        FillObj();
                                                        MyDB.Donors.AddItem(currentdonor);
                                                        MyDB.Donors.SaveChanges();

                                                        currentdonations.Donationcode = MyDB.Donations.GetNextKey();
                                                        currentdonations.Toolcode = MyDB.Tools.GetList().FirstOrDefault(X => X.Toolname == comboproduct.SelectedValue.ToString()).Toolcode;
                                                        currentdonations.Datedonation = DateTime.Today;
                                                        currentdonations.Donorcode = MyDB.Donors.GetList().FirstOrDefault(X => X.Donorcode == textBox1.Text).Donorcode;
                                                        currentdonations.Citycode = MyDB.City.GetList().FirstOrDefault(X => X.Cityname == comboapicity.SelectedValue.ToString()).Citycode;
                                                        currentdonations.Apicentercode = MyDB.Apicenter.GetList().FirstOrDefault(X => X.Apicenterstreet == comboapi.SelectedValue.ToString()).Apicentercode;
                                                        currentdonations.Amountd = Convert.ToInt32(numericUpDown1.Text);
                                                        currentdonations.Sumd = Convert.ToInt32(txtsum.Text);

                                                        MyDB.Donations.AddItem(currentdonations);
                                                        MyDB.Donations.SaveChanges();

                                                        if (MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.apicenter.Apicenterstreet == comboapi.Text && x.tools.Toolname == comboproduct.Text) != null)
                                                        {
                                                            currentproduct = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.tools.Toolname == comboproduct.Text && x.apicenter.Apicenterstreet == comboapi.Text);
                                                            currentproduct.Amountinstock = currentproduct.Amountinstock + Convert.ToInt32(numericUpDown1.Text);
                                                            MyDB.ApicenterProduct.UpdateItem(currentproduct);
                                                            MyDB.ApicenterProduct.SaveChanges();
                                                            MessageBox.Show(" פרטי התורם והתרומה נוספו בהצלחה! תודה על תרומתך");
                                                        }
                                                        else
                                                        {
                                                            //currentproduct = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.apicenter.Apicenterstreet == comboapi.Text);
                                                            currentproduct.Apicenterproductcode = MyDB.ApicenterProduct.GetNextKey();
                                                            currentproduct.Apicentercode = MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicenterstreet == comboapi.SelectedValue.ToString()).Apicentercode;
                                                            //currentproduct.apicenter.Apicenterstreet = comboapi.Text;
                                                            currentproduct.Phonem = MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicenterstreet == comboapi.Text).Managerphone;
                                                            currentproduct.Amountinstock = Convert.ToInt32(numericUpDown1.Text);
                                                            currentproduct.Toolcode = MyDB.Tools.GetList().FirstOrDefault(x => x.Toolname == comboproduct.SelectedValue.ToString()).Toolcode;
                                                            //currentproduct.tools.Toolname = comboproduct.Text;
                                                            currentproduct.Citycode = MyDB.Apicenter.GetList().FirstOrDefault(x => x.city.Cityname == comboapicity.SelectedValue.ToString()).Citycode;
                                                            MyDB.ApicenterProduct.AddItem(currentproduct);
                                                            MyDB.ApicenterProduct.SaveChanges();
                                                            MessageBox.Show(" פרטי התורם והתרומה נוספו בהצלחה! תודה על תרומתך");
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            else


                            {


                                currentdonations.Donationcode = MyDB.Donations.GetNextKey();
                                currentdonations.Toolcode = MyDB.Tools.GetList().FirstOrDefault(X => X.Toolname == comboproduct.SelectedValue.ToString()).Toolcode;
                                currentdonations.Datedonation = DateTime.Today;
                                currentdonations.Donorcode = MyDB.Donors.GetList().FirstOrDefault(X => X.Donorcode == textBox1.Text).Donorcode;
                                currentdonations.Citycode = MyDB.City.GetList().FirstOrDefault(X => X.Cityname == comboapicity.SelectedValue.ToString()).Citycode;
                                currentdonations.Apicentercode = MyDB.Apicenter.GetList().FirstOrDefault(X => X.Apicenterstreet == comboapi.SelectedValue.ToString()).Apicentercode;
                                currentdonations.Amountd = Convert.ToInt32(numericUpDown1.Text);
                                currentdonations.Sumd = Convert.ToInt32(txtsum.Text);
                                MyDB.Donations.AddItem(currentdonations);
                                MyDB.Donations.SaveChanges();

                                if (MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.apicenter.Apicenterstreet == comboapi.Text && x.tools.Toolname == comboproduct.Text) != null)
                                {
                                    currentproduct = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.tools.Toolname == comboproduct.Text && x.apicenter.Apicenterstreet == comboapi.Text);
                                    currentproduct.Amountinstock = currentproduct.Amountinstock + Convert.ToInt32(numericUpDown1.Text);
                                    MyDB.ApicenterProduct.UpdateItem(currentproduct);
                                    MyDB.ApicenterProduct.SaveChanges();
                                    MessageBox.Show("תודה על תרומתך");
                                }
                                else
                                {
                                    //currentproduct = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.apicenter.Apicenterstreet == comboapi.Text);
                                    currentproduct.Apicenterproductcode = MyDB.ApicenterProduct.GetNextKey();
                                    currentproduct.Apicentercode = MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicenterstreet == comboapi.SelectedValue.ToString()).Apicentercode;
                                    //currentproduct.apicenter.Apicenterstreet = comboapi.Text;
                                    currentproduct.Phonem = MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicenterstreet == comboapi.Text).Managerphone;
                                    currentproduct.Amountinstock = Convert.ToInt32(numericUpDown1.Text);
                                    currentproduct.Toolcode = MyDB.Tools.GetList().FirstOrDefault(x => x.Toolname == comboproduct.SelectedValue.ToString()).Toolcode;
                                    //currentproduct.tools.Toolname = comboproduct.Text;
                                    currentproduct.Citycode = MyDB.Apicenter.GetList().FirstOrDefault(x => x.city.Cityname == comboapicity.SelectedValue.ToString()).Citycode;
                                    MyDB.ApicenterProduct.AddItem(currentproduct);
                                    MyDB.ApicenterProduct.SaveChanges();
                                    MessageBox.Show("תודה על תרומת ");
                                }


                            }


                        }



                    }
                            
                        
                    

                }

            }
        }

        private void comboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }


        private void txtsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
        private void txtnumc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
        private void txtcvv_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtcvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
        private void comboapicity_SelectedIndexChanged(object sender, EventArgs e)
        {
           //int P = MyDB.Apicenter.GetList().FirstOrDefault(x => x.city.Cityname == comboapicity.SelectedItem.ToString()).Citycode;
            int s = MyDB.City.GetList().FirstOrDefault(x => x.Cityname == comboapicity.SelectedItem.ToString()).Citycode;
            comboapi.DataSource = MyDB.Apicenter.GetList().Where(x => x.Citycode ==s).Select(x => x.Apicenterstreet).ToList();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int p = MyDB.Tools.GetList().FirstOrDefault(X => X.Toolname == comboproduct.SelectedValue.ToString()).Toolprice;
            txtsum.Text = (p * Convert.ToInt32(numericUpDown1.Value)).ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboapi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtfirstn_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtsum_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtnumc_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboproduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            currenttool = MyDB.Tools.GetList().FirstOrDefault(x => x.Toolname == comboproduct.SelectedItem.ToString());
            txtsum.Text = currenttool.Toolprice.ToString();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = 1;
            txtsum.Text = currenttool.Toolprice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDonationFields();
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox5.Visible = false;
            label4.Visible = false;
            textBox6.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox5.Visible = true;
            label4.Visible = true;
            textBox6.Visible = true;
            button3.Visible = true;
            apicity.Visible = false;
            comboapicity.Visible = false;
            product.Visible = false;
            comboproduct.Visible = false;
            amount.Visible = false;
            numericUpDown1.Visible = false;
            api.Visible = false;
            comboapi.Visible = false;
            sum.Visible = false;
            txtsum.Visible = false;
            numc.Visible = false;
            txtnumc.Visible = false;
            cvv.Visible = false;
            txtcvv.Visible = false;
            btnok.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
                        if (textBox5.TextLength !=16 && textBox6.TextLength != 3)
                        {
                            errorProvider6.SetError(textBox5, "מספר האשראי שהוקש אינו תקין");
                            textBox5.Text = "";
                          
                            errorProvider7.SetError(textBox6, "cvv שהוקש אינו תקין");
                            textBox6.Text = "";

                        }
                        if (textBox5.TextLength != 16)
                        {
                            errorProvider6.SetError(textBox5, "מספר האשראי שהזנת אינו תקין");
                            textBox5.Text = "";
                        }

                        else
                        {

                if (textBox6.TextLength != 3)
                {
                    errorProvider7.SetError(textBox6, " שהוקש אינו תקין cvv ");
                    textBox6.Text = "";
                }

                else
                {



                    if (MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text) == null)
                    {
                        if (txtnamef.TextLength < 2 && txtfirstn.TextLength < 2  && txtaddress.TextLength < 2)
                        {
                            errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                            txtnamef.Text = "";
                            errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                            txtfirstn.Text = "";
                            errorProvider5.SetError(txtaddress, " שם הרחוב שהוקש אינו תקין");
                            txtaddress.Text = "";

                        }
                        if (txtnamef.TextLength < 2)
                        {
                            errorProvider3.SetError(txtnamef, "השם שהוקש אינו תקין");
                            txtnamef.Text = "";
                        }

                        else
                        {
                            if (txtfirstn.TextLength < 2)
                            {
                                errorProvider4.SetError(txtfirstn, "השם שהוקש אינו תקין");
                                txtfirstn.Text = "";
                            }

                            else
                            {
                                if (txtaddress.TextLength < 2)
                                {
                                    errorProvider5.SetError(txtaddress, " שם הרחוב שהוקש אינו תקין");
                                    txtaddress.Text = "";
                                }

                                else
                                {
                                    if (!Validation.IsPelepon(txtphone.Text) && !Validation.CheckId(textBox1.Text))
                                    {
                                        errorProvider1.SetError(txtphone, "הפלאפון שהוקש שגוי");
                                        txtphone.Text = "";
                                        errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגויה");
                                        textBox1.Text = "";
                                    }
                                    else
                                    {
                                        if (!Validation.IsPelepon(txtphone.Text))
                                        {
                                            errorProvider1.SetError(txtphone, "פלאפון שהוקש שגוי");
                                            txtphone.Text = "";
                                        }
                                        else
                                        {



                                            if (!Validation.CheckId(textBox1.Text))
                                            {
                                                errorProvider2.SetError(textBox1, "התעודת זהות שהוקשה שגוי");
                                                textBox1.Text = "";
                                            }
                                            else
                                            {


                                                FillObj();
                                                MyDB.Donors.AddItem(currentdonor);
                                                MyDB.Donors.SaveChanges();
                                                currentdkilometer.Datedonation = DateTime.Today;
                                                currentdkilometer.Donorcode = MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text).Donorcode;
                                                currentdkilometer.Moneydonationcode = MyDB.Kilometer.GetNextKey();
                                                currentdkilometer.Sumdd = Convert.ToInt32(textBox2.Text);
                                                MyDB.Kilometer.AddItem(currentdkilometer);
                                                MyDB.Kilometer.SaveChanges();
                                                MessageBox.Show(" פרטי התורם והתרומה נוספו בהצלחה! תודה על תרומתך");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        currentdkilometer.Datedonation = DateTime.Today;
                        currentdkilometer.Donorcode = MyDB.Donors.GetList().FirstOrDefault(x => x.Donorcode == textBox1.Text).Donorcode;
                        currentdkilometer.Moneydonationcode = MyDB.Kilometer.GetNextKey();
                        currentdkilometer.Sumdd = Convert.ToInt32(textBox2.Text);
                        MyDB.Kilometer.AddItem(currentdkilometer);
                        MyDB.Kilometer.SaveChanges();
                        MessageBox.Show(" תודה על תרומתך ");
                    }
                            }
                        }
                    }


                                
                
           
        
    
                
        

        private void txtfirstn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;

        }

        private void txtnamef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
          
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
            if (!Validation.IsEnglish(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
