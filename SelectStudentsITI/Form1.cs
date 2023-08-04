using Microsoft.Data.SqlClient;
using System.Data;

namespace SelectStudentsITI
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
                comboStudents.DataSource = dt;
                comboStudents.DisplayMember = "FullName";
                comboStudents.ValueMember = "St_Id";
            }
            catch
            {
            }
            finally { con.Close(); }
        }

        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from student where St_Id=@Id";

            var x = comboStudents.SelectedValue.ToString();
            command.Parameters.AddWithValue("@Id", x);

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                gridStudents.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }
    }
}