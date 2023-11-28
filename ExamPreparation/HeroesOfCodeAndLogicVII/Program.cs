using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HeroesOfCodeAndLogicVII
{
    class Hero
    {

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = Heal(hp);
            MP = Recharge(mp);
        }

        public int Recharge(int amountMP)
        {
            int recoveredMP = Math.Min(amountMP, 200 - MP);
            MP += recoveredMP;
            return recoveredMP;
        }

        internal int Heal(int amountHP)
        {
            int recoveredHP = Math.Min(amountHP, 100 - HP);
            HP += recoveredHP;
            return recoveredHP;
        }
        public override string ToString()
        {
            StringBuilder heroBuilder = new StringBuilder();
            heroBuilder.AppendLine(Name);
            heroBuilder.AppendLine($"  HP: {HP}");
            heroBuilder.Append($"  MP: {MP}");

            return heroBuilder.ToString();
        }
    }
    internal class Program
    {
        static List<Hero> party = new List<Hero>();
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < heroesCount; i++) 
            {
                string[] heroesArgs = Console.ReadLine().Split();
                Hero h = new Hero(heroesArgs[0], int.Parse(heroesArgs[1]), int.Parse(heroesArgs[2]));
                party.Add(h);
            }
            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                string[] arguments = input.Split(" - ");

                switch (arguments[0])
                {
                    case "CastSpell":
                        CastSpell(arguments[1], int.Parse(arguments[2]), arguments[3]);
                        break;
                    case "TakeDamage":
                        TakeDamage(arguments[1], int.Parse(arguments[2]), arguments[3]);
                        break;
                    case "Recharge":
                        Recharge(arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Heal":
                        Heal(arguments[1], int.Parse(arguments[2]));
                        break;

                }
            }
            party.ForEach(h =>Console.WriteLine(h));
        }

        private static void Heal(string heroName, int amountHP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
            if (foundHero != null)
            {
                int recovered = foundHero.Heal(amountHP);
                Console.WriteLine($"{foundHero.Name} healed for {recovered} HP!");
            }
            
        }

        static void Recharge(string heroName, int amountMP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
            if (foundHero != null)
            {
                int recovered = foundHero.Recharge(amountMP);
                Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
            }
            
        }

        static void TakeDamage(string heroName, int damage, string attackerName)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
            if (foundHero != null)
            {
                foundHero.HP -= damage;
            }
            if (foundHero.HP > 0)
            {
                Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attackerName} and now has {foundHero.HP} HP left!");
            }
            else
            {
                party.Remove(foundHero);
                Console.WriteLine($"{foundHero.Name} has been killed by {attackerName}!");
            }
        }

        static void CastSpell(string heroName, int mpNeeded, string spellName)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
            if (foundHero != null && foundHero.MP >= mpNeeded)
            {
                foundHero.MP -= mpNeeded;
                Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!");
            }

        }
    }
}