using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optBtn_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim() == "") // Start button if nickname is typed or not.
            {
                MessageBox.Show("Please enter a NickName");
            }
           else if(textBox2.Text.Length<5)
                {

                MessageBox.Show("Nickname should be 5 characters");

            }

            else if (textBox2.Text.Length>10)
            {
                MessageBox.Show("Nickname should have between 5-10 characters", "Try Again");
            }
       
            else {
                KeepValues.nickName = textBox2.Text;
            Form2 frn = new Form2();
                frn.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("players.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                displayBtn.Items.Add(sr.ReadLine());
            }
           sr.Close();
           fs.Close();
        }
    }
}
