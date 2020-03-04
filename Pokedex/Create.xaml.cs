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
using System.Windows.Shapes;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        MainWindow w = new MainWindow();
        public Pokemon _selectedPokemon;
        public Create()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new PokedexContext())
            {
                Pokemon newPokemon = new Pokemon()
                {
                    Pimage = TextImage.Text,
                    Pname = TextName.Text,
                    Ptype = TextType.Text,
                    Pdescription = TextDescription.Text,
                    Pheight = TextHeight.Text,
                    Pweight = TextWeight.Text
                };

                //add to database
                db.Add(newPokemon);
                // write changes to database
                db.SaveChanges();
            }
                

            /*
            using (var db = new PokedexContext())
            {
                _selectedPokemon.Pimage = TextImage.Text;
                _selectedPokemon.Pname = TextName.Text;
                _selectedPokemon.Pdescription = TextDescription.Text;
                _selectedPokemon.Pheight = TextHeight.Text;
                _selectedPokemon.Pweight = TextWeight.Text;

                //add to database
                db.Add(_selectedPokemon);
                // write changes to database
                db.SaveChanges();

                /*
                w.ListBoxPokemon.ItemsSource = null;
                w.PopulateListBox();
                // put back the screen data
                w.ListBoxPokemon.SelectedItem = _selectedPokemon;
                w.PopulatePokemonFields();
                
            }*/
        }
    }
}
