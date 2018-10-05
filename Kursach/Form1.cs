using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Text =  DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timer1.Start();
        }

        bool tak;

        SoundPlayer mus = new SoundPlayer("mus.wav");

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mus.PlayLooping();
            tak = true;
        }

        private void off_Click(object sender, EventArgs e)
        {
            if (tak)
            {
                mus.Stop();
                tak = false;
                off.Image = System.Drawing.Image.FromFile(@"D:\Projects\Kursach\Kursach\media\on.jpg");
            }
            else
            {
                mus.PlayLooping();
                tak = true;
                off.Image = System.Drawing.Image.FromFile(@"D:\Projects\Kursach\Kursach\media\off.jpg");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
