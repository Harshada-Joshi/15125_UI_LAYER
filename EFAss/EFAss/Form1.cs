using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFAss.Models;
using Microsoft.Data.SqlClient;

namespace EFAss
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            TrainingContext tb = new TrainingContext();
            String UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            Userdatum user = tb.Userdata.SingleOrDefault(u => u.Username == UserName && u.Password == Password);
            if (user != null)
            {
                label3.Text = "Valid";
            }
            else
            {
                label3.Text = "Invalid";
            }
        }
    }
}
