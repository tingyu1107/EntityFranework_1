using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFranework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //查看全部
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }
        
        //新增
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();
        }

        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            var form = new ModifyForm();
            form.ShowDialog();
        }

        //刪除
        private void button4_Click(object sender, EventArgs e)
        {
            var form = new DelForm();
            form.ShowDialog();
        }


        //查特定
        private void button5_Click(object sender, EventArgs e)
        {
            var form = new QueryForm();
            form.ShowDialog();
        }





        
    }
}
