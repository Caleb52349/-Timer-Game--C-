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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initialize();
        }
        int result;
        int a, b;
        int s;
        private void initialize()
        {
            //storing values from start menu.
            label7.Text = KeepValues.nickName;
            label8.Text = KeepValues.level.ToString();
            label9.Text = KeepValues.point.ToString();
            label11.Text = KeepValues.totalTime.ToString();
            label12.Text = KeepValues.questionNumber.ToString();
            a = RandomNumber.randomNumber1.Next(0, 10);
            b = RandomNumber.randomNumber2.Next(0, 10);
            textBox1.Text = a.ToString();
            textBox3.Text = b.ToString();
            
            s = RandomNumber.randomSign.Next(1, 3);
            switch (s)
            {
                case 1: textBox2.Text = "+";break;
                case 2: textBox2.Text = "-";break;
                case 3: textBox2.Text = "*";break;
                default:break;

            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(label6.Text);
            t--;
            if (t == 0)
            {
                timer1.Enabled = false;
                FileStream fs = new FileStream("players.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);


                sw.WriteLine(KeepValues.nickName + "                        " + KeepValues.point + "                        " +KeepValues.totalTime + "                        " +KeepValues.questionNumber) ;
                  

           
         
                sw.Close();
                fs.Close();


                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            { label6.Text = t.ToString(); }

         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);

            
            switch(s)
            {
                case 1:result = a + b;break;
                case 2:result = a - b;break;
                case 3:result = a * b;break;
            }

            if (textBox4.Text == result.ToString())
            {
                KeepValues.questionNumber++;
                KeepValues.point += 10;
                KeepValues.totalTime += Convert.ToInt32(label6.Text);
                label6.Text = "60";
                initialize();
               
            }

          
        }
    }
    }


