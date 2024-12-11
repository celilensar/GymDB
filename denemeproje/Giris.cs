using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace denemeproje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-M4M4Q6P;Initial Catalog=GymDB;Integrated Security=True;Encrypt=False";


            // SQL sorgusu
            string query = "SELECT COUNT(1) FROM UserAuth WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar).Value = userName;
                        command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar).Value = password;

                        // Sorguyu çalıştır ve sonuç al
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Ana ekran formunu aç
                            AnaEkranAdmin anaEkranAdmin = new AnaEkranAdmin(); // Ana ekran formunuzu oluşturun
                            anaEkranAdmin.Show();
                            this.Hide(); // Giriş ekranını gizle
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
