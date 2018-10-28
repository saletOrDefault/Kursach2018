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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Statistic();
        }

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Программирование\Projects\Kursach\Kursach\BN.mdf;Integrated Security=True";

        private void Statistic()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                double all = 0, avi = 0, vah = 0, kir = 0, mos = 0, priv = 0, sov = 0, savin = 0;

                string query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts]";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    all++;
                }
                reader.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Авиастроительный%'";
                SqlCommand command1 = new SqlCommand(query, con);
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    avi++;
                }
                reader1.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Вахитовский%'";
                SqlCommand command2 = new SqlCommand(query, con);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    vah++;
                }
                reader2.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Кировский%'";
                SqlCommand command3 = new SqlCommand(query, con);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    kir++;
                }
                reader3.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Московский%'";
                SqlCommand command4 = new SqlCommand(query, con);
                SqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    mos++;
                }
                reader4.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Приволжский%'";
                SqlCommand command5 = new SqlCommand(query, con);
                SqlDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    priv++;
                }
                reader5.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Советский%'";
                SqlCommand command6 = new SqlCommand(query, con);
                SqlDataReader reader6 = command6.ExecuteReader();
                while (reader6.Read())
                {
                    sov++;
                }
                reader6.Close();

                query = "SELECT [dbo].[Districts].[District] FROM [dbo].[Districts] WHERE [dbo].[Districts].[District] LIKE N'Ново-Савиновский%'";
                SqlCommand command7 = new SqlCommand(query, con);
                SqlDataReader reader7 = command7.ExecuteReader();
                while (reader7.Read())
                {
                    savin++;
                }
                reader7.Close();
                con.Close();

                avi = (avi / all) * 100;
                if (avi != 0)
                avilab.Text = avi.ToString("#") + "%";

                vah = (vah / all) * 100;
                if (vah != 0)
                vahlab.Text = vah.ToString("#") + "%";

                kir = (kir / all) * 100;
                if (kir!=0)
                kirlab.Text = kir.ToString("#") + "%";

                mos = (mos / all) * 100;
                if (mos!=0)
                moslab.Text = mos.ToString("#") + "%";

                priv = (priv / all) * 100;
                if (priv!=0)
                prilab.Text = priv.ToString("#") + "%";

                sov = (sov / all) * 100;
                if (sov!=0)
                sovlab.Text = sov.ToString("#") + "%";

                savin = (savin / all) * 100;
                if (savin!=0)
                nsavlab.Text = savin.ToString("#") + "%";
            }
        }
    }
}
