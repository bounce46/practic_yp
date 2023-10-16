using ProSoft.Connection;
using ProSoft.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSoft.Modules
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }
        private string Names;
        private string Description;
        private string Price;
        private int idsx;
        public string NameN
        {
            get { return Names; }
            set { Names = value; labelName.Text = value; }
        }
        public string PriceP
        {
            get { return Price; }
            set { Price = value; labelPrice.Text = value; }
        }
        public string DescriptionD
        {
            get { return Description; }
            set { Description = value; labelOpis.Text = value; }
        }
        public int Idsx
        {
            get { return idsx; }
            set { idsx = value; }
        }
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            ProSoftEntities proSoftEntities = new ProSoftEntities();
            var id_u = Convert.ToInt32(DataClass.IdUser);

            proSoftEntities.orderTable.Add(new orderTable()
            {
                id_user = id_u,
                id_product = idsx,
            });
            proSoftEntities.SaveChanges();
        }
    }
}