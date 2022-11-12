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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BibliotecaScolastica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Libro book;
        Biblioteca biblioteca = new Biblioteca();

        private void bntAddLibro_Click(object sender, RoutedEventArgs e)
        {
            book = new LIbro(txtAutore.Text, txtTitolo.Text, int.Parse(txtAnno.Text), txtEditore.Text, int.Parse(txtPagine.Text));
            
            biblioteca.AggiungiLibro(book);
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(book.toString());
        }

        private void btnStimatempo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Il tempo stimato di lettura è " + book.readingTime());
        }

        private void btnCerca_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.RicercaLibro(txtTitolo.Text);
        }

        private void btnStampaAutore_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.CercaPerAutore(txtAutore.Text);
        }

        private void btnTotaleLibri_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.TotaleLibri();
        }
    }
}
