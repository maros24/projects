using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(firstAction);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {


        }
        private void firstAction(object sender, EventArgs e)
        {
            Point currentLocation = textBox2.Location;
            TextBox text = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation.X, currentLocation.Y += 35)
            };
            text.BackColor = Color.DodgerBlue;
            text.Font = new Font(text.Font, text.Font.Style | FontStyle.Bold);
            this.Controls.Add(text);
            this.button1.Click -= new EventHandler(firstAction);
            this.button1.Click += new EventHandler(secondAction);
        }

        private void secondAction(object sender, EventArgs e)
        {
            Point currentLocation1 = textBox2.Location;
            TextBox text1 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation1.X, currentLocation1.Y += 70)
            };
            text1.BackColor = Color.DodgerBlue;
            text1.Font = new Font(text1.Font, text1.Font.Style | FontStyle.Bold);
            this.Controls.Add(text1);
            this.button1.Click -= new EventHandler(secondAction);
            this.button1.Click += new EventHandler(firstAction);
            this.button1.Click += new EventHandler(thirdAction);
        }
        private void thirdAction(object sender, EventArgs e)
        {
            Point currentLocation2 = textBox2.Location;
            TextBox text2 = new TextBox
            {
                Height = 29,
                Width = 100,
                Location = new Point(currentLocation2.X, currentLocation2.Y += 105)
            };
            text2.BackColor = Color.DodgerBlue;
            text2.Font = new Font(text2.Font, text2.Font.Style | FontStyle.Bold);
            this.Controls.Add(text2);
            this.button1.Click -= new EventHandler(secondAction);
            this.button1.Click += new EventHandler(firstAction);
            this.button1.Click += new EventHandler(thirdAction);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
