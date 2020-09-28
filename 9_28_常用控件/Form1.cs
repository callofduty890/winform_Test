using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_28_常用控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string information = "";
            //获取Textbox(姓名)
            information += this.textBox1.Text+ "\t您好" + "\n";
            //获取CheckBox(性别)
            if (this.radioButton1.Checked==true)//男被选中
            {
                information += "您的性别是:"+this.radioButton1.Text + "\n";
            }
            else
            {
                information += "您的性别是:" + this.radioButton2.Text + "\n";
            }
            //爱好
            information += "您的爱好是: ";
            if (this.checkBox1.Checked==true)
            {
                information += this.checkBox1.Text ;
            }
            if (this.checkBox2.Checked == true)
            {
                information +=  "\t" + this.checkBox2.Text ;
            }
            if (this.checkBox3.Checked == true)
            {
                information += "\t" + this.checkBox3.Text ;
            }
            if (this.checkBox4.Checked == true)
            {
                information += "\t" + this.checkBox4.Text ;
            }
            //在label标签上显示
            this.label5.Text = information;
        }
    }
}
