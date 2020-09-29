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
    public partial class Form2 : Form
    {
        //创建Form1的类对象
        Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 fr1):this()
        {
            this.form1 = fr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         this.DialogResult=   DialogResult.Cancel;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(this.form1);
            fr3.Show();
            //this.DialogResult = DialogResult.OK;
        }
    }
}
