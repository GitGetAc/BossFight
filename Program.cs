namespace BossFight
{
    internal class Program
    {
        static void Main()
        {
            GameCharacter Hero = new("Hero", 100, 40, 20);
            GameCharacter Boss = new("Boss", 400, 10);

            Hero.WriteSpecsOfGameCharacter();
            Boss.WriteSpecsOfGameCharacter();
            
            Console.ReadKey();
            LetsFight();

            //The While fight loop
            while (Hero.Health > 0 && Boss.Health > 0)
            {
                if (Hero.Stamina <= 0)
                {
                    Hero.Recharge();
                    Console.ReadKey();
                }
                else
                {
                    Hero.Attack();
                    Boss.Health -= Hero.Strength;

                    if (Boss.Health <= 0) { Console.WriteLine($"The {Hero.Name} attacks the {Boss.Name} and deals {Convert.ToString(Hero.Strength)} damage! The {Boss.Name} is dead."); }
                    else { Console.WriteLine($"The {Hero.Name} attacks the {Boss.Name} and deals {Convert.ToString(Hero.Strength)} damage! The {Boss.Name} has {Convert.ToString(Boss.Health)} points left."); }

                    Console.ReadKey();
                }

                if (Boss.Stamina <= 0)
                {
                    Boss.Recharge();
                    Console.ReadKey();
                }
                else
                {
                    Boss.Attack();
                    Hero.Health -= Boss.Strength;

                    if(Hero.Health <= 0) { Console.WriteLine($"The {Boss.Name} attacks the {Hero.Name} and deals {Convert.ToString(Boss.Strength)} damage! The {Hero.Name} is dead."); }
                    else { Console.WriteLine($"The {Boss.Name} attacks the {Hero.Name} and deals {Convert.ToString(Boss.Strength)} damage! The {Hero.Name} has {Convert.ToString(Hero.Health)} points left."); }

                    Console.ReadKey();
                }
            }
            if (Hero.Health < Boss.Health) { Console.WriteLine($"The {Boss.Name} won this time!"); } else { Console.WriteLine($"The {Hero.Name} won this time!"); }
        }

        public static void LetsFight()
        {
            Console.WriteLine("\nLet's fight!");
            Console.ReadKey();

        }
    }
}


/*Oppgave: Bossfight


Dere skal lage en konsoll app som viser en battle mellom en hero og en boss.

Skriv en klasse GameCharacter som har en metode Fight(), en metode Recharge() og følgende properties:

Health, Strength, Stamina

Program.cs filen må initialisere to objekter av denne klassen, en Hero og en Boss med følgende stats:

Hero: Boss:
Health: 100                Health: 400
Strength: 20               Strength: 0 - 30
Stamina: 40                Stamina: 10

Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper, hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.

I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.

Hver gang en character bruker metoden Fight() mister de også 10 stamina.

Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen. De rundene gamecharacterene må recharge får de ikke utført noe skade.

Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. Om dette blir for avansert, la bossen også få en fast styrke på 20.

Eksempel på Konsollens logg når programmet har kjørt ferdig:

Enemy hit hero with 5 damage, hero now has 30 health left.
Hero hit enemy with 20 damage, enemy has 0 health left.
Hero is the winner!

 //Ezt a funksjon-t megnezni!!
            Console.WriteLine($"{aName} hit {aEnemy} with {Convert.ToString(_strength)} damage, {aEnemy} now has {Convert.ToString(aEnemy._health)} health left.");

Console.WriteLine($"The {Name} attacks the enemy and deals {Convert.ToString(Strength)} damage!");
 */

