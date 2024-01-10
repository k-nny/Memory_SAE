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
            while (resultatMessageBox != MessageBoxResult.Yes)
            {
                MenuDifficulte ChoixDifficulte = new MenuDifficulte();
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
                    string difficulteChoisie;
                    difficulteChoisie = ChoixDifficulte.ComboBoxDifficulté.Text;
                    TestBoutonJouer Jouer = new TestBoutonJouer();
                    Jouer.ShowDialog();
                    if (Jouer.DialogResult == false)
                        resultatMessageBox=MessageBoxResult.Yes;
                        this.Close();
                }
            };
            List <string>images = new List<string>
            {
                "img1.jpg",
                "img1 (1).jpg",
                "img1 (2).jpg",
                "img1 (3).jpg",
                "img1 (4).jpg",
                "img1 (5).jpg",
                "img1 (6).jpg",
                "img1 (7).jpg",
                "img1 (8).jpg",
                "img1 (9).jpg",
                "img1 (10).jpg",
                "img1 (11).jpg",
                "img1 (12).jpg",
                "img1 (13).jpg",
                "img1 (14).jpg",
                "img1 (15).jpg",
                "img1 (16).jpg",
                "img1 (17).jpg",
            };
            MelangeImages(images);


        }
        private void MelangeImages(List <string> images)
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


        //public Card(int valeur)
        //{
        //    InitializeComponent();
        //    this.valeur = valeur;
        //}
        //private void InitialiserJeu()
        //{
        //    cartes = new List<Card>();

        //    for (int i = 0; i < 8; i++)
        //    {
        //        Card carte1 = new Card(i);
        //        Card carte2 = new Card(i);

        //        carte1.Click += Carte_Click;
        //        carte2.Click += Carte_Click;

        //        cartes.Add(carte1);
        //        cartes.Add(carte2);
        //    }


        //}
    }
}
