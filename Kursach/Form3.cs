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

namespace Kursach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Pokaz();
        }


        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Программирование\Projects\Kursach\Kursach\BN.mdf;Integrated Security=True";


        private void Pokaz()
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT [dbo].[Items].[Item], [dbo].[Items].[DateFound], [dbo].[Districts].[District], [dbo].[Districts].[Street], [dbo].[Items].[Description] FROM [dbo].[Items], [dbo].[Districts] WHERE ([dbo].[Items].[DistrictID] = [dbo].[Districts].[DistrictID])";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string search = textBox1.Text;
                string query = "SELECT [dbo].[Items].[Item], [dbo].[Items].[DateFound], [dbo].[Districts].[District], [dbo].[Districts].[Street], [dbo].[Items].[Description] FROM [dbo].[Items], [dbo].[Districts] WHERE [dbo].[Items].[Item] LIKE N'" + search + "%' AND [dbo].[Items].[DistrictID]=[dbo].[Districts].[DistrictID]";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
    }
}
