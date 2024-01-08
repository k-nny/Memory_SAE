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

namespace Memory_SAE
{
    public partial class MainWindow : Window
    {
        private List<Card> cartes;
        private Card carteSelectionnee;

        public MainWindow()
        {
            InitializeComponent();

        }
        public Card(int valeur)
        {
            InitializeComponent();
            this.valeur = valeur;
        }
        private void InitialiserJeu()
        {
            cartes = new List<Card>();

            for (int i = 0; i < 8; i++)
            {
                Card carte1 = new Card(i);
                Card carte2 = new Card(i);

                carte1.Click += Carte_Click;
                carte2.Click += Carte_Click;

                cartes.Add(carte1);
                cartes.Add(carte2);
            }


        }
