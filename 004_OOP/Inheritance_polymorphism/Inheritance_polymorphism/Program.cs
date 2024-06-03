//You will also create a class called Game that has a main method to test your character system.
//In the main method, you will create one instance of each character type and have them attack each other in a loop until one of them runs out of health.
//You can have each character take turns attacking and defending.
//You can demonstrate few calls to Attack(), Defend(), BreatheFire() methods for demonstration.

//Sample output:

//Arthur is a warrior.
//Merlin is a mage.
//Smaug is a dragon.

//Arthur attacks Merlin for 15 damage!
//Merlin cannot defend!
//Smaug breathes fire on Arthur for 110 damage!
//Smaug defends and gains 10 defense.
//Arthur defends and gains 5 defense.
//--- Battle between Arthur and Merlin ---
//Merlin wins!
//--- Battle between Smaug and Arthur ---
//Smaug wins!
//--- Battle between Merlin and Smaug ---
//Merlin's attack has no effect on Smaug.
//Smaug attacks Merlin for 25 damage!
//Merlin's attack has no effect on Smaug.
//Smaug attacks Merlin for 25 damage!
//Merlin's attack has no effect on Smaug.
//Smaug attacks Merlin for 25 damage!
//Smaug wins!


class Game
{
    static void Main()
    {
        Warrior Artur = new Warrior("Artur", 80, 80, 50);
        Mage Merlin = new Mage("Merlin", 100, 300, 0);
        Dragon Smaug = new Dragon("Smaug", 350, 100, 120);
        //System.Console.WriteLine();

        Artur.Charge(Smaug);
        Artur.Defend();
        Smaug.BreatheFire(Artur);

        Artur.Charge(Smaug);
        Artur.Defend();
        Merlin.CastSpell(Smaug);

        Artur.Charge(Merlin);

        Smaug.Attack(Artur);
        Smaug.BreatheFire(Artur);

        Merlin.CastSpell(Smaug);

        System.Console.ReadKey();

    }
}