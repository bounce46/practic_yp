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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            ProSoftEntities proSoftEntities = new ProSoftEntities();
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                foreach (var item in proSoftEntities.adminTable)
                {
                    if (textBoxLogin.Text == item.login &&
                        textBoxPassword.Text == item.password)
                    {
                        MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK);
                        AdminForm adminForm = new AdminForm();
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Show();
                        return;
                    }
                }
                foreach (var item in proSoftEntities.userTable)
                {
                    if (textBoxLogin.Text == item.login &&
                        textBoxPassword.Text == item.password)
                    {
                        MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK);
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Show();
                        return;
                    }
                }
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Есть пустое поле", "Ошибка", MessageBoxButtons.OK);
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPass.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm regForm = new RegForm();
            this.Hide();
            regForm.ShowDialog();
            this.Show();
        }
    }
}