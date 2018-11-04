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
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Программирование\Projects\Kursach\Kursach\BN.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {

            if (textItem.Text != "" && comboBox1.Text != "")
            {
                if (textF.Text != "" && textIm.Text != "" && textPhone.Text != "")
                    {
                        string item = textItem.Text;
                        string district = comboBox1.Text;
                        DateTime datee = dateTimePicker1.Value;
                        string description = textBox.Text;
                        DateTime datee2 = DateTime.Today;
                        string street = textStreet.Text;
                        string familiya = textF.Text;
                        string imya = textIm.Text;
                        string otchestvo = textOt.Text;
                        string phone = textPhone.Text;
                        string date = datee.ToString("yyyy-MM-dd");
                    string date2 = datee2.ToString("yyyy-MM-dd hh:mm");
                    Add(item, district, date, description, date2, street, familiya, imya, otchestvo, phone);
                        this.Close();
                    }
                else MessageBox.Show("Пожалуйста, введите полную контактную информацию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Пожалуйста, введите название предмета и район!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static void Add(string item, string district, string date, string description, string date2, string street, string familiya, string imya, string otchestvo, string phone)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string tak = " ";
                string person = " ";

                SqlCommand comPerson = new SqlCommand("SELECT PersonID from [dbo].[PersonsGive] where Familiya LIKE N'%" + familiya + "%' AND Imya LIKE N'%" + imya + "%' AND Phone LIKE '%" + phone + "%'", con);
                object PersonId = comPerson.ExecuteScalar();
                if (PersonId != null) person = Convert.ToString(PersonId);
                else
                {
                    phone = "+7" + phone;
                    using (SqlCommand command2 = new SqlCommand(
                        "INSERT INTO [dbo].[PersonsGive] ([Familiya], [Imya], [Otchestvo], [Phone]) VALUES (@familiya, @imya, @otchestvo, @phone)", con))
                    {
                        command2.Parameters.Add(new SqlParameter("Familiya", familiya));
                        command2.Parameters.Add(new SqlParameter("Imya", imya));
                        command2.Parameters.Add(new SqlParameter("Otchestvo", otchestvo));
                        command2.Parameters.Add(new SqlParameter("Phone", phone));
                        command2.ExecuteNonQuery();
                    }


                    string query = "SELECT ident_current('PersonsGive')";
                    SqlCommand command4 = new SqlCommand(query, con);
                    SqlDataReader reader1 = command4.ExecuteReader();
                    while (reader1.Read())
                    {
                        person = reader1[0].ToString();
                    }
                    reader1.Close();
                }

                int PersonID = int.Parse(person);

                SqlCommand com = new SqlCommand("SELECT DistrictID from [dbo].[Districts] where District = N'" + district + "' AND Street = N'" + street + "'", con);
                object StreetId = com.ExecuteScalar();
                if (StreetId != null) tak = Convert.ToString(StreetId);
                else
                {
                    using (SqlCommand command2 = new SqlCommand(
                        "INSERT INTO [dbo].[Districts] ([District], [Street]) VALUES (@district, @street)", con))
                    {
                        command2.Parameters.Add(new SqlParameter("District", district));
                        command2.Parameters.Add(new SqlParameter("Street", street));

                        command2.ExecuteNonQuery();
                    }


                    string query = "SELECT ident_current('Districts')";
                    SqlCommand command4 = new SqlCommand(query, con);
                    SqlDataReader reader1 = command4.ExecuteReader();
                    while (reader1.Read())
                    {
                        tak = reader1[0].ToString();
                    }
                    reader1.Close();
                }

                int DistrictID = int.Parse(tak);
                using (SqlCommand command = new SqlCommand(
                         "INSERT INTO [dbo].[Items] ([Item], [DateFound], [DateBrought], [Description], [DistrictID], [PersonID]) VALUES (@item, @datefound, @datebrought, @description, @districtid, @personid)", con))
                {
                    command.Parameters.Add(new SqlParameter("Item", item));
                    command.Parameters.Add(new SqlParameter("DateFound", date));
                    command.Parameters.Add(new SqlParameter("DateBrought", date2));
                    command.Parameters.Add(new SqlParameter("Description", description));
                    command.Parameters.Add(new SqlParameter("DistrictID", DistrictID));
                    command.Parameters.Add(new SqlParameter("PersonID", PersonID));

                    command.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

       private void Autocomplete()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct Street FROM Districts WHERE District LIKE N'%" + comboBox1.Text + "%'", con);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Districts");
                AutoCompleteStringCollection col = new
                AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Street"].ToString());

                }

                textStreet.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textStreet.AutoCompleteCustomSource = col;
                textStreet.AutoCompleteMode = AutoCompleteMode.Suggest;
                con.Close();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           Autocomplete();
        }
    }
}
