using ProSoft.Connection;
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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            ProSoftEntities proSoftEntities = new ProSoftEntities();
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" &&
                comboBoxSex.Text != "" && textBoxNumberPhone.Text != "" &&
                textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                proSoftEntities.userTable.Add(new userTable()
                {
                    first_name = textBoxFirstName.Text,
                    last_name = textBoxLastName.Text,
                    father_name = textBoxFatherName.Text,
                    id_sex = comboBoxSex.SelectedIndex + 1,
                    number_phone = textBoxNumberPhone.Text,
                    login = textBoxLogin.Text,
                    password = textBoxPassword.Text,
                    id_status = 1,
                });
                proSoftEntities.SaveChanges();
                MessageBox.Show("Успешная регистрация", "Успех", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Пустые обязательные поля", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}