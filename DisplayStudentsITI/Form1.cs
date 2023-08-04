using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DisplayStudentsITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillStudentsList();
        }

        private void FillStudentsList()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select St_Id ,concat(St_Fname,' ',St_Lname)as FullName,St_Age, St_Address from student";

            command.Connection = con;
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridStudents.DataSource = dt;
            }
            catch
            {
            }
            finally { con.Close(); }
        }
    }
}