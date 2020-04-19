using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BattlePage : Page
    {
        private Battle battle;
        private List<Pokemon> pokemons = Pokemon.GetPokemons();
        public BattlePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BattleLog.Text = "";
            Pokemon pokemon = e.Parameter as Pokemon;
            int ent = new Random().Next(1, 3);
            Encounter encounter;
            if (ent == 1)
            {
                int enemySelected = new Random().Next(pokemons.Count);
                encounter = new WildEncounter(pokemons[enemySelected], "100 EXP");
                Console.WriteLine("You have encountered a wild " + pokemons[enemySelected]);
            }
            else
            {
                List<Pokemon> enemyPokemon = new List<Pokemon>();
                while (enemyPokemon.Count < 2)
                {
                    int selected = new Random().Next(pokemons.Count);
                    enemyPokemon.Add(pokemons[selected]);
                    pokemons.RemoveAt(selected);
                }
                encounter = new TrainerEncounter(enemyPokemon, "600 EXP and $56");
                Console.WriteLine("You have encountered Trainer Alex");
            }

            

            battle = new Battle(pokemon, encounter);

            PlayerPokemonImg.Source = battle.userPokemon.Image.Source;
            EnemyPokemonImg.Source = battle.encounter.ActivePokemon.Image.Source;
            PlayerPokemonHealth.Text = battle.userPokemon.Health.ToString();
            EnemyPokemonHealth.Text = battle.encounter.ActivePokemon.Health.ToString();
            Move1.Content = battle.userPokemon.Moves[0];
            Move2.Content = battle.userPokemon.Moves[1];
            Move3.Content = battle.userPokemon.Moves[2];

            battle.BattleStart();
        }

        private void Move1_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            LogBattle();
            battle.AttackPhase(battle.userPokemon.Moves[0]);
            if (battle.GameEnd)
            {
                MessageDialog md = new MessageDialog(battle.encounter.GetReward());
                md.ShowAsync();
            }
        }

        private void Move2_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            LogBattle();
            battle.AttackPhase(battle.userPokemon.Moves[1]);
            if (battle.GameEnd)
            {
                MessageDialog md = new MessageDialog(battle.encounter.GetReward());
                md.ShowAsync();
            }
        }

        private void Move3_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            LogBattle();
            battle.AttackPhase(battle.userPokemon.Moves[2]);
            if (battle.GameEnd)
            {
                MessageDialog md = new MessageDialog(battle.encounter.GetReward());
                md.ShowAsync();
            }
        }

        private void HomeBtn_OnClickBtn_OnClick(object sender, RoutedEventArgs e)
        {
            LogBattle();
            this.Frame.Navigate(typeof(MainPage), null);
            if (battle.GameEnd)
            {
                MessageDialog md = new MessageDialog(battle.encounter.GetReward());
                md.ShowAsync();
            }
        }

        private void CaptureBtn_Click(object sender, RoutedEventArgs e)
        {
            LogBattle();
            if (battle.encounter.GetType() == typeof(WildEncounter))
            {
                WildEncounter enc = (WildEncounter)battle.encounter;
                if (enc.TryCapture())
                {
                    BattleLog.Text += "Successfully captured " + enc.ActivePokemon + "!\n";
                    battle.EndOfTurn();
                }
                else
                {
                    BattleLog.Text += "Failed to capture " + enc.ActivePokemon + "\n";
                    battle.EndOfTurn();
                }
            }
            if (battle.GameEnd)
            {
                MessageDialog md = new MessageDialog(battle.encounter.GetReward());
                md.ShowAsync();
            }
        }

        private void LogBattle()
        {
            while(battle.BattleMessage.Count > 0)
            {
                BattleLog.Text += battle.BattleMessage[0] + "\n";
                battle.BattleMessage.RemoveAt(0);
            }

            PlayerPokemonHealth.Text = battle.userPokemon.Health.ToString();
            EnemyPokemonHealth.Text = battle.encounter.ActivePokemon.Health.ToString();
        }


    }
}
