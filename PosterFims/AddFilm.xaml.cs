using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PosterFims
{
    /// <summary>
    /// Логика взаимодействия для AddFilm.xaml
    /// </summary>
    public partial class AddFilm : Window
    {
        public AddFilm()
        {
            InitializeComponent();
        }
        public List<Afisha> products = AfishaEntities.GetContext().Afisha.ToList();
        public Afisha NewProduct = new Afisha();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (txtDiscr.Text == null || txtName.Text == null || txtManuf.Text == null || txtPrice.Text == null || txtSize.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            else
            {
                NewProduct.NameFilm = txtName.Text.ToString();
                NewProduct.Duration = int.Parse(txtDiscr.Text.ToString());
                NewProduct.Description = txtManuf.Text.ToString();
                NewProduct.Start = TimeSpan.Parse(txtPrice.Text.ToString());
                NewProduct.Culminate = TimeSpan.Parse(txtSize.Text.ToString());
                AfishaEntities.GetContext().Afisha.Add(NewProduct);
                AfishaEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы добавили новый фильм в расписание!");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
