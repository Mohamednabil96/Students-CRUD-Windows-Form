using Microsoft.Data.SqlClient;
using System.Data;

namespace InsertStudentsITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();
            //command.CommandText = $"insert into student (St_Id, St_Fname, St_Lname, St_Address) values ('{txtID.Text}', '{txtFName.Text}', '{txtLName.Text}', '{txtAddress.Text}')";
            command.CommandText = $"insert into Student (St_Id, St_Fname, St_Lname, St_Address) values (@id, @fname, @lname, @address)";
            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@fname", txtFName.Text);
            command.Parameters.AddWithValue("@lname", txtLName.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);

            command.Connection = con;
            try
            {
                con.Open();
                lblResult.Text = $"{command.ExecuteNonQuery()} rows affected";

            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }


















            //////////////////
            //SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            //SqlCommand command = new SqlCommand();

            //command.CommandText = $"insert into student (St_Id, St_Fname, St_Lname, St_Address) values ('{txtID.Text}','{txtFName.Text}','{txtLName.Text}','{txtAddress.Text}')";

            //command.Connection = con;

            //try
            //{
            //    con.Open();
            //    lblResult.Text = $"{command.ExecuteNonQuery()} rows Affected";


            //}
            //catch (Exception)
            //{
            //    throw;

            //}

            //finally
            //{
            //    con.Close();
            //}
        }
    }
}

//using Microsoft.Data.SqlClient;
//using System.Data;

//namespace SelectStudentsITI
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            FillStudentsList();
//        }

//        private void FillStudentsList()
//        {
//            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

//            SqlCommand command = new SqlCommand();
//            command.CommandType = System.Data.CommandType.Text;
//            command.CommandText = "select St_Id ,concat(St_Fname,' ',St_Lname)as FullName,St_Age, St_Address from student";

//            command.Connection = con;
//            try
//            {
//                con.Open();
//                SqlDataReader dr = command.ExecuteReader();
//                DataTable dt = new DataTable();
//                dt.Load(dr);
//                comboStudents.DataSource = dt;
//                comboStudents.DisplayMember = "FullName";
//                comboStudents.ValueMember = "St_Id";
//            }
//            catch
//            {
//            }
//            finally { con.Close(); }
//        }

//        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            SqlConnection con = new SqlConnection("Data Source=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

//            SqlCommand command = new SqlCommand();
//            command.CommandText = "select * from student where St_Id=@Id";

//            var x = comboStudents.SelectedValue.ToString();
//            command.Parameters.AddWithValue("@Id", x);

//            command.Connection = con;

//            try
//            {
//                con.Open();
//                SqlDataReader dr = command.ExecuteReader();
//                DataTable dt = new DataTable();
//                dt.Load(dr);

//                gridStudents.DataSource = dt;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            finally { con.Close(); }
//        }
//    }
//}