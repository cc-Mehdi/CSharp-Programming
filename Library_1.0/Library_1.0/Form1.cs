using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_1._0
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}/Library_DB.mdb");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Library App " + DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbSearch.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            gbUsers.BringToFront();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            gbBooks.BringToFront();
        }
    }
}
