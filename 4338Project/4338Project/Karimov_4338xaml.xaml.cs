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

namespace _4338Project
{
    /// <summary>
    /// Логика взаимодействия для Karimov_4338xaml.xaml
    /// </summary>
    public partial class Karimov_4338xaml : Window
    {
        public Karimov_4338xaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Каримов Булат 18");
        }
    }
}
