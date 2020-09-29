using _08_多窗体创建与使用.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_多窗体创建与使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("账号密码不正确!");//
            MessageBox.Show("账号密码不正确!", "登录提示");
            MessageBox.Show("是否退出程序！", "登录提示", MessageBoxButtons.OKCancel);
            DialogResult dialogResult = MessageBox.Show("是否退出程序！", "登录提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);

            if (dialogResult == DialogResult.OK)
            {
                Console.WriteLine("确定");
            }
            else
            {
                Console.WriteLine("取消");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2(this);
            DialogResult result =fr2.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine(" 登录失败");
            }
        }
    }
}
