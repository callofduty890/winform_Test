using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_常用控件02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string information = "您的计算机配置如下:";
            //CPU
            information += "\nCPU:"+this.comboBox1.Text;
            //内存
            information += "\n内存:";
            if (this.checkedListBox1.SelectedIndex > -1)//判断是否有选中
            {
                information += this.checkedListBox1.SelectedItem.ToString();
            }
            else
            {
                information += "您没有选中内存!";
            }
            //配件
            information += "\n配件:";
            if (this.checkedListBox2.SelectedIndex > -1)//判断是否有选中配件
            {
                information += this.checkedListBox2.SelectedItem.ToString();
            }
            else
            {
                information += "您没有选择配件!";
            }
            //硬盘
            information += "\n硬盘:";
            if (this.radioButton1.Checked == true)
            {
                information += "500GB";
            }
            else if (this.radioButton2.Checked == true)
            {
                information += "1TB";
            }
            //显示屏
            information += "\n显示器:";
            if (this.radioButton3.Checked == true)
            {
                information += "13英寸";
            }
            else if (this.radioButton4.Checked == true)
            {
                information += "14英寸";
            }
            else if (this.radioButton5.Checked == true)
            {
                information += "15英寸";
            }
            //显示选中的信息
            MessageBox.Show(information);
        }
    }
}
