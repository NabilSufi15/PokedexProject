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
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (var db = new PokedexContext())
            {
                var query =
                    from pName in db.Pokemon
                    select pName;

                if (!string.IsNullOrEmpty(SearchBar.Text))
                {
                    query = query.Where(e => e.Pname.StartsWith(SearchBar.Text));
                    SearchList.ItemsSource = query.ToList();
                }
                else
                {
                    SearchList.ItemsSource = null;
                }

                


            }
            //DataView DV = new DataView(datatable);
            //_pokemon.RowFilter = string.Format("Name LIKE '%{0}%'", SearchBar.Text);
            //dataGridView1.DataSource = DV;

            /*
            if (SearchBar.Text == pokemonName.Pname)
            {

            }
            */
            /*
            var Query = PokedexContext.Dataset; //Whatever is the standard base query

            if (!string.IsNullOrEmpty(NameFilter))
                Query = Query.Where(e => e.Name.Contains(NameFilter));

            if (!string.IsNullOrEmpty(SurnameFilter))
                Query = Query.Where(e => e.Surname.Contains(SurnameFilter));
                */

        }
    }
}
