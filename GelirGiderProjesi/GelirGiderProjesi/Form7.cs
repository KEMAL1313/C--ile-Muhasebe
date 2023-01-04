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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int usersayi = 0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            usersayi++;

            if (!String.IsNullOrWhiteSpace(txtSifre.Text) && !String.IsNullOrWhiteSpace(txtkAdi.Text) && !String.IsNullOrWhiteSpace(txtSoyad.Text) && !String.IsNullOrWhiteSpace(txtAd.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                User userx = new User()
                {
                    Id = usersayi,
                    UserName = txtkAdi.Text,
                    Password = txtSifre.Text,
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    Email = txtEmail.Text,
                };

                DbContext.userList.Add(userx);
                MessageBox.Show("Kayıt Başarılı");
            }



            txtAd.Clear();
            txtSifre.Clear();
            txtkAdi.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
        }
        private void txtkAdi_Enter(object sender, EventArgs e)
        {
            txtkAdi.Clear();
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            txtSifre.Clear();
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            txtAd.Clear();
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            txtSoyad.Clear();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
 }

