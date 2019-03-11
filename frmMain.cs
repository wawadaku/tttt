using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 委托Demo
{
    public partial class frmMain : Form烦烦烦烦烦
    {
        //创建委托对象(使用系统带的Action委托)
        public Action<string> act;
        public frmMain()//主函数
        {
            InitializeComponent();
            //创建从窗体对象
            Other1 otj1 = new Other1();
            Other2 otj2 = new Other2();
            //委托连接方法
            act += otj1.Reciver;
            act += otj2.Reciver;
            //显示窗体
            otj1.Show();
            otj2.Show();
        }
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            //conter++;
            //act(conter.ToString());//调用委托传递信息
            act(textBox1.Text.Trim());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //conter = 0;
            act("0");//调用委托传递信息
        }
    }
}
