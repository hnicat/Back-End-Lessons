using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lesson14
{
    public partial class Form2 : Form
    {
        List<Janir> janirList = new List<Janir>();
        List<Kitab> kitablist = new List<Kitab>();
        public Form2()
        {
            InitializeComponent();
            Janir janir = new Janir("Dedektiv");
            Janir janir2 = new Janir("Roman");
            Janir janir3 = new Janir("Seir");
            Janir janir4 = new Janir("Biyografi");
            Janir janir5 = new Janir("Dini");

            janirList.Add(janir);
            janirList.Add(janir2);
            janirList.Add(janir3);
            janirList.Add(janir4);
            janirList.Add(janir5);

            foreach (var item in janirList)
            {
                CmbGenreType.Items.Add(item.JanirName);
            }


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string bookname = TxtBookName.Text;
            int ISBN = Convert.ToInt32(TxtBookIsbn.Text);
            int Price = Convert.ToInt32(TxtBookPrice.Text);
            string Genretype = CmbGenreType.Text.ToString();

            if (Genretype == " " || Price == null || ISBN == null || bookname == " ")
            {
                Console.WriteLine("Fill the forum if you don't mind");
            }

            Kitab kitab = new Kitab(ISBN, bookname, Price);
            foreach (var item in janirList)
            {
                if (item.JanirName == Genretype)
                {
                    kitab.janir = item;
                }
            }
            kitablist.Add(kitab);
            MessageBox.Show($"{bookname} Add. ");

            TxtBookIsbn.Clear();
            TxtBookName.Clear();
            TxtBookPrice.Clear();

            var query = from data in kitablist
                        select new
                        {
                            data.id,
                            data.BookName,
                            data.ISBN,
                            data.janir.JanirName,
                            data.Pirce
                        };

            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = query.ToList();
        }
        int indexrow;

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox1.Visible = true;
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            label10.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            textBox1.Text = row.Cells[4].Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           int id=Convert.ToInt32(label10.Text);
            string nameupdate = textBox2.Text;
            int isbmupdate = Convert.ToInt32(textBox3.Text);
            string genretypeupdate = comboBox1.Text;
            int priceupdate = Convert.ToInt32(textBox1.Text);

            foreach(var item in kitablist)
            {
                if (item.id == id)
                {
                    item.BookName = nameupdate;
                    item.ISBN= isbmupdate;
                    item.janir.JanirName = genretypeupdate;
                    item.Pirce= priceupdate;
                }
            }
            MessageBox.Show($"{nameupdate} studented updated");

            var query = from data in kitablist
                        select new
                        {
                            data.id,
                            data.BookName,
                            data.ISBN,
                            data.janir.JanirName,
                            data.Pirce
                        };

            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = query.ToList();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
