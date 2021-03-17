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
        int maxrecord;
        string record;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "うんち";
            button2.Text = "流す";
            textBox1.Text = kaisuu.ToString();
            kaisuu = 0;
            maxrecord = 0;
            record = "最高記録は0回";
            label3.Text = record;
         }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "流した")
            {
                MessageBox.Show("水の無駄遣いは控えましょう");
                if (kaisuu >= maxrecord)
                {
                    maxrecord = kaisuu;
                }
                kaisuu = 0;
                record = "最高記録は" + maxrecord.ToString() + "回";
                label3.Text = record;
                if (checkBox1.Checked == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Succsess!");
                label2.Text = "流した";
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
            label2.Text = (a[intResult]).ToString();
            if (!(label2.Text == "流した"))
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
