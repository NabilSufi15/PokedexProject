using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for CreatePokemonUC.xaml
    /// </summary>
    public partial class CreatePokemonUC : UserControl
    {
        public CreatePokemonUC()
        {
            InitializeComponent();
        }

        //saves the data within the respective tables and columns
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            //Pokecreate textblock element becomes visible
            Pokecreate.Visibility = Visibility.Visible;

            using (var db = new PokedexContext())
            {
                Pokemon newPokemon = new Pokemon()
                {
                    Pimage = TextImage.Text,
                    Pname = TextName.Text,
                    Ptype = TextType.Text,
                    Pdescription = TextDescription.Text,
                    Pheight = TextHeight.Text,
                    Pweight = TextWeight.Text,
                    Pcry = TextCry.Text,
                    Psound = TextSound.Text
                };

                Stats newStats = new Stats()
                {
                    Hp = TextHP.Text,
                    Attack = TextAttack.Text,
                    Defense = TextType.Text,
                    SpAttack = TextSpAttack.Text,
                    SpDefense = TextSpDefense.Text,
                    Speed = TextSpeed.Text
                };

                //add to database
                db.Add(newPokemon);
                //add to database
                db.Add(newStats);
                // write changes to database
                db.SaveChanges();
            }
            
        }
    }
}
