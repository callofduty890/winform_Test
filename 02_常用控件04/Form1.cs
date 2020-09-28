using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_常用控件04
{
    public partial class Form1 : Form
    {
        //全局变量-随机数对象
        Random r;

        public Form1()
        {
            InitializeComponent();
        }
        //定时器相应事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = r.Next(0, 9).ToString();
            this.label2.Text = r.Next(0, 9).ToString();
            this.label3.Text = r.Next(0, 9).ToString();

        }
        //窗体加载时间
        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();//创建随机数对象，下种子
        }
        //开始
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        //停止
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();//获取当前事件
        }
    }
}
