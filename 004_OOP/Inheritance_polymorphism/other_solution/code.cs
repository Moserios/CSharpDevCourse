using System;

// Define a base class called "Character"
public class Character
{
 public string name;
 public int health;
 public int attack;
 public int defense;

 // Constructor for the Character class
 public Character(string name, int health, int attack, int defense)
 {
  this.name = name;
  this.health = health;
  this.attack = attack;
  this.defense = defense;
 }

 // Method for the Character class
 public virtual void Attack(Character target)
 {
  int damage = attack - target.defense;
  if (damage > 0)
  {
   target.health -= damage;
   Console.WriteLine($"{name} attacks {target.name} for {damage} damage!");
  }
  else
  {
   Console.WriteLine($"{name}'s attack has no effect on {target.name}.");
  }
 }

 // Method for the Character class
 public virtual void Defend()
 {
  Console.WriteLine($"{name} defends.");
 }
}

// Define a derived class called "Warrior" that inherits from Character
public class Warrior : Character
{
 // Constructor for the Warrior class
 public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
 {
  // No additional code required
 }

 // Method for the Warrior class
 public void Charge(Character target)
 {
  int damage = attack * 2 - target.defense;
  if (damage > 0)
  {
   target.health -= damage;
   Console.WriteLine($"{name} charges {target.name} for {damage} damage!");
  }
  else
  {
   Console.WriteLine($"{name}'s charge has no effect on {target.name}.");
  }
 }

 // Override method for the Character class
 public override void Defend()
 {
  defense += 5;
  Console.WriteLine($"{name} defends and gains 5 defense.");
 }
}

// Define another derived class called "Mage" that inherits from Character
public class Mage : Character
{
 // Constructor for the Mage class
 public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
 {
  // No additional code required
 }

 // Method for the Mage class
 public void CastSpell(Character target)
 {
  int damage = attack * 3 - target.defense;
  if (damage > 0)
  {
   target.health -= damage;
   Console.WriteLine($"{name} casts a spell on {target.name} for {damage} damage!");
  }
  else
  {
   Console.WriteLine($"{name}'s spell has no effect on {target.name}.");
  }
 }

 // Sealed method for the Mage class
 public sealed override void Defend()
 {
  Console.WriteLine($"{name} cannot defend!");
 }
}

// Define a derived class called "Dragon" that inherits from Character
public class Dragon : Character
{
 // Constructor for the Dragon class
 public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
 {
  // No additional code required
 }

 // Method for the Dragon class
 public void BreatheFire(Character target)
 {
  int damage = attack * 4 - target.defense;
  if (damage > 0)
  {
   target.health -= damage;
   Console.WriteLine($"{name} breathes fire on {target.name} for {damage} damage!");
  }
  else
  {
   Console.WriteLine($"{name}'s fire has no effect on {target.name}.");
  }
 }
 // Override method for the Character class
 public override void Defend()
 {
  Console.WriteLine($"{name} defends and gains 10 defense.");
  defense += 10;
 }
}

// Define a class called "Game"
public class Game
{
 // Method to simulate a battle between two characters
 public void Battle(Character c1, Character c2)
 {
  Console.WriteLine($"--- Battle between {c1.name} and {c2.name} ---");
  while (c1.health > 0 && c2.health > 0)
  {
   c1.Attack(c2);
   if (c2.health > 0)
   {
    c2.Attack(c1);
   }
  }

  if (c1.health <= 0)
  {
   Console.WriteLine($"{c2.name} wins!");
  }
  else
  {
   Console.WriteLine($"{c1.name} wins!");
  }
 }
}

// Main method to test the classes
public class Program
{
 public static void Main()
 {
  // Create some characters
  Warrior c1 = new Warrior("Arthur", 100, 20, 10);
  Mage c2 = new Mage("Merlin", 80, 15, 5);
  Dragon c3 = new Dragon("Smaug", 200, 30, 20);

  // Test the characters' methods
  c1.Attack(c2);
  c2.Defend();
  c3.BreatheFire(c1);
  c3.Defend();
  c1.Defend();

  // Create a new game and simulate some battles
  Game game = new Game();
  game.Battle(c1, c2);
  game.Battle(c3, c1);
  game.Battle(c2, c3);

  Console.ReadKey();
 }
}