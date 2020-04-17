using System;

public class Pokemon
{
	public Pokemon()
	{
		Dictionary<string, int> Charizard = new Dictionary<string, int>();
		Charizard.Add(Health, 78);
		Charizard.Add(Attack, 109);
		Charizard.Add(Defense, 78);
		Charizard.Add(Speed, 100);

		Dictionary<string, int> Blastoise = new Dictionary<string, int>();
		Blastoise.Add(Health, 79);
		Blastoise.Add(Attack, 83);
		Blastoise.Add(Defense, 100);
		Blastoise.Add(Speed, 78);

		Dictionary<string, int> Venusaur = new Dictionary<string, int>();
		Venusaur.Add(Health, 80);
		Venusaur.Add(Attack, 82);
		Venusaur.Add(Defense, 83);
		Venusaur.Add(Speed, 80);

		Dictionary<string, int> Pikachu = new Dictionary<string, int>();
		Pikachu.Add(Health, 35);
		Pikachu.Add(Attack, 55);
		Pikachu.Add(Defense, 40);
		Pikachu.Add(Speed, 90);

		Dictionary<string, int> MewTwo = new Dictionary<string, int>();
		MewTwo.Add(Health, 106);
		MewTwo.Add(Attack, 110);
		MewTwo.Add(Defense, 90);
		MewTwo.Add(Speed, 130);

		Dictionary<string, int> Beedrill = new Dictionary<string, int>();
		Beedrill.Add(Health, 65);
		Beedrill.Add(Attack, 90);
		Beedrill.Add(Defense, 40);
		Beedrill.Add(Speed, 75);

		Dictionary<string, int> Gengar = new Dictionary<string, int>();
		Gengar.Add(Health, 60);
		Gengar.Add(Attack, 65);
		Gengar.Add(Defense, 60);
		Gengar.Add(Speed, 110);

		Dictionary<string, int> Chansey = new Dictionary<string, int>();
		Chansey.Add(Health, 250);
		Chansey.Add(Attack, 5);
		Chansey.Add(Defense, 5);
		Chansey.Add(Speed, 50);

		Dictionary<string, int> Golem = new Dictionary<string, int>();
		Golem.Add(Health, 80);
		Golem.Add(Attack, 120);
		Golem.Add(Defense, 130);
		Golem.Add(Speed, 45);

		Dictionary<string, int> Articuno = new Dictionary<string, int>();
		Articuno.Add(Health, 90);
		Articuno.Add(Attack, 85);
		Articuno.Add(Defense, 100);
		Articuno.Add(Speed, 85);

		Dictionary<string, int> Dragonite = new Dictionary<string, int>();
		Dragonite.Add(Health, 91);
		Dragonite.Add(Attack, 134);
		Dragonite.Add(Defense, 95);
		Dragonite.Add(Speed, 80);

		Dictionary<string, int> Machamp = new Dictionary<string, int>();
		Machamp.Add(Health, 90);
		Machamp.Add(Attack, 130);
		Machamp.Add(Defense, 80);
		Machamp.Add(Speed, 55);

		Dictionary<string, int> Pidgeot = new Dictionary<string, int>();
		Machamp.Add(Health, 83);
		Machamp.Add(Attack, 80);
		Machamp.Add(Defense, 75);
		Machamp.Add(Speed, 101);

		Dictionary<string, int> Dugtrio = new Dictionary<string, int>();
		Machamp.Add(Health, 35);
		Machamp.Add(Attack, 100);
		Machamp.Add(Defense, 50);
		Machamp.Add(Speed, 120);

		Dictionary<string, int> Nidoking = new Dictionary<string, int>();
		Machamp.Add(Health, 81);
		Machamp.Add(Attack, 102);
		Machamp.Add(Defense, 77);
		Machamp.Add(Speed, 85);

		Dictionary<string, string> PokemonType = new Dictionary<string, string>();
		PokemonType.Add(Charizard, Fire);
		PokemonType.Add(Blastoise, Water);
		PokemonType.Add(Venusaur, Grass);
		PokemonType.Add(Pikachu, Electric);
		PokemonType.Add(Mewtwo, Psychic);
		PokemonType.Add(Beedrill, Bug);
		PokemonType.Add(Gengar, Ghost);
		PokemonType.Add(Chansey, Normal);
		PokemonType.Add(Golem, Rock);
		PokemonType.Add(Articuno, Ice);
		PokemonType.Add(Dragonite, Dragon);
		PokemonType.Add(Machamp, Fighting);
		PokemonType.Add(Pidgeot, Flying);
		PokemonType.Add(Dugtrio, Ground);
		PokemonType.Add(Poison, Nidoking);
	}
}
