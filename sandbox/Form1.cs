using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sandbox
{
    public partial class Form1 : Form
    {
        int kaisuu;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "うんち";
            button2.Text = "流す";
            textBox1.Text = kaisuu.ToString();
            kaisuu = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "流した")
            {
                MessageBox.Show("水の無駄遣いは控えましょう");
                kaisuu = 0;
                if (checkBox1.Checked == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Succsess!");
                button1.Text = "流した";
                kaisuu++;
            }
            textBox1.Text = kaisuu.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new System.Random();    // インスタンスを生成
            int intResult = rnd.Next(3);        // 0～9の乱数を取得
            string[] a = new string[3] { "うんち", "おしっこ", "流した" };
            button1.Text = (a[intResult]).ToString();
            if (!(button1.Text == "流した"))
            {
                timer1.Stop();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
