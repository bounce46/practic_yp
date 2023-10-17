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
            var product = proSoftEntities.productTable.ToList();
            
            foreach(var item in proSoftEntities.orderTable)
            {
                if (item.id_user == memory)
                {
                    Order orderItem = new Order();
                    orderItem.NameN = "Наименование: " + 
                        product[item.id_product-1].product_name.ToString();
                    orderItem.PriceP = "Цена: " + 
                        product[item.id_product-1].product_price + " рублей".ToString();
                    orderItem.DescriptionD = "Описание: " + 
                        product[item.id_product-1].product_description.ToString();
                    orderItem.buttonAddCart.Visible = false;
                    OrderPanel.Controls.Add(orderItem);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}