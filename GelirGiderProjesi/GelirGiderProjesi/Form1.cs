using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = false;
            string name = "", surname = "";
            foreach (var user in DbContext.userList.ToList())
            {
                if (textBox1.Text == user.UserName && textBox2.Text == user.Password)
                {
                    durum = true;
                    name = user.Name;
                    surname = user.Surname;
                    break;
                }
            }
            if (durum)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                MessageBox.Show("Giriş Başarılı Hoşgeldin" + " " + name + " " + surname , "Giriş Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                frm2.Show();
                //frm2.label5.Text = "Hoşgeldin" + "\n" + name + " " + surname;
                this.Hide();
                durum = false;

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

       

       
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user2 = new User()
            {
                Id = 0,
                UserName = "1",
                Password = "1",
                Name = "Kemal",
                Surname = "İleri",
                Email = "kemalileri2@gmail.com"
            };

            DbContext.userList.Add(user2);
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
