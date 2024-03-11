using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson22
{
    public partial class BrandsList : Form
    {
        public BrandsList()
        {
            InitializeComponent();
        }

        private void BrandsList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");
        }
    }
}
