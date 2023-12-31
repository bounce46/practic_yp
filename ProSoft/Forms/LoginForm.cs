﻿using ProSoft.Connection;
using ProSoft.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
                foreach (var item in proSoftEntities.userTable)
                {
                    if (textBoxLogin.Text == item.login &&
                        textBoxPassword.Text == item.password)
                    {
                        DataClass.IdUser = item.id_user;
                        MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK);
                        MainForm mainForm = new MainForm();
                        mainForm.labelName.Text = item.last_name;
                        if (item.id_sex == 1)
                            mainForm.pictureBoxPhoto.Image = 
                                Properties.Resources.free_icon_young_man_8193910;
                        else
                            mainForm.pictureBoxPhoto.Image = 
                                Properties.Resources.free_icon_woman_8193922;
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