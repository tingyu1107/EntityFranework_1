﻿using EntityFranework.Models;
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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }
    }
}
