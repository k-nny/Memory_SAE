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
using static System.Net.Mime.MediaTypeNames;

namespace Memory_SAE
{
    public partial class MainWindow : Window
    {
        //private List<Card> cartes;
        //private Card carteSelectionnee;

        public MainWindow()
        {
            // Definition des variables
            bool resultat;
            MessageBoxResult resultatMessageBox = MessageBoxResult.No;


            InitializeComponent();

            //Creation du menu des difficultés
            MenuDifficulte ChoixDifficulte = new MenuDifficulte();

            while (resultatMessageBox != MessageBoxResult.Yes)
            {
                resultat = (bool)ChoixDifficulte.ShowDialog();
                if (resultat == false)
                {
                    resultatMessageBox = MessageBox.Show("Vous êtes sur le point de quitter le meilleur jeu de Memoire de 2024. Voulez vous vraiment le quitter ?", "Verification Annulation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (resultatMessageBox == MessageBoxResult.Yes)
                    {
                        this.Close();
                    }
                }

                else
                {
                    TestBoutonJouer Jouer = new TestBoutonJouer();
                    while (Jouer.DialogResult != false)
                    {
                        string difficulteChoisie;
                        difficulteChoisie = ChoixDifficulte.ComboBoxDifficulté.Text;
                        List<string> images = new List<string>
                        {
                            "img/img1.jpg",
                            "img/img1 (1).jpg",
                            "img/img1 (2).jpg",
                            "img/img1 (3).jpg",
                            "img/img1 (4).jpg",
                            "img/img1 (5).jpg",
                            "img/img1 (6).jpg",
                            "img/img1 (7).jpg",
                            "img/img1 (8).jpg",
                            "img/img1 (9).jpg",
                            "img/img1 (10).jpg",
                            "img/img1 (11).jpg",
                            "img/img1 (12).jpg",
                            "img/img1 (13).jpg",
                            "img/img1 (14).jpg",
                            "img/img1 (15).jpg",
                            "img/img1 (16).jpg",
                            "img/img1 (17).jpg",
                            "img/img1.jpg",
                            "img/img1 (1).jpg",
                            "img/img1 (2).jpg",
                            "img/img1 (3).jpg",
                            "img/img1 (4).jpg",
                            "img/img1 (5).jpg",
                            "img/img1 (6).jpg",
                            "img/img1 (7).jpg",
                            "img/img1 (8).jpg",
                            "img/img1 (9).jpg",
                            "img/img1 (10).jpg",
                            "img/img1 (11).jpg",
                            "img/img1 (12).jpg",
                            "img/img1 (13).jpg",
                            "img/img1 (14).jpg",
                            "img/img1 (15).jpg",
                            "img/img1 (16).jpg",
                            "img/img1 (17).jpg",
                        };
                        MelangeImages(images);
                        ImageBrush initialisation = new ImageBrush();
                        initialisation.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[0]));
                        Jouer.But1.Background = initialisation;

                        ImageBrush initialisation1 = new ImageBrush();
                        initialisation1.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[1]));
                        Jouer.But2.Background = initialisation1;

                        ImageBrush initialisation2 = new ImageBrush();
                        initialisation2.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[2]));
                        Jouer.But3.Background = initialisation2;

