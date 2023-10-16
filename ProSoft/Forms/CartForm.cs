using ProSoft.Connection;
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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ProSoftEntities proSoftEntities = new ProSoftEntities();
            var memory = Convert.ToInt32(DataClass.IdUser);
            var order = proSoftEntities.orderTable.ToList();
            foreach (var item in proSoftEntities.orderTable)
            {
                if (item.id_user == memory)
                {
                    for (int i = 0; i <= memory; i++)
                    {
                        Order orderItem = new Order();
                        orderItem.NameN = "Наименование: "+order[i].productTable.product_name.ToString();
                        orderItem.PriceP = "Цена: " + order[i].productTable.product_price+" рублей".ToString();
                        orderItem.DescriptionD = "Описание: " + order[i].productTable.product_description.ToString();
                        OrderPanel.Controls.Add(orderItem);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("корзина пуста!");
                    return;
                }
            }
        }
    }
}