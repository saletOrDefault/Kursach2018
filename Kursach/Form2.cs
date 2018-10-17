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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Программирование\Projects\Kursach\Kursach\BN.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textItem.Text != "")
            {
                string item = textItem.Text;
                string district = textDistr.Text;
                DateTime date = dateTimePicker1.Value;
                string description = textBox.Text;
                DateTime date2 = DateTime.Today;
                string street = textStreet.Text;
                Add(item, district, date, description, date2, street);
                this.Close();
            }
            else MessageBox.Show("Пожалуйста, введите название предмета!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static void Add(string item, string district, DateTime date, string description, DateTime date2, string street)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();


                using (SqlCommand command2 = new SqlCommand(
                    "INSERT INTO [dbo].[Districts] VALUES (@district, @street)", con))
                {
                    command2.Parameters.Add(new SqlParameter("District", district));
                    command2.Parameters.Add(new SqlParameter("Street", street));

                    command2.ExecuteNonQuery();
                }

                using(SqlCommand command = new SqlCommand(
                    "INSERT INTO [dbo].[Items] ([Item], [DateFound], [DateBrought], [Description], [District]) VALUES (@item, @datefound, @datebrought, @description, @district)", con))
                {
                    command.Parameters.Add(new SqlParameter("Item", item));
                    command.Parameters.Add(new SqlParameter("DateFound", date));
                    command.Parameters.Add(new SqlParameter("DateBrought", date2));
                    command.Parameters.Add(new SqlParameter("Description", description));
                    command.Parameters.Add(new SqlParameter("District", district));

                    command.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}
