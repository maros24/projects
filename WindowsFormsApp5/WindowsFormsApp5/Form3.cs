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

        string name, name1, name2, name3, name4, name5, name6;
      


        public Form3(string name, string name1, string name2, string name3, string name4, string name5, string name6)
        {
            this.name = name;
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.name4 = name4;
            this.name5 = name5;
            this.name6 = name6;
            InitializeComponent();
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
            MessageBox.Show(name6);
            MessageBox.Show(temp);


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
    }

    }


