﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_常用控件06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\Users\AIERXUAN\Documents";

            //*.rtf文件 
            openFile.Filter = "rtf files (*.rtf)|*.rtf";//过滤rtf尾缀的文件
            openFile.RestoreDirectory = true;//还原为之前的选定目录
            if (openFile.ShowDialog()==DialogResult.OK)//点击确定按钮
            {
                this.richTextBox1.LoadFile(openFile.FileName);//加载文件
            }
        }
        //保存文件
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\Users\AIERXUAN\Documents";

            saveFile.Filter = "rtf files (*.rtf)|*.rtf";//过滤rtf尾缀的文件
            saveFile.RestoreDirectory = true;//还原为之前的选定目录
            if (saveFile.ShowDialog()==DialogResult.OK)//判断是否保存
            {
                richTextBox1.SaveFile(saveFile.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;//高亮显示文本内容
            fontDialog.Font = richTextBox1.SelectionFont;//设置样式
            fontDialog.Color = richTextBox1.SelectionColor;//设置颜色
            if (fontDialog.ShowDialog() != DialogResult.Cancel) //判断是否更新
            {
                richTextBox1.SelectionFont = fontDialog.Font;//设置字体
                richTextBox1.SelectionColor = fontDialog.Color;//设置颜色
            }

        }
    }
}
