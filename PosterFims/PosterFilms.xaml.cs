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
    /// Логика взаимодействия для PosterFilms.xaml
    /// </summary>
    public partial class PosterFilms : Window
    {
        public PosterFilms()
        {
            InitializeComponent();
            Main.Navigate(new PagePoster());
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.Show();
        }
    }
}
