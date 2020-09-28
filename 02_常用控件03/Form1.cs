using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_常用控件03
{
    public partial class Form1 : Form
    {
        //储存图片路径
        string[] imageURLs;
        //中间变量,存储读取到第几张
        int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //窗体加载事件：在主窗体显示之前的操作
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取文件路径集合
            imageURLs = Directory.GetFiles(@"C:\Users\AIERXUAN\Pictures\标定板图像");
            this.pictureBox1.ImageLocation = imageURLs[0];//指定显示图像文件
        }
        //下一张
        private void button2_Click(object sender, EventArgs e)
        {
            if (Count< imageURLs.Length) //判断是否到了最大值
            {
                this.pictureBox1.ImageLocation = imageURLs[Count++];//循环读取下一张
            }
            else
            {
                Count = 0;
                this.pictureBox1.ImageLocation = imageURLs[Count];//回到起始点
            }
        }
        //上一张
        private void button1_Click(object sender, EventArgs e)
        {
            if (Count == 0) //判断是否到了最小值
            {
               
                this.pictureBox1.ImageLocation = imageURLs[0];//回到起始点
                Count = imageURLs.Length-1;//设置成最大值
            }
            else
            {
                 this.pictureBox1.ImageLocation = imageURLs[Count--];//回到上一张
            }
        }
    }
}
