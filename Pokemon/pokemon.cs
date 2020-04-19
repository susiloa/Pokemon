using system;

public class pokemon
{
    public string name { get; }
    public string type { get; }
    public int health { get; }
    public int attack { get; }
    public int defense { get; }
    public int speed { get; }
    public boolean isdead { get; }
    public list<move> moves { get; }
    public string imgsrc { get; }

    public pokemon(string name, string type, int health, int attack, int defense, int speed, list<move> moves)
    {
        name = name;
        type = type;
        health = health;
        attack = attack;
        defense = defense;
        speed = speed;
        moves = moves;
        isdead = false;
        imgsrc = name + @".png";
    }
      //