using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon
{
    //Angela Susilo
    //SetUpPage.xaml.cs passes the chosen Pokémon with its image to BattlePage.xaml
    public sealed partial class SetUpPage : Page
    {
        private List<Pokemon> pokemons;
        public SetUpPage()
        {
            this.InitializeComponent();
            pokemons = Pokemon.GetPokemons();
        }

        private void LetsBattleBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(PokemonCombo.SelectedItem);
            this.Frame.Navigate(typeof(BattlePage), PokemonCombo.SelectedItem);
        }

        private void PokemonCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //pokemonImage.Source = ((Pokemon) PokemonCombo.SelectedItem).Image.Source;
            pokemonImage.Source = ((Pokemon) e.AddedItems[0]).Image.Source;
        }
    }
}
