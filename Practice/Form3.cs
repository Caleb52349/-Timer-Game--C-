using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label12.Text = KeepValues.nickName;
            label11.Text = KeepValues.level.ToString();
            label9.Text = KeepValues.point.ToString();
            label8.Text = KeepValues.totalTime.ToString();
            label7.Text = KeepValues.questionNumber.ToString();

        }
    }
}
