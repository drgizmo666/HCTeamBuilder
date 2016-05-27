using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLGenerator;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clix> d1 = new List<Clix>();
            List<SpecialPower> p1 = new List<SpecialPower>();
            Clix click1 = new Clix()
            {
                Attack = "10",
                AttackPower = "none",
                Speed = "4",
                SpeedPower = "blades",
                Defense = "16",
                DefensePower = "tough",
                Damage = "2",
                DamagePower = "none"
            };
            d1.Add(click1);
            Clix click2 = new Clix()
            {
                Attack = "10",
                AttackPower = "none",
                Speed = "4",
                SpeedPower = "blades",
                Defense = "16",
                DefensePower = "tough",
                Damage = "2",
                DamagePower = "none"
            };
            d1.Add(click2);
            Clix click3 = new Clix()
            {
                Attack = "9",
                AttackPower = "none",
                Speed = "4",
                SpeedPower = "blades",
                Defense = "16",
                DefensePower = "tough",
                Damage = "2",
                DamagePower = "none"
            };
            d1.Add(click3);
            Clix click4 = new Clix()
            {
                Attack = "9",
                AttackPower = "none",
                Speed = "4",
                SpeedPower = "blades",
                Defense = "16",
                DefensePower = "tough",
                Damage = "2",
                DamagePower = "none"
            };
            d1.Add(click4);

            SpecialPower power1 = new SpecialPower()
            {
                Type = "trait",
                Description = "Underwater Predator: When Shark occupies water terrain, it can use Charge and Exploit Weakness and modifies its speed value by +3"
            };
            p1.Add(power1);
            Figure fig1 = new Figure()
            {
                HeroName = "Shark",
                RealName = "none",
                Relationship = "parent",
                Points = 30,
                TeamAbility = "none",
                KeyWords = "Animal, Atlantis",
                Bolts = 1,
                Range = 0,
                Power = p1,
                Dial = d1

            };

            Console.WriteLine("Name: " + fig1.HeroName);
            Console.WriteLine("Keywords: " + fig1.KeyWords);
            Console.WriteLine("Points: " + fig1.Points.ToString());
            Console.WriteLine("Range: " + fig1.Range.ToString() + " Lightning Bolts: " + fig1.Bolts.ToString());
            Console.WriteLine("Special Powers");
            foreach(SpecialPower SpePower in fig1.Power)
            {
                Console.WriteLine(SpePower.Type + " " + SpePower.Description);
            }
            Console.WriteLine("Dial");
            foreach(Clix value in fig1.Dial)
            {
                Console.WriteLine(value.Speed + " " + value.SpeedPower);
                Console.WriteLine(value.Attack + " " + value.AttackPower);
                Console.WriteLine(value.Defense + " " + value.DefensePower);
                Console.WriteLine(value.Damage + " " + value.DamagePower);
                Console.WriteLine();
            }
        }
    }
}
