﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PosterFims
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<UserRole> UserRoles = AfishaEntities.GetContext().UserRole.ToList();
        private void BtnEnter_Click_1(object sender, RoutedEventArgs e)
        {
            if (LogTB.Text == null || PassTB.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                foreach (var user in UserRoles)
                {
                    if (user.UserPasswords == PassTB.Text.ToString() && user.UserLogin == LogTB.Text.ToString())
                    {
                        MessageBox.Show($"Добро пожаловать, {user.UserName}!");
                        PosterFilms store = new PosterFilms();
                        store.Show();
                        return;
                    }
                    else if (user.ID == UserRoles.Count)
                    {
                        MessageBox.Show($"Неверные данные!");
                        return;
                    }
                }
            }

        }
    }
}
