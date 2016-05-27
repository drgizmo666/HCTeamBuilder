using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public class Figure
    {
        public string HeroName { get; set; }
        public string RealName { get; set; }
        public string Relationship { get; set; }
        public int Points { get; set; }
        public string TeamAbility { get; set; }
        public string KeyWords { get; set; }
        public int Bolts { get; set; }
        public int Range { get; set; }
        public List<SpecialPower> Power { get; set; }
        public string SpeedSymbol { get; set; }
        public string AttackSymbol { get; set; }
        public string DefenseSymbol { get; set; }
        public string DamageSymbol { get; set; }
        public List<Clix> Dial { get; set; }
    }
}
