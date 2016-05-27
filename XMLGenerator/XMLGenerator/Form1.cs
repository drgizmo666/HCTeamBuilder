using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLGenerator
{
    public partial class Form1 : Form
    {
        public List<Clix> dial = new List<Clix>();

        public Form1()
        {
            InitializeComponent();
            damageSymbol.SelectedIndex = 1;
            defenseSymbol.SelectedIndex = 0;
            attackSymbol.SelectedIndex = 0;
            speedSymbol.SelectedIndex = 0;
            speedPower1.SelectedIndex = 0;
            attackPower1.SelectedIndex = 0;
            defensePower1.SelectedIndex = 0;
            damagePower1.SelectedIndex = 0;
            speedPower2.SelectedIndex = 0;
            attackPower2.SelectedIndex = 0;
            defensePower2.SelectedIndex = 0;
            damagePower2.SelectedIndex = 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure fig = new Figure();
            FillClixList();
            fig.Dial = dial;

            string showThis = "Dial List \n";
            foreach (Clix value in fig.Dial)
            {
                showThis += value.Speed + " " + value.SpeedPower + "\n" +
                            value.Attack + " " + value.AttackPower + "\n" +
                            value.Defense + " " + value.DefensePower + "\n" +
                            value.Damage + " " + value.DamagePower + "\n\n";
            }
            output.Text = showThis;
        }

        private void FillClixList()
        {
            Clix click1 = new Clix()
            {
                Speed = speedValue1.Text,
                SpeedPower = speedPower1.Text,
                Attack = attackValue1.Text,
                AttackPower = attackPower1.Text,
                Defense = defenseValue1.Text,
                DefensePower = defensePower1.Text,
                Damage = damageValue1.Text,
                DamagePower = damagePower1.Text
            };
            dial.Add(click1);
            Clix click2 = new Clix()
            {
                Speed = speedValue2.Text,
                SpeedPower = speedPower2.Text,
                Attack = attackValue2.Text,
                AttackPower = attackPower2.Text,
                Defense = defenseValue2.Text,
                DefensePower = defensePower2.Text,
                Damage = damageValue2.Text,
                DamagePower = damagePower2.Text
            };
            dial.Add(click2);
        }
    }
}
