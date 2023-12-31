﻿using ProSoft.Connection;
using ProSoft.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSoft.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var idorder = DataClass.idorder;
            ProSoftEntities proSoftEntities = new ProSoftEntities();
            var product = proSoftEntities.productTable.ToList();
            for (int i = 0; i < product.Count; i++)
            {
                Order orderItem = new Order();
                orderItem.NameN = "Наименование: "+
                    product[i].product_name;
                orderItem.PriceP = "Цена: " + product[i].product_price + " рублей";
                orderItem.Idsx = product[i].id_product;
                orderPanel.Controls.Add(orderItem);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            this.Hide();
            cartForm.ShowDialog();
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
