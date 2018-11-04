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

                string query = "SELECT [dbo].[Items].[Item], [dbo].[Items].[DateFound], [dbo].[Districts].[District], [dbo].[Districts].[Street], [dbo].[Items].[Description], [dbo].[PersonsGive].[Familiya], [dbo].[PersonsGive].[Imya], [dbo].[PersonsGive].[Otchestvo], [dbo].[PersonsGive].[Phone], [dbo].[Items].[ItemID], [dbo].[PersonsGive].[PersonID] FROM [dbo].[Items], [dbo].[Districts], [dbo].[PersonsGive] WHERE ([dbo].[Items].[DistrictID] = [dbo].[Districts].[DistrictID]) AND ([dbo].[Items].[PersonID] = [dbo].[PersonsGive].[PersonID])";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[11]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = Convert.ToDateTime(reader[1]).ToString("dd.MM.yyyy");
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
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
                string query = "SELECT [dbo].[Items].[Item], [dbo].[Items].[DateFound], [dbo].[Districts].[District], [dbo].[Districts].[Street], [dbo].[Items].[Description], [dbo].[PersonsGive].[Familiya], [dbo].[PersonsGive].[Imya], [dbo].[PersonsGive].[Otchestvo], [dbo].[PersonsGive].[Phone], [dbo].[Items].[ItemID], [dbo].[PersonsGive].[PersonID] FROM [dbo].[Items], [dbo].[Districts], [dbo].[Persons] WHERE [dbo].[Items].[Item] LIKE N'" + search + "%' AND [dbo].[Items].[DistrictID]=[dbo].[Districts].[DistrictID] AND [dbo].[Items].[PersonID] = [dbo].[PersonsGive].[PersonID]";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[11]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = Convert.ToDateTime(reader[1]).ToString("dd.MM.yyyy");
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                }
                reader.Close();
                con.Close();
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
            bool hm = Form6.check;
            if (hm == true)
            {
                Dulete();
            }
        }

        private void Dulete ()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row1 in dataGridView1.SelectedRows)
                {
                    int itemid = int.Parse(row1.Cells[9].Value.ToString());
                    string Date = "";
                    string query = "SELECT DateBrought FROM [dbo].[Items] WHERE (ItemID = '" + itemid + "')";
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Date = reader[0].ToString();
                    }
                    reader.Close();

                    int personID = int.Parse(Form6.person);
                    string query1 = "INSERT INTO [dbo].[Archive] (Item, DateFound, DateBrought, DateTaken, PersonIDTake, ItemID, PersonIDGive) VALUES (N'" + row1.Cells[0].Value.ToString() + "','" + Convert.ToDateTime(row1.Cells[1].Value).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(Date).ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + personID + "', '" + row1.Cells[9].Value.ToString() + "', '" + row1.Cells[10].Value.ToString() + "')";
                    string query2 = "DELETE from [dbo].[Items] WHERE ItemID=" + itemid;

                    SqlCommand command1 = new SqlCommand(query1, con);
                    SqlCommand command2 = new SqlCommand(query2, con);
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    dataGridView1.Rows.Remove(row1);

                    con.Close();
                }
            }
        }
    }
}
