using EntityFranework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFranework
{
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.Where(x => x.Id == int.Parse(textBox5.Text)).ToList();
            foreach (var item in list)
            {
                context.ContactsTable.Remove(item);
            }
            context.SaveChanges();
            MessageBox.Show("存檔完成");
        }
    }
}
