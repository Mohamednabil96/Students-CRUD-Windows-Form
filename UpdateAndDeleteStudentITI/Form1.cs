using Microsoft.Data.SqlClient;
using System.Data;

namespace UpdateAndDeleteStudentITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillStudentsToComboBox();
        }

        private void FillStudentsToComboBox()
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();

            command.CommandText = "select St_Id ,concat(St_Fname,' ',St_Lname)as FullName from student";

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
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        private void comboStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();

            command.CommandText = "select * from student where St_Id=@Id";

            var studentID = comboStudents.SelectedValue.ToString();
            command.Parameters.AddWithValue("@Id", studentID);

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);


                txtID.Text = dt.Rows[0]["St_Id"].ToString();
                txtFName.Text = dt.Rows[0]["St_Fname"].ToString();
                txtLName.Text = dt.Rows[0]["St_Lname"].ToString();
                txtAddress.Text = dt.Rows[0]["St_Address"].ToString();

                txtID.Enabled = false;

            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

            SqlCommand command = new SqlCommand();

            command.CommandText = "update student set St_Fname=@fn ,St_Lname=@ln, St_Address=@addres where St_Id=@Id ";


            command.Parameters.AddWithValue("@Id", txtID.Text);
            command.Parameters.AddWithValue("@fn", txtFName.Text);
            command.Parameters.AddWithValue("@ln", txtLName.Text);
            command.Parameters.AddWithValue("@addres", txtAddress.Text);

            command.Connection = con;


            try
            {
                con.Open();
                lblResult.Text = $"{command.ExecuteNonQuery()} rows Affected";

                FillStudentsToComboBox();
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are u Sure Deleting {comboStudents.Text}", "Warning !!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection("Server=localhost;Database=ITI;trusted_connection=true;TrustServerCertificate=True");

                SqlCommand command = new SqlCommand();

                command.CommandText = "delete from student where St_Id=@Id ";

                command.Parameters.AddWithValue("@Id", txtID.Text);

                command.Connection = con;
                try
                {
                    con.Open();
                    lblResult.Text = $"{command.ExecuteNonQuery()} Deleted ";

                    FillStudentsToComboBox();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { con.Close(); }
            }
        }


    }
}