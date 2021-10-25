using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;



namespace DataLibrary
{
    public class EmpDataStore
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;



        public EmpDataStore(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
            }
            catch (Exception)
            {
                throw;
            }

        }
        //get all emps data



        public List<Emp> GetEmps()
        {
            try
            {
                string sql = "Select EmpNo, Ename, Hiredate, Sal from emp";
                command = new SqlCommand(sql, connection);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }



                reader = command.ExecuteReader();



                List<Emp> empList = new List<Emp>();



                while (reader.Read())
                {
                    Emp emp = new Emp();
                    emp.EmpNo = (int)reader["EmpNo"];
                    emp.EmpName = reader["ename"].ToString();
                    emp.HireDate = reader["Hiredate"] as DateTime?; //nullable type conversion
                    emp.Salary = reader["sal"] as decimal?;



                    empList.Add(emp);
                }
                return empList;
            }
            catch (Exception)
            {



                throw;
            }
            finally
            {

                reader.Close();
            }
        }
        public int AddEmp(Emp emp)
        {
            try
            {
                string sql = "insert into emp(empno,ename,hiredate,sal) values(@eno,@name,@hdate,@salary)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("eno", emp.EmpNo);
                command.Parameters.AddWithValue("name", emp.EmpName);
                command.Parameters.AddWithValue("hdate", emp.HireDate);
                command.Parameters.AddWithValue("salary", emp.Salary);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                int count = command.ExecuteNonQuery();
                return count;



            }
            catch (Exception)
            {



                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //update method
        public int EditApp(Emp emp)
        {
            try
            {
                string sql = "update emp set ename=@name,hiredate=@hdate,sal=@salary where empno=@eno";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("eno", emp.EmpNo);
                command.Parameters.AddWithValue("name", emp.EmpName);
                command.Parameters.AddWithValue("hdate", emp.HireDate);
                command.Parameters.AddWithValue("salary", emp.Salary);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                int count = command.ExecuteNonQuery();
                return count;



            }
            catch (Exception)
            {



                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        //Remove
        public int RemoveEmp(int empid)
        {
            try
            {
                string sql = "delete from emp where empno=@eno";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("eno", empid);
               



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                int count = command.ExecuteNonQuery();
                return count;



            }
            catch (Exception)
            {



                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        
        }
    }
