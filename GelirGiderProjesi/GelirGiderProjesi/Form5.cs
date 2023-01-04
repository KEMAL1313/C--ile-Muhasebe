using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderProjesi
{
    public partial class Form5 : Form
    {
        double GenelGelirToplam = 0;
        double GenelGiderToplam = 0;
        double gelirToplamWeek1 = 0;
        double gelirToplamWeek2 = 0;
        double gelirToplamWeek3 = 0;
        double gelirToplamWeek4 = 0;
        double gidertoplamWeek1 = 0;
        double gidertoplamWeek2 = 0;
        double gidertoplamWeek3 = 0;
        double gidertoplamWeek4 = 0;
        MonthProccess monthProccess = new MonthProccess();
        Month month = new Month();
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ay();
        }
        public void ay()
        {

            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Ocak")
                {
                    int id = 1;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {

                            week1();
                            break;
                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Subat")
                {
                    int id = 2;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week2();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Mart")
                {
                    int id = 3;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week3();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Nisan")
                {
                    int id = 4;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week4();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Mayis")
                {
                    int id = 5;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week5();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Haziran")
                {
                    int id = 6;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week6();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Temmuz")
                {
                    int id = 7;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week7();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Agustos")
                {
                    int id = 8;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week8();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Eylul")
                {
                    int id = 9;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week9();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Ekim")
                {
                    int id = 10;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week10();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Kasim")
                {
                    int id = 11;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in DbContext.months.ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week11();
                            break;

                        }
                    }


                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                if (comboBox2.SelectedItem.ToString() == "Aralik")
                {
                    int id = 12;
                    Month month = monthProccess.Detail(id);
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week12();
                            break;

                        }
                    }


                }
            }
        }
        public void week1()
        {
            Form3 form3 = new Form3();
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();

            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 1;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }
          

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                  
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

               

                if (gelir != null && gider != null)
                {

                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                        

                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                        
                    }
                }

               

            }



            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 2;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 3;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 4;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {
               
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                gelirgiderList1();


            }

        }
        public void week2()
        {

            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 5;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
               
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }
                
            }
          


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 6;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 7;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 8;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;

                gelirgiderList2();

            }
        }
        public void week3()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 9;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 10;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 11;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 12;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList3();
            }
        }
        public void week4()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 13;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 14;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 15;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 16;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList4();
            }
        }
        public void week5()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 17;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 18;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 19;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 20;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;  
                gelirgiderList5();
            }
        }
        public void week6()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 21;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 22;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 23;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 24;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList6();
            }
        }
        public void week7()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 25;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 26;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 27;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 28;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
              
                gelirgiderList7();
            }
        }
        public void week8()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 29;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 30;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 31;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 32;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList8();
            }
        }
        public void week9()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 33;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 34;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 35;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 36;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;  
                gelirgiderList9();
            }
        }
        public void week10()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 37;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 38;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 39;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 40;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList10();
            }
        }
        public void week11()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 41;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 42;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 43;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 44;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList11();
            }
        }
        public void week12()
        {
            GelirProccess gelirProccess = new GelirProccess();
            GiderProccess giderProccess = new GiderProccess();
            if (comboBox1.SelectedItem.ToString() == "Week1")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek1 = 0;
                gidertoplamWeek1 = 0;
                int id = 45;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek1 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek1 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek1.ToString() + " ₺";
                label5.Text = gidertoplamWeek1.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir.Id == gelir1.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider.Id == gider1.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }


            }


            if (comboBox1.SelectedItem.ToString() == "Week2")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek2 = 0;
                gidertoplamWeek2 = 0;
                int id = 46;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek2 += gelir1.gelirTutar;
                    }
                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek2 += gider1.giderTutar;
                    }
                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek2.ToString() + " ₺";
                label5.Text = gidertoplamWeek2.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week3")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek3 = 0;
                gidertoplamWeek3 = 0;
                int id = 47;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek3 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek3 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek3.ToString() + " ₺";
                label5.Text = gidertoplamWeek3.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Week4")
            {
                label1.Visible = false;
                label6.Visible = false;
                gelirToplamWeek4 = 0;
                gidertoplamWeek4 = 0;
                int id = 48;
                Gelir gelir = gelirProccess.Detail(id);
                Gider gider = giderProccess.Detail(id);
                foreach (var gelir1 in gelirProccess.List().ToList())
                {
                    if (gelir1.Id == gelir.Id)
                    {
                        gelirToplamWeek4 += gelir1.gelirTutar;
                    }

                }
                foreach (var gider1 in giderProccess.List().ToList())
                {
                    if (gider1.Id == gider.Id)
                    {
                        gidertoplamWeek4 += gider1.giderTutar;
                    }

                }
                label2.Text = "Gelir Toplam";
                label3.Text = "Gider Toplam";
                label4.Text = gelirToplamWeek4.ToString() + " ₺";
                label5.Text = gidertoplamWeek4.ToString() + " ₺";
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                if (gelir != null && gider != null)
                {
                    foreach (var gelir1 in DbContext.GelirList.ToList())
                    {
                        if (gelir1.Id == gelir.Id)
                        {
                            listBox1.Items.Add("Gelir:" + " " + gelir1.gelirKalemi + " " + gelir1.gelirTutar);
                        }
                    }
                    foreach (var gider1 in DbContext.GiderList)
                    {
                        if (gider1.Id == gider.Id)
                        {
                            listBox2.Items.Add("Gider:" + " " + gider1.giderKalemi + " " + gider1.giderTutar);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Monthly")
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                GenelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                GenelGiderToplam = gidertoplamWeek1 + gidertoplamWeek2 + gidertoplamWeek3 + gidertoplamWeek4;
                gelirgiderList12();
            }
        }
        GelirProccess gelirProccess = new GelirProccess();
        GiderProccess giderProccess = new GiderProccess();

        public void gelirgiderList1()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 1 || gelir.Id == 2 || gelir.Id == 3 || gelir.Id == 4)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 1 || gider.Id == 2 || gider.Id == 3 || gider.Id == 4)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 1 || gelir.Id == 2 || gelir.Id == 3 || gelir.Id == 4)
                {
                    GenelGelirToplam += gelir.gelirTutar ;
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
               
                
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 1 || gider.Id == 2 || gider.Id == 3 || gider.Id == 4)
                {
                    GenelGiderToplam += gider.giderTutar ;                    
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
               
            }
            if (GenelGelirToplam>GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString()+ " ₺";  
            }
            else if (GenelGiderToplam>GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList2()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 5 || gelir.Id == 6 || gelir.Id == 7 || gelir.Id == 8)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 5 || gider.Id == 6 || gider.Id == 7 || gider.Id == 8)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 5 || gelir.Id == 6 || gelir.Id == 7 || gelir.Id == 8)
                {
                   
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
                
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 5 || gider.Id == 6 || gider.Id == 7 || gider.Id == 8)
                {
                  
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
              

            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList3()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 9 || gelir.Id == 10 || gelir.Id == 11 || gelir.Id == 12)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 9 || gider.Id == 10 || gider.Id == 11 || gider.Id == 12)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 9 || gelir.Id == 10 || gelir.Id == 11 || gelir.Id == 12)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 9 || gider.Id == 10 || gider.Id == 11 || gider.Id == 12)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList4()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 13 || gelir.Id == 14 || gelir.Id == 15 || gelir.Id == 16)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 13 || gider.Id == 14 || gider.Id == 15 || gider.Id == 16)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 13 || gelir.Id == 14 || gelir.Id == 15 || gelir.Id == 16)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 13 || gider.Id == 14 || gider.Id == 15 || gider.Id == 16)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList5()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 17 || gelir.Id == 18 || gelir.Id == 19 || gelir.Id == 20)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 17 || gider.Id == 18 || gider.Id == 19 || gider.Id == 20)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 17 || gelir.Id == 18 || gelir.Id == 19 || gelir.Id == 20)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 17 || gider.Id == 18 || gider.Id == 19 || gider.Id == 20)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList6()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 21 || gelir.Id == 22 || gelir.Id == 23 || gelir.Id == 24)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 21 || gider.Id == 22 || gider.Id == 23 || gider.Id == 24)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 21 || gelir.Id == 22 || gelir.Id == 23 || gelir.Id == 24)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 21 || gider.Id == 22 || gider.Id == 23 || gider.Id == 24)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }

        }
        public void gelirgiderList7()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 25 || gelir.Id == 26 || gelir.Id == 27 || gelir.Id == 28)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 25 || gider.Id == 26 || gider.Id == 27 || gider.Id == 28)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 25 || gelir.Id == 26 || gelir.Id == 27 || gelir.Id == 28)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 25 || gider.Id == 26 || gider.Id == 27 || gider.Id == 28)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList8()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 29 || gelir.Id == 30 || gelir.Id == 31 || gelir.Id == 32)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 29 || gider.Id == 30 || gider.Id == 31 || gider.Id == 32)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 29 || gelir.Id == 30 || gelir.Id == 31 || gelir.Id == 32)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 29 || gider.Id == 30 || gider.Id == 31 || gider.Id == 32)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList9()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 33 || gelir.Id == 34 || gelir.Id == 35 || gelir.Id == 36)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 33 || gider.Id == 34 || gider.Id == 35 || gider.Id == 36)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 33 || gelir.Id == 34 || gelir.Id == 35 || gelir.Id == 36)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 33 || gider.Id == 34 || gider.Id == 35 || gider.Id == 36)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList10()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 37 || gelir.Id == 38 || gelir.Id == 39 || gelir.Id == 40)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 37 || gider.Id == 38 || gider.Id == 39 || gider.Id == 40)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 37 || gelir.Id == 38 || gelir.Id == 39 || gelir.Id == 40)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 37 || gider.Id == 38 || gider.Id == 39 || gider.Id == 40)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList11()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 41 || gelir.Id == 42 || gelir.Id == 43 || gelir.Id == 44)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 41 || gider.Id == 42 || gider.Id == 43 || gider.Id == 44)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 41 || gelir.Id == 42 || gelir.Id == 43 || gelir.Id == 44)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 41 || gider.Id == 42 || gider.Id == 43 || gider.Id == 44)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }
        public void gelirgiderList12()
        {
            gidertoplamWeek1 = 0;
            gidertoplamWeek2 = 0;
            gidertoplamWeek3 = 0;
            gidertoplamWeek4 = 0;
            gelirToplamWeek1 = 0;
            gelirToplamWeek2 = 0;
            gelirToplamWeek3 = 0;
            gelirToplamWeek4 = 0;
            GenelGelirToplam = 0;
            GenelGiderToplam = 0;
            label1.Visible = true;
            label6.Visible = true;
            foreach (var gelir in gelirProccess.List().ToList())
            {
                if (gelir.Id == 45 || gelir.Id == 46 || gelir.Id == 47 || gelir.Id == 48)
                {
                    listBox1.Items.Add(gelir.gelirKalemi + " " + gelir.gelirTutar + " ₺");
                    listBox1.Items.Add("------------------------");
                }

            }
            foreach (var gider in giderProccess.List().ToList())
            {
                if (gider.Id == 45 || gider.Id == 46 || gider.Id == 47 || gider.Id == 48)
                {
                    listBox2.Items.Add(gider.giderKalemi + " " + gider.giderTutar + " ₺");
                    listBox2.Items.Add("------------------------");

                }
            }
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == 45 || gelir.Id == 46 || gelir.Id == 47 || gelir.Id == 48)
                {
                    GenelGelirToplam += (gelir.gelirTutar);
                    label2.Text = "Gelir Aylık Toplam:";
                    label4.Text = GenelGelirToplam.ToString() + " ₺";
                }
            }
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == 45 || gider.Id == 46 || gider.Id == 47 || gider.Id == 48)
                {
                    GenelGiderToplam += (gider.giderTutar);
                    label3.Text = "Gider Aylık Toplam:";
                    label5.Text = GenelGiderToplam.ToString() + " ₺";
                }
            }
            if (GenelGelirToplam > GenelGiderToplam)
            {
                label1.Text = "Bu Ayki Kar Tutarı:";
                int sayi = Convert.ToInt32(GenelGelirToplam) - Convert.ToInt32(GenelGiderToplam);
                label6.Text = sayi.ToString() + " ₺";
            }
            if (GenelGiderToplam > GenelGelirToplam)
            {
                label1.Text = "Bu Ayki Zarar Tutarı:";
                int sayi1 = Convert.ToInt32(GenelGiderToplam) - Convert.ToInt32(GenelGelirToplam);
                label6.Text = sayi1.ToString() + " ₺";
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Gelir Toplam";
            label3.Text = "Gider Toplam";
            label4.Text = "0";
            label5.Text = "0";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label1.Visible = false;
            label6.Visible = false;
        }
    }
}
