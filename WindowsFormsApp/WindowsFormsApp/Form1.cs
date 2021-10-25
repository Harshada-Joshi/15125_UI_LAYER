using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class lblMsg : Form
    {
        public lblMsg()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin")
            {
                lblMsg1.Text = "Valid user";
            }
            else
            {
                lblMsg1.Text = "Invalid username and password";
            }
        }
    }
}
