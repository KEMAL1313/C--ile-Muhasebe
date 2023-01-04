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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GelirGiderProjesi
{
    public partial class Form4 : Form
    {     
        public Form4()
        {
            InitializeComponent();
        }
        MonthProccess monthProccess = new MonthProccess();
        GiderProccess giderProccess = new GiderProccess();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        public double gidertoplamWeek1 = 0;
        public double gidertoplamWeek2 = 0;
        public double gidertoplamWeek3 = 0;
        public double gidertoplamWeek4 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            mounth();
        }
        public void mounth()
        {       
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (comboBox1.SelectedItem.ToString() == "Ocak")
                {
                    Month month = new Month();
                    month.Id = 1;
                    if (monthProccess.Add(month))
                    {
                        gider1();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Subat")
                {
                    month.Id = 2;
                    if (monthProccess.Add(month))
                    {
                        gider2();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Mart")
                {
                    month.Id = 3;
                    if (monthProccess.Add(month))
                    {
                        gider3();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Nisan")
                {
                    month.Id = 4;
                    if (monthProccess.Add(month))
                    {
                        gider4();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Mayis")
                {
                    month.Id = 5;
                    if (monthProccess.Add(month))
                    {                    
                        gider5();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Haziran")
                {
                    month.Id = 6;
                    if (monthProccess.Add(month))
                    {    
                        gider6();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Temmuz")
                {
                    month.Id = 7;
                    if (monthProccess.Add(month))
                    { 
                        gider7();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Agustos")
                {
                    month.Id = 8;
                    if (monthProccess.Add(month))
                    {  
                        gider8();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Eylul")
                {
                    month.Id = 9;
                    if (monthProccess.Add(month))
                    {
                        gider9();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Ekim")
                {
                    month.Id = 10;
                    if (monthProccess.Add(month))
                    {
                        gider10();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Kasim")
                {
                    month.Id = 11;
                    if (monthProccess.Add(month))
                    {
                        gider11();
                    }
                }
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Month month = new Month();
                if (comboBox1.SelectedItem.ToString() == "Aralik")
                {
                    month.Id = 12;
                    if (monthProccess.Add(month))
                    {
                        gider12();
                    }
                }
            }
        }
        public void gider1()
        {
            Gider gider = new Gider();   
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 1;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 2;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 3;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 4;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider2()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 5;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 6;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 7;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 8;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider3()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 9;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 10;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 11;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 12;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider4()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 13;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 14;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 15;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 16;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider5()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 17;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 18;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 19;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 20;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider6()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 21;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 22;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 23;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 24;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider7()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 25;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 26;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 27;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 28;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider8()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 29;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 30;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 31;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 32;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider9()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 33;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 34;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 35;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 36;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider10()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 37;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 38;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 39;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 40;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider11()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 41;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 42;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 43;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 44;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void gider12()
        {
            Gider gider = new Gider();
            if (comboBox2.SelectedItem.ToString() == "Week1")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek1 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 45;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();
                    }
                }
            }
            if (comboBox2.SelectedItem.ToString() == "Week2")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek2 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 46;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week3")
            {

                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek3 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 47;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }

            if (comboBox2.SelectedItem.ToString() == "Week4")
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox3.Text))
                {

                    gider.giderKalemi = textBox2.Text;
                    gider.giderTutar = Convert.ToInt32(textBox3.Text);
                    gidertoplamWeek4 += Convert.ToInt32(textBox3.Text);

                    if (giderProccess.Add(gider))
                    {
                        gider.Id = 48;
                        MessageBox.Show("Gider Eklendi");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox2.Focus();
                        giderList();

                    }
                }
            }
        }
        public void giderList()
        {
           
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
