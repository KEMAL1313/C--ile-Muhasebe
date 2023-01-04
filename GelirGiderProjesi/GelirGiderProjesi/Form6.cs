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
using System.Windows.Forms.DataVisualization.Charting;

namespace GelirGiderProjesi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        MonthProccess monthProccess = new MonthProccess();
        double gelirToplamWeek1 = 0;
        double gelirToplamWeek2 = 0;
        double gelirToplamWeek3 = 0;
        double gelirToplamWeek4 = 0;
        double giderToplamWeek1 = 0;
        double giderToplamWeek2 = 0;
        double giderToplamWeek3 = 0;
        double giderToplamWeek4 = 0;
        double genelGelirToplam = 0;
        double genelGiderToplam = 0;
        GelirProccess gelirProccess = new GelirProccess();
        GiderProccess giderProccess = new GiderProccess();
        private void Form6_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Gelir Gider Tablosu");      
        }

        private void button2_Click(object sender, EventArgs e)
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {

                            week1();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week2();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week3();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week4();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week5();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week6();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week7();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week8();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week9();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week10();
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
                    foreach (var month1 in monthProccess.List().ToList())
                    {
                        if (month.Id == month1.Id)
                        {
                            week11();
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
                        }
                    }


                }
            }
        }
        public void week1()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
                {
                    if (comboBox1.SelectedItem.ToString() == "Week1")
                    {

                        gelirToplamWeek1 = 0;
                        giderToplamWeek1 = 0;
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
                                giderToplamWeek1 += gider1.giderTutar;
                            }
                        }
                        this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                        this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                    }
                }
          
            
           
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }
            
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }
           
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }
            
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
            

        }
        public void week2()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week3()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week4()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week5()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week6()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week7()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week8()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week9()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week10()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week11()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }
        public void week12()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    gelirToplamWeek1 = 0;
                    giderToplamWeek1 = 0;
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
                            giderToplamWeek1 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("1.Hafta Harcamamız", gelirToplamWeek1);
                    this.chart1.Series["Gider"].Points.AddXY("1.Hafta Harcamamız", giderToplamWeek1);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {
                    gelirToplamWeek2 = 0;
                    giderToplamWeek2 = 0;
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
                            giderToplamWeek2 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("2.Hafta Harcamamız", gelirToplamWeek2);
                    this.chart1.Series["Gider"].Points.AddXY("2.Hafta Harcamamız", giderToplamWeek2);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    gelirToplamWeek3 = 0;
                    giderToplamWeek3 = 0;
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
                            giderToplamWeek3 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("3.Hafta Harcamamız", gelirToplamWeek3);
                    this.chart1.Series["Gider"].Points.AddXY("3 Hafta Harcamamız", giderToplamWeek3);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {
                    gelirToplamWeek4 = 0;
                    giderToplamWeek4 = 0;
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
                            giderToplamWeek4 += gider1.giderTutar;
                        }
                    }
                    this.chart1.Series["Gelir"].Points.AddXY("4.Hafta Harcamamız", gelirToplamWeek4);
                    this.chart1.Series["Gider"].Points.AddXY("4.Hafta Harcamamız", giderToplamWeek4);

                }
            }

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Monthly")
                {

                    genelGelirToplam = gelirToplamWeek1 + gelirToplamWeek2 + gelirToplamWeek3 + gelirToplamWeek4;
                    genelGiderToplam = giderToplamWeek1 + giderToplamWeek2 + giderToplamWeek3 + giderToplamWeek4;
                    this.chart1.Series["GelirToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGelirToplam);
                    this.chart1.Series["GiderToplam"].Points.AddXY("Bu Ayki Harcamamız", genelGiderToplam);
                }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
