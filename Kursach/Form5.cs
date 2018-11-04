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
    public partial class Form5 : Form
    {
        public Form5()
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

                string query = "SELECT [dbo].[Archive].[Item], [dbo].[Archive].[DateFound], [dbo].[Archive].[DateBrought], [dbo].[Archive].[DateTaken], [dbo].[PersonsGive].[Familiya], [dbo].[PersonsGive].[Imya], [dbo].[PersonsGive].[Otchestvo], [dbo].[PersonsGive].[Phone],  [dbo].[PersonsTake].[Familiya], [dbo].[PersonsTake].[Imya], [dbo].[PersonsTake].[Otchestvo], [dbo].[PersonsTake].[Phone] FROM [dbo].[Archive], [dbo].[PersonsGive], [dbo].[PersonsTake] WHERE ([dbo].[Archive].[PersonIDGive] = [dbo].[PersonsGive].[PersonID] AND [dbo].[Archive].[PersonIDTake] = [dbo].[PersonsTake].[PersonID])";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = Convert.ToDateTime(reader[1]).ToString("dd.MM.yyyy");
                    data[data.Count - 1][2] = Convert.ToDateTime(reader[2]).ToString("dd.MM.yyyy");
                    data[data.Count - 1][3] = Convert.ToDateTime(reader[3]).ToString("dd.MM.yyyy");
                    data[data.Count - 1][4] = reader[4].ToString() + reader[5].ToString() + reader[6].ToString() + reader[7].ToString();
                    data[data.Count - 1][5] = reader[8].ToString() + reader[9].ToString() + reader[10].ToString() + reader[11].ToString();
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string search = textBox1.Text;
                string query = "SELECT [dbo].[Archive].[Item], [dbo].[Archive].[DateFound], [dbo].[Archive].[DateBrought], [dbo].[Archive].[DateTaken], [dbo].[PersonsGive].[Familiya], [dbo].[PersonsGive].[Imya], [dbo].[PersonsGive].[Otchestvo], [dbo].[PersonsGive].[Phone],  [dbo].[PersonsTake].[Familiya], [dbo].[PersonsTake].[Imya], [dbo].[PersonsTake].[Otchestvo], [dbo].[PersonsTake].[Phone] FROM [dbo].[Archive], [dbo].[PersonsGive], [dbo].[PersonsTake] WHERE ([dbo].[Archive].[Item] LIKE N'" + search + "%' AND [dbo].[Archive].[PersonIDGive] = [dbo].[PersonsGive].[PersonID] AND [dbo].[Archive].[PersonIDTake] = [dbo].[PersonsTake].[PersonID])";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString() + reader[5].ToString() + reader[6].ToString() + reader[7].ToString();
                    data[data.Count - 1][5] = reader[8].ToString() + reader[9].ToString() + reader[10].ToString() + reader[11].ToString();
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
    }
}
