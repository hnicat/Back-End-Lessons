using Lesson13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson13
{
    public partial class Form1 : Form
    {
        List<Groupum> Gr = new List<Groupum>();
        List<Students> St = new List<Students>();

        public Form1()
        {
            InitializeComponent();
            Groupum group1 = new Groupum("N121");
            Groupum group2 = new Groupum("N211");
            Groupum group3 = new Groupum("N787");

            Gr.Add(group1);
            Gr.Add(group2);
            Gr.Add(group3);

            foreach (var item in Gr)
            {
                CmbGroup.Items.Add(item.GName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrpUpdate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string surname = TxtSurname.Text;
            string groupname = CmbGroup.Text;

            if (name == " " || surname == " " || groupname == " ")
            {
                MessageBox.Show("Zehmet Olmasa Forumu Doldurn ");
                return;
            }

            Students students = new Students();
            students.Name = name;
            students.Surname = surname;

            foreach (var item in Gr)
            {
                if (item.GName == groupname)
                {
                    students.Group = item;
                }
            }
            St.Add(students);
            MessageBox.Show($"{name} studented Aded");

            var query = from data in St
                        select new
                        {
                            data.Id,
                            data.Name,
                            data.Surname,
                            data.Group.GName
                        };


            TxtName.Clear();
            TxtSurname.Clear();
            dtgViewStudent.DataSource = "";
            dtgViewStudent.DataSource = query.ToList();

        }
        int indexRow;
        private void dtgViewStudent_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GrpUpdate.Visible = true;
            indexRow = e.RowIndex;
            DataGridViewRow row = dtgViewStudent.Rows[indexRow];
            lblId.Text= row.Cells[0].Value.ToString();
            TxtName2.Text = row.Cells[1].Value.ToString();
            TxtName2.Text = row.Cells[1].Value.ToString();
            TxtSurname2.Text = row.Cells[2].Value.ToString();
            CmbGroup2.Text = row.Cells[3].Value.ToString();
            
            
        }



        private void BtnUpdate_Click(object sender, EventArgs e)
                
        {
          
            DataGridViewRow newDataRow = dtgViewStudent.Rows[indexRow];

            string name = TxtName2.Text;
            int id = Convert.ToInt32(lblId.Text);
            string surname = TxtSurname2.Text;
            //dataGridViewRow.Cells[3].Value = CmbGroup2.Text;
            foreach (var item in St)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.Surname = surname; 
                }
            }
            MessageBox.Show($"{name} studented updated");

            var query = from data in St
                        select new
                        {
                            data.Id,
                            data.Name,
                            data.Surname,
                            data.Group.GName
                        };


            TxtName.Clear();
            TxtSurname.Clear();
            dtgViewStudent.DataSource = "";
            dtgViewStudent.DataSource = query.ToList();
        }
    }
}