                        ImageBrush initialisation3 = new ImageBrush();
                        initialisation3.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[3]));
                        Jouer.But4.Background = initialisation3;

                        ImageBrush initialisation4 = new ImageBrush();
                        initialisation4.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[4]));
                        Jouer.But5.Background = initialisation4;

                        ImageBrush initialisation5 = new ImageBrush();
                        initialisation5.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[5]));
                        Jouer.But6.Background = initialisation5;

                        ImageBrush initialisation6 = new ImageBrush();
                        initialisation6.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[6]));
                        Jouer.But7.Background = initialisation6;

                        ImageBrush initialisation7 = new ImageBrush();
                        initialisation7.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[7]));
                        Jouer.But8.Background = initialisation7;

                        ImageBrush initialisation8 = new ImageBrush();
                        initialisation8.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[8]));
                        Jouer.But9.Background = initialisation8;

                        ImageBrush initialisation9 = new ImageBrush();
                        initialisation9.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[9]));
                        Jouer.But10.Background = initialisation9;

                        ImageBrush initialisation10 = new ImageBrush();
                        initialisation10.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[10]));
                        Jouer.But11.Background = initialisation10;

                        ImageBrush initialisation11 = new ImageBrush();
                        initialisation11.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[11]));
                        Jouer.But12.Background = initialisation11;

                        ImageBrush initialisation12 = new ImageBrush();
                        initialisation12.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[12]));
                        Jouer.But13.Background = initialisation12;

                        ImageBrush initialisation13 = new ImageBrush();
                        initialisation13.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[13]));
                        Jouer.But14.Background = initialisation13;

                        ImageBrush initialisation14 = new ImageBrush();
                        initialisation14.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[14]));
                        Jouer.But15.Background = initialisation14;

                        ImageBrush initialisation15 = new ImageBrush();
                        initialisation15.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[15]));
                        Jouer.But16.Background = initialisation15;

                        ImageBrush initialisation16 = new ImageBrush();
                        initialisation16.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[16]));
                        Jouer.But17.Background = initialisation16;

                        ImageBrush initialisation17 = new ImageBrush();
                        initialisation17.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[17]));
                        Jouer.But18.Background = initialisation17;

                        ImageBrush initialisation18 = new ImageBrush();
                        initialisation18.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[18]));
                        Jouer.But19.Background = initialisation18;

                        ImageBrush initialisation19 = new ImageBrush();
                        initialisation19.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[19]));
                        Jouer.But20.Background = initialisation19;

                        ImageBrush initialisation20 = new ImageBrush();
                        initialisation20.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[20]));
                        Jouer.But21.Background = initialisation20;

                        ImageBrush initialisation21 = new ImageBrush();
                        initialisation21.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[21]));
                        Jouer.But22.Background = initialisation21;

                        ImageBrush initialisation22 = new ImageBrush();
                        initialisation22.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[22]));
                        Jouer.But23.Background = initialisation22;

                        ImageBrush initialisation23 = new ImageBrush();
                        initialisation23.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[23]));
                        Jouer.But24.Background = initialisation23;

                        ImageBrush initialisation24 = new ImageBrush();
                        initialisation24.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[24]));
                        Jouer.But25.Background = initialisation24;

                        ImageBrush initialisation25 = new ImageBrush();
                        initialisation25.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[25]));
                        Jouer.But26.Background = initialisation25;

                        ImageBrush initialisation26 = new ImageBrush();
                        initialisation26.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[26]));
                        Jouer.But27.Background = initialisation26;

                        ImageBrush initialisation27 = new ImageBrush();
                        initialisation27.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[27]));
                        Jouer.But28.Background = initialisation27;

                        ImageBrush initialisation28 = new ImageBrush();
                        initialisation28.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[28]));
                        Jouer.But29.Background = initialisation28;

                        ImageBrush initialisation29 = new ImageBrush();
                        initialisation29.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[29]));
                        Jouer.But30.Background = initialisation29;

                        ImageBrush initialisation30 = new ImageBrush();
                        initialisation30.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[30]));
                        Jouer.But31.Background = initialisation30;

                        ImageBrush initialisation31 = new ImageBrush();
                        initialisation31.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[31]));
                        Jouer.But32.Background = initialisation31;

                        ImageBrush initialisation32 = new ImageBrush();
                        initialisation32.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[32]));
                        Jouer.But33.Background = initialisation32;

                        ImageBrush initialisation33 = new ImageBrush();
                        initialisation33.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[33]));
                        Jouer.But34.Background = initialisation33;

                        ImageBrush initialisation34 = new ImageBrush();
                        initialisation34.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[34]));
                        Jouer.But35.Background = initialisation34;

                        ImageBrush initialisation35 = new ImageBrush();
                        initialisation35.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + images[35]));
                        Jouer.But36.Background = initialisation35;
                        Jouer.ShowDialog();

                    };
                    resultatMessageBox = MessageBoxResult.Yes;
                    this.Close();
                }
            };




        }
        private void MelangeImages(List<string> images)
        {
            Random random = new Random();
            int n = images.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = images[k];
                images[k] = images[n];
                images[n] = value;
            }
        }
    }
}
