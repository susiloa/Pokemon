using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Mime;
using Newtonsoft.Json;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Pokemon
{
    public class Pokemon
    {
        private String _imgSrc;
        public String Name { get; }
        public string Type { get; }
        public double Health { get; set; }
        public int Attack { get; }
        public int Defense { get; }
        public int Speed { get; }
        public Boolean IsDead { get; set; }
        public List<Move> Moves { get; }

        public String ImgSrc
        {
            set
            {
                _imgSrc = value;
                Image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{_imgSrc}", UriKind.RelativeOrAbsolute));
            }
        }
        public Image Image { get; set; }

        public static List<Pokemon> GetPokemons()
        {
            String pokemonData = File.ReadAllText(@"./PokemonTable.txt");
            List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(pokemonData);
            return pokemonList;
        }

        public Pokemon(String name, String type, int health, int attack, int defense, int speed, List<Move> moves)
        {
            Name = name;
            Type = type;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Moves = moves;
            IsDead = false;
            ImgSrc = Name + @".png";
        }

        public double ExecuteAttack(Pokemon enemy, Move move)
        {
            double damage = (move.Power * Attack / enemy.Defense / 50) + 2 ;
            damage *= ResolveType.TypeMultiplier(move.Type, enemy.Type);

            enemy.ReceiveDamage(damage);

            return damage;
        }

        public void ReceiveDamage(double damage)
        {
            Health -= damage;
            IsDead = (Health <= 0) ? true : false;
        }

        public override string ToString()
        {
            return Name + " (" + Type + " Health: " + Health + ")";
        }

        public Move SelectRandomMove()
        {
            return Moves[new Random().Next(Moves.Count)];
        }

    }
}
