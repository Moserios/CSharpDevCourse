//Game Character System

//Introduction
//In this assignment, you will implement a simple game character system that demonstrates object-oriented programming concepts such as inheritance, method overriding, method hiding, and constructor chaining.


//Objectives
//Demonstrate understanding of inheritance and polymorphism in C#.
//Practice using constructors to chain initialization of base classes.
//Implement method overriding and hiding to modify behavior of derived classes.

//Requirements
//Create a base class called Character that has the following properties and methods:
//string name
//int health
//int attack
//int defense
//void Attack(Character target)
//void Defend()


public abstract class Character
{
    internal string _name;
    internal int _health;
    internal int _damage;
    internal int _defense;

    public string Name
    {
        set
        { _name = value; }
        get
        { return _name; }
    }

    public int Health
    {
        set
        { _health = value; }
        get
        { return _health; }
    }

    public int Damage
    {
        set
        { _damage = value; }
        get
        { return _damage; }
    }

    public int Defense
    {
        set
        { _defense = value; }
        get
        { return _defense; }
    }


    //The Attack method should take a Character object as a parameter and calculate the amount of damage that the current character would do to the target character based on their attack and defense values.
    //If the damage is greater than 0, it should reduce the target's health by that amount and print a message to the console. If the damage is less than or equal to 0, it should print a different message to the console.

    public Character(string name, int health, int damage, int defense)
    {
        _name = name;
        _health = health;
        _damage = damage;
        _defense = defense;
    }


    public virtual void Attack(Character target)
    {

        int damageDone = _damage - target.Defense;
        int targetHealth = target.Health;
        System.Console.WriteLine($"\n{this.Name} attacks {target.Name} inflicting {damageDone} damage.");

        if (damageDone > 0 && targetHealth > 0)
        {
            target.Health = targetHealth - damageDone;
            if (target.Health < 0)
            { target.Health = 0; }
            System.Console.WriteLine($"{target.Name} reflects {target.Defense} damage and loses {damageDone} of health, {target.Health} health left.");
            if (target.Health == 0)
            {
                System.Console.WriteLine($"In battle {this.Name} wins {target.Name}.");
            }
        }
        else
        {
            System.Console.WriteLine($"\n{this.Name}'s attack has no effect on {target.Name}.");
        }
    }

    //The Defend method should simply print a message to the console indicating that the character is defending.
    public virtual void Defend()
    {
        System.Console.WriteLine($"{_name} is defending.");
    }
}


//You will then create three derived classes called Warrior, Mage and Dragon that inherit from Character and have the following additional methods:

//Warrior
//Charge(Character target): a method to charge at a target
//Override the Defend method to add 5 to the character's defense value when called.

public class Warrior : Character
{

    public new void Attack(Character target)
    { }

    public override void Defend()
    {
        int defence = this.Defense;
        this.Defense = defence + 25;
        System.Console.WriteLine($"{_name} is defending.");
    }

    public Warrior(string name, int health, int damage, int defense) : base(name, health, damage, defense)
    {
        System.Console.WriteLine($"{name} is a warrior.");
    }

    public void Charge(Character target)
    {

        int targetHealth = target.Health;
        int damageDone = this._damage - target.Defense;
        System.Console.WriteLine($"\n{this.Name} attacks {target.Name} inflicting {this._damage} damage.");

        if (damageDone > 0 && targetHealth > 0)
        {
            target.Health = targetHealth - damageDone;
            if (target.Health < 0)
            { target.Health = 0; }
            System.Console.WriteLine($"{target.Name} reflects {target.Defense} damage and loses {damageDone} of health, {target.Health} health left.");
            if (target.Health == 0)
            {
                System.Console.WriteLine($"In battle {this.Name} wins {target.Name}.");
            }
        }
        else
        {
            System.Console.WriteLine($"{this.Name}'s attack has no effect on {target.Name}.");
        }
    }

}

//Mage
//CastSpell(Character target): a method to cast a spell at a target
//Seal the Defend method so that it cannot be further overridden in any derived classes.

public class Mage : Character
{
    public Mage(string name, int health, int damage, int defense) : base(name, health, damage, defense)
    {
        System.Console.WriteLine($"{name} is a mage.");
    }

    public new void Attack(Character target)
    { }

    public void CastSpell(Character target)
    {

        int targetHealth = target.Health;
        int damageDone = _damage - target.Defense;
        System.Console.WriteLine($"\n{this.Name} casts spell to {target.Name} inflicting {_damage} damage.");

        if (damageDone > 0 && targetHealth > 0)
        {
            target.Health = targetHealth - damageDone;
            if (target.Health < 0)
            { target.Health = 0; }
            System.Console.WriteLine($"{target.Name} reflects {target.Defense} damage and loses {damageDone} of health, {target.Health} health left.");
            if (target.Health == 0)
            {
                System.Console.WriteLine($"In battle {this.Name} wins {target.Name}.");
            }
        }
        else
        {
            System.Console.WriteLine($"{this.Name}'s attack has no effect on {target.Name}.");
        }
    }

    public sealed override void Defend()
    {
        System.Console.WriteLine($"{_name} can't defend.");
    }
}


//Dragon
//BreatheFire(Character target): a method for the dragon to breathe fire at a target
//Override the Attack method to double the attack value when called.

public class Dragon : Character
{
    public Dragon(string name, int health, int damage, int defense) : base(name, health, damage, defense)
    {
        System.Console.WriteLine($"{name} is a dragon.");
    }

    public override void Attack(Character target)
    {
        this.Damage = this.Damage * 2;
        System.Console.WriteLine($"\n{this.Name} rages and increases damage up to {this.Damage}.");
    }
    public void BreatheFire(Character target)
    {

        int targetHealth = target.Health;
        int damageDone = _damage - target.Defense;
        System.Console.WriteLine($"\n{this.Name} breathes fire to {target.Name} inflicting {_damage} damage.");

        if (damageDone > 0 && targetHealth > 0)
        {
            target.Health = targetHealth - damageDone;
            if (target.Health < 0)
            { target.Health = 0; }
            System.Console.WriteLine($"{target.Name} reflects {target.Defense} damage and loses {damageDone} of health, {target.Health} health left.");
            if (target.Health == 0)
            {
                System.Console.WriteLine($"In battle {this.Name} wins {target.Name}.");
            }
        }
        else
        {
            System.Console.WriteLine($"{this.Name}'s attack has no effect on {target.Name}.");
        }
    }
}
