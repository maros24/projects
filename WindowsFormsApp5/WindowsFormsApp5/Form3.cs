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
    public partial class Form3 : Form
    {

        string name1, name2, name3, name4, name5, name6, name7;
        Label label8 = new Label();
        string[] names;
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public Form3(string name1, string name2, string name3, string name4, string name5, string name6, string name7)
        {
           
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.name4 = name4;
            this.name5 = name5;
            this.name6 = name6;
            this.name7 = name7;
            InitializeComponent();
      
        }
    public void Massive()
        {
            int count = 0;
            if (name1 != "")
            {
                label1.Text = name1 + ":";
                count++;
            }
            if (name2 != "")
            {
                label2.Text = name2 + ":";
                count++;
            }
            if (name3 != "")
            {
                label3.Text = name3 + ":";
                count++;
            }
            if (name4 != "")
            {
                label4.Text = name4 + ":";
                count++;
            }
            if (name5 != "")
            {
                label5.Text = name5 + ":";
                count++;
            }
            if (name6 != "")
            {
                label6.Text = name6 + ":";
                count++;
            }
            if (name7 != "")
            {
                label7.Text = name7 + ":";
                count++;
            }
            string[] names = new string[count];
            if (name1 != "")
            {
                names[0] = name1;

            }
            if (name2 != "")
            {
                names[1] = name2;
            }
            if (name3 != "")
            {
                names[2] = name3;
            }
            if (name4 != "")
            {
                names[3] = name4;
            }
            if (name5 != "")
            {
                names[4] = name5;
            }
            if (name6 != "")
            {
                names[5] = name6;
            }
            if (name7 != "")
            {
                names[6] = name7;
            }
        }
        
         
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] mas = { "Как часто Вы думаете о смерти?",
                      "что больше всего раздажает тебя в соседнем игроке",
                      "Счтиаете ли Вы себя мудрым человеком?",
                      "Самая худшая ситуация на работе",
                      "Если бы была машина времени, куда бы отправились?",
                      "За какой свой недостаток тебе стыдно7",
                      "Когда последний раз ты читал чужую переписку?",
                      "Самая безумная вещь, которую Вы когда-либо делали"
                       };

            Random rand = new Random();
            string temp = mas[rand.Next(0, 8)];
            
            MessageBox.Show(temp);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string[] mas = { "Действие следующего игрока выполняешь с ним",
                      "Выбери игрока и выполняй все его желания следующие 10 минут",
                      "Спеть, зажав нос",
                      "Изобрази назойливую муху",
                      "Повтори предыдущее задание",
                      "Изобрази собаку, которая метит территорию",
                      "Придумай прозвище всем игрокам",
                      "уговорить соседнего игрока купить рулон туалетной бумаги за 150 грн."
                       };

            Random rand = new Random();
            string temp = mas[rand.Next(0, 8)];
            MessageBox.Show(temp);
        }
    }

    }


