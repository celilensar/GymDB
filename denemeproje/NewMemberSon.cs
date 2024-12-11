using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace denemeproje
{
    public partial class NewMemberSon : Form
    {
        public NewMemberSon()
        {
            InitializeComponent();
        }

        // Save butonunun click event'ı
        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string gender = genderComboBox.SelectedItem.ToString();
            //int age = int.Parse(ageTextBox.Text);
            string phoneNumber = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string role = roleComboBox.SelectedItem.ToString();
            string membershipType = membershipTypeComboBox.SelectedItem.ToString();

            DateTime startDate = DateTime.Now;
            DateTime endDate;

            if (membershipType == "Year")
            {
                endDate = startDate.AddYears(1);
            }
            else
            {
                endDate = startDate.AddMonths(1);
            }

            string connectionString = "Your_Connection_String_Here";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    string insertMemberQuery = "INSERT INTO Member (FirstName, LastName, Gender, Age, PhoneNumber, Email, Address, Role) " +
                                               "OUTPUT INSERTED.MemberID " +
                                               "VALUES (@FirstName, @LastName, @Gender, @Age, @PhoneNumber, @Email, @Address, @Role)";

                    using (SqlCommand cmd = new SqlCommand(insertMemberQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Role", role);

                        int memberID = (int)cmd.ExecuteScalar();

                        string insertMembershipQuery = "INSERT INTO Membership (MemberID, MembershipType, StartDate, EndDate) " +
                                                       "VALUES (@MemberID, @MembershipType, @StartDate, @EndDate)";

                        using (SqlCommand cmdMembership = new SqlCommand(insertMembershipQuery, conn, transaction))
                        {
                            cmdMembership.Parameters.AddWithValue("@MemberID", memberID);
                            cmdMembership.Parameters.AddWithValue("@MembershipType", membershipType);
                            cmdMembership.Parameters.AddWithValue("@StartDate", startDate);
                            cmdMembership.Parameters.AddWithValue("@EndDate", endDate);

                            cmdMembership.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }

                    MessageBox.Show("Member and membership added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
