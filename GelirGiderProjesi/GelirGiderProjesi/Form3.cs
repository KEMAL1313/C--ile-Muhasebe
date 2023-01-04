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
    public partial class Form3 : Form
    {
        MonthProccess monthProccess = new MonthProccess();
        Gelir gelir = new Gelir();
        public Form3()
        {
            InitializeComponent();
        }
        GelirProccess gelirProccess = new GelirProccess();
        GiderProccess giderProccess = new GiderProccess();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        public double gelirToplamWeek1 = 0;
        public double gelirToplamWeek2 = 0;
        public double gelirToplamWeek3 = 0;
        public double gelirToplamWeek4 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            ay();
        }
        public void ay()
        {
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Ocak")
                {
                    month.Id = 1;
                    if (monthProccess.Add(month))
                    {
                        gelir1();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Subat")
                {
                    month.Id = 2;
                    if (monthProccess.Add(month))
                    {
                        gelir2();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Mart")
                {
                    month.Id = 3;
                    if (monthProccess.Add(month))
                    {
                        gelir3();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Nisan")
                {
                    month.Id = 4;
                    if (monthProccess.Add(month))
                    {
                        gelir4();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Mayis")
                {
                    month.Id = 5;
                    if (monthProccess.Add(month))
                    {
                        gelir5();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Haziran")
                {
                    month.Id = 6;
                    if (monthProccess.Add(month))
                    {
                        gelir6();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Temmuz")
                {
                    month.Id = 7;
                    if (monthProccess.Add(month))
                    {
                        gelir7();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Agustos")
                {
                    month.Id = 8;
                    if (monthProccess.Add(month))
                    {
                        gelir8();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Eylul")
                {
                    month.Id = 9;
                    if (monthProccess.Add(month))
                    {
                        gelir9();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Ekim")
                {
                    month.Id = 10;
                    if (monthProccess.Add(month))
                    {
                        gelir10();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Kasim")
                {
                    month.Id = 11;
                    if (monthProccess.Add(month))
                    {
                        gelir11();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                Month month = new Month();
                if (comboBox2.SelectedItem.ToString() == "Aralik")
                {
                    month.Id = 12;
                    if (monthProccess.Add(month))
                    {
                        gelir12();
                    }
                }
            }
        }
        public void gelir1()
        {
            Gelir gelir = new Gelir();

            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 1;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                   
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 2;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
 
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 3;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 4;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();
                        }
                    }
                }

            }
            
        }
        public void gelir2()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 5;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 6;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 7;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 8;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir3()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 9;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 10;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 11;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 12;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir4()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 13;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 14;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 15;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 16;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir5()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 17;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 18;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 19;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 20;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir6()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 21;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 22;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 23;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 24;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir7()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 25;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 26;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 27;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 28;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir8()

        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 29;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 30;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 31;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 32;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir9()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 33;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 34;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 35;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 36;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir10()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 37;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 38;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 39;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 40;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir11()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 41;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 42;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 43;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 44;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelir12()
        {
            Gelir gelir = new Gelir();
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week1")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek1 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 45;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week2")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek2 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 46;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week3")
                {
                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek3 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 47;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Week4")
                {


                    if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                    {

                        gelir.gelirKalemi = textBox2.Text;
                        gelir.gelirTutar = Convert.ToInt32(textBox3.Text);
                        gelirToplamWeek4 += Convert.ToInt32(textBox3.Text);
                        if (gelirProccess.Add(gelir))
                        {
                            gelir.Id = 48;
                            MessageBox.Show("Gelir Eklendi");
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox2.Focus();
                            gelirList();

                        }
                    }
                }
            }
        }
        public void gelirList()
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
