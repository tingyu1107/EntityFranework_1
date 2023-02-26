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

namespace EntityFranework
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
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
            ContactsTable data = new ContactsTable()
            {
                Id = int.Parse(textBox5.Text.Trim()),

                Name = textBox1.Text.Trim(),
                Quantity = Convert.ToInt32(textBox2.Text.Trim()),
                Price = Convert.ToInt32(textBox3.Text.Trim()),
                Class = textBox4.Text.Trim(),
            };
            try
            {

                context.ContactsTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");

            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
