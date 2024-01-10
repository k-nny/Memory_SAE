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

namespace Memory_SAE
{
    /// <summary>
    /// Logique d'interaction pour TestBoutonJouer.xaml
    /// </summary>
    public partial class TestBoutonJouer : Window
    {
        public TestBoutonJouer()
        {
            InitializeComponent();
        }
        

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush imgPc = new ImageBrush();
            imgPc.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "img/img1.jpg"));
            //ImageBrush imgCode = new ImageBrush();
            //imgCode.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "img/code.jpg"));
            //if (But1.Background == imgPc) 
            //    But1.Background = imgCode;
            //else
            But1.Background = imgPc;
        }
    }
}
