using Microsoft.Data.SqlClient;
using System.Data;
namespace LAB_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ViewStudents.Hide();
            label7.Hide();
            Back.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtFather.Text) ||
                cbDeprt.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cbMat.SelectedItem == null ||
                cbinter.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtRoll.Text) ||
                string.IsNullOrWhiteSpace(txtCNIC.Text))
            {
                MessageBox.Show("Please fill in all the required fields before submitting.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=My_text;Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                string gender;
                if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                else
                {
                    gender = "Male";
                }

                string query = "INSERT INTO Users (Name, FatherName, Degree, Address, MatricGrade, InterGrade, RegNo, CNIC, DOB, Gender) VALUES ('" + txtName.Text + "', '" + txtFather.Text + "','" + cbDeprt.SelectedItem.ToString() + "', '" + txtAddress.Text + "', '" + cbMat.SelectedItem.ToString() + "', '" + cbinter.SelectedItem.ToString() + "', '" + Convert.ToInt32(txtRoll.Text) + "', '" + txtCNIC.Text + "', '" + DTPdob.Value + "', '" + gender + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Registration number must be a valid number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "SQL Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtFather.Text) ||
                    cbDeprt.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    cbMat.SelectedItem == null ||
                    cbinter.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtRoll.Text) ||
                    string.IsNullOrWhiteSpace(txtCNIC.Text))
                {
                    MessageBox.Show("Please fill in all the required fields before submitting.",
                                    "Missing Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Stop execution if any field is empty
                }

                SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=My_text;Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                string gender;
                if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                else
                {
                    gender = "Male";
                }

                string query = "UPDATE Users SET Name = '" + txtName.Text + "', FatherName = '" + txtFather.Text + "', Degree = '" + cbDeprt.SelectedItem.ToString() + "', Address = '" + txtAddress.Text + "', MatricGrade = '" + cbMat.SelectedItem.ToString() + "', InterGrade = '" + cbinter.SelectedItem.ToString() + "', CNIC = '" + txtCNIC.Text + "', DOB = '" + DTPdob.Value.ToString("yyyy-MM-dd") + "', Gender = '" + gender + "' WHERE RegNo = " + Convert.ToInt32(txtRoll.Text);

                SqlCommand sqlCommand = new SqlCommand(query, con);
                int rowsAffected = sqlCommand.ExecuteNonQuery(); // execute update
                con.Close();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No record found with the specified Registration Number.",
                                    "Record Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Registration number must be a valid number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "SQL Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRoll.Text))
                {
                    MessageBox.Show("Please enter the Registration Number to delete.",
                                    "Missing Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Stop execution if RegNo is empty
                }

                SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=My_text;Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                string query = "DELETE FROM Users WHERE RegNo = " + Convert.ToInt32(txtRoll.Text);

                SqlCommand sqlCommand = new SqlCommand(query, con);
                int rowsAffected = sqlCommand.ExecuteNonQuery(); // execute delete
                con.Close();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No record found with the specified Registration Number.",
                                    "Record Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Record deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Registration number must be a valid number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "SQL Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Back.Show();
            lblName.Hide();
            lblReg.Hide();
            label7.Show();
            ViewStudents.Show();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=My_text;Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                string query = "SELECT * FROM Users";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); // fill the DataTable with records

                ViewStudents.DataSource = dt; // bind to DataGridView

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                                "SQL Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ViewStudents.Hide();
            label7.Hide();
            Back.Hide();
            lblName.Show();
            lblReg.Show();
        }
    }
}