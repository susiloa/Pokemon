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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BattlePage : Page
    {
        public BattlePage()
        {
            this.InitializeComponent();
        }

        private void Move1_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ***Run the damage formula on the enemy***
        }

        private void Move2_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ***Run the damage formula on the enemy***
        }

        private void Move3_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            ***Run the damage formula on the enemy***
        }

        private void HomeBtn_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        PlayerPokemonImg.Source = new BitmapImage(new Uri(uriString: $"ms-appx:///Assets/{*** PLAYER POKEMON NAME FROM JSON FILE***}.png", UriKind.RelativeOrAbsolute));
        EnemyPokemonImg.Source = new BitmapImage(new Uri(uriString: $"ms-appx:///Assets/{***ENEMY POKEMON NAME FROM JSON FILE***}.png", UriKind.RelativeOrAbsolute));
        PlayerPokemonHealth.Text = ***PLAYERS POKEMON HEALTH FROM JSON FILE***;
        EnemyPokemonHealth.Text = ***ENEMY POKEMON HEALTH FROM JSON FILE***;
        Move1.Text = ***THE FIRST MOVE FROM THE JSON FILE***;
        Move2.Text = ***THE SECOND MOVE FROM THE JSON FILE***;
        Move3.Text = ***THE THIRD MOVE FROM THE JSON FILE***;



    }
}
