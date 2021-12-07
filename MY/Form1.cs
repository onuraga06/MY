using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mayin1, mayin2, mayin3;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin1 = rnd.Next(41, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button btn = new Button();//yeni nuton uretıldı
                btn.Name = "btn" + i.ToString();//butonların sayıları basıldı
                btn.Text = i.ToString();
                if(mayin1==i || mayin2==i || mayin3 == i)
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }

                btn.Click += btn_click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        int skor = 0;
        int puan = 100;
        void btn_click(object sender,EventArgs e)
        {
            Button basilan = sender as Button;
            bool mayinVarmı = (bool)basilan.Tag;
            
            if (mayinVarmı == true)
            {
                MessageBox.Show("Mayını Buldunuz Tebrikler");
                basilan.BackColor = Color.Red;
            }
            else
            {
                puan-=2;
                skor++;
                basilan.BackColor = Color.Green;
                label4.Text = puan.ToString();
                
                label3.Text = skor.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
