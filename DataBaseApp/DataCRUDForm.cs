using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace DataBaseApp
{
    public partial class DataCRUDForm : Form
    {
        EmpDataStore dataStore = new EmpDataStore(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");
        public DataCRUDForm()
        {
            InitializeComponent();
        }

        private void DataCRUDForm_Load(object sender, EventArgs e)
        {
            dgData.DataSource = dataStore.GetEmps();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Clear();
            txtEmpno.Clear();
            txtHiredate.Clear();
            txtEmpname.Clear();
        }

        private void btnAddemp_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpno.Text);
                newEmp.EmpName = txtEmpname.Text;
                newEmp.Salary = decimal.Parse(txtSalary.Text);
                newEmp.HireDate = Convert.ToDateTime(txtHiredate.Text);



                int count = dataStore.AddEmp(newEmp);



                if (count == 1)
                {
                    MessageBox.Show("Record Inserted");
                    dgData.DataSource = dataStore.GetEmps();
                }
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {




                int count = dataStore.RemoveEmp(int.Parse(txtEmpno.Text));



                if (count == 1)
                {
                    MessageBox.Show("Record Removed");
                    dgData.DataSource = dataStore.GetEmps();
                }
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);
            }

        }
        //trial
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpno.Text);
                newEmp.EmpName = txtEmpname.Text;
                newEmp.Salary = decimal.Parse(txtSalary.Text);
                newEmp.HireDate = Convert.ToDateTime(txtHiredate.Text);



                int count = dataStore.EditApp(newEmp);



                if (count == 1)
                {
                    MessageBox.Show("Record Updated");
                    dgData.DataSource = dataStore.GetEmps();
                }
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);
            }


        }

    
        }
    }


