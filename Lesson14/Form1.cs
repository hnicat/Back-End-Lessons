using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson14
{
    public partial class Form1 : Form
    {
        List <UserInformation> user=new List<UserInformation> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQeyid_Click(object sender, EventArgs e)
        {
            string name = TxtName2.Text;
            string password=TxtPassword2.Text;
            UserInformation userInformation = new UserInformation(name, password);
            user.Add(userInformation);
            TxtName2.Clear();
            TxtPassword2.Clear();
        }

        private void BtnDaxil_Click(object sender, EventArgs e)
        {
            string name1 = TxtName.Text;
            string password2=TxtPassword.Text;
             foreach(var item in user)
            {
                if (item.Name == name1 && item.Password == password2)
                {
                    Form2 form2=new Form2();
                    form2.Show();
                  
                }
                else
                {
                    MessageBox.Show("Zehmet Olmasa Istifadeci Adini Ve Ya Siferni  Duzgun Daxil Edin");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
