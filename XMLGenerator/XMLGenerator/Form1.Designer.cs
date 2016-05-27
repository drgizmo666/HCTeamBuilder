namespace XMLGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speedPower1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.damageSymbol = new System.Windows.Forms.ComboBox();
            this.defenseSymbol = new System.Windows.Forms.ComboBox();
            this.attackSymbol = new System.Windows.Forms.ComboBox();
            this.speedSymbol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.attackPower1 = new System.Windows.Forms.ComboBox();
            this.defensePower1 = new System.Windows.Forms.ComboBox();
            this.damagePower1 = new System.Windows.Forms.ComboBox();
            this.speedValue1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.attackValue1 = new System.Windows.Forms.TextBox();
            this.defenseValue1 = new System.Windows.Forms.TextBox();
            this.damageValue1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.damageValue2 = new System.Windows.Forms.TextBox();
            this.defenseValue2 = new System.Windows.Forms.TextBox();
            this.attackValue2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.speedValue2 = new System.Windows.Forms.TextBox();
            this.damagePower2 = new System.Windows.Forms.ComboBox();
            this.defensePower2 = new System.Windows.Forms.ComboBox();
            this.attackPower2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.speedPower2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // speedPower1
            // 
            this.speedPower1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedPower1.FormattingEnabled = true;
            this.speedPower1.Items.AddRange(new object[] {
            "None",
            "Flurry",
            "Leap/Climb",
            "Phasing/Teleport",
            "EarthBound/Neutralized",
            "Mind Control",
            "Plasticity",
            "Force Blast",
            "SideStep",
            "Hypersonic Speed",
            "Stealth",
            "Running Shot",
            "Special"});
            this.speedPower1.Location = new System.Drawing.Point(164, 300);
            this.speedPower1.Name = "speedPower1";
            this.speedPower1.Size = new System.Drawing.Size(121, 21);
            this.speedPower1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Defense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Damage";
            // 
            // damageSymbol
            // 
            this.damageSymbol.BackColor = System.Drawing.SystemColors.Window;
            this.damageSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.damageSymbol.FormattingEnabled = true;
            this.damageSymbol.Items.AddRange(new object[] {
            "Tiny",
            "Standard",
            "Giant ",
            "Colossal"});
            this.damageSymbol.Location = new System.Drawing.Point(65, 383);
            this.damageSymbol.Name = "damageSymbol";
            this.damageSymbol.Size = new System.Drawing.Size(93, 21);
            this.damageSymbol.TabIndex = 6;
            // 
            // defenseSymbol
            // 
            this.defenseSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defenseSymbol.FormattingEnabled = true;
            this.defenseSymbol.Items.AddRange(new object[] {
            "Standard",
            "Indomitable",
            "Vehicle"});
            this.defenseSymbol.Location = new System.Drawing.Point(65, 354);
            this.defenseSymbol.Name = "defenseSymbol";
            this.defenseSymbol.Size = new System.Drawing.Size(93, 21);
            this.defenseSymbol.TabIndex = 7;
            // 
            // attackSymbol
            // 
            this.attackSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attackSymbol.FormattingEnabled = true;
            this.attackSymbol.Items.AddRange(new object[] {
            "Standard",
            "Duo",
            "Team",
            "Sharpshooter"});
            this.attackSymbol.Location = new System.Drawing.Point(65, 327);
            this.attackSymbol.Name = "attackSymbol";
            this.attackSymbol.Size = new System.Drawing.Size(93, 21);
            this.attackSymbol.TabIndex = 8;
            // 
            // speedSymbol
            // 
            this.speedSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedSymbol.FormattingEnabled = true;
            this.speedSymbol.Items.AddRange(new object[] {
            "Standard",
            "Transporter",
            "Flier",
            "Flier/Transporter",
            "Swimmer",
            "Swimmer/Transporter"});
            this.speedSymbol.Location = new System.Drawing.Point(65, 300);
            this.speedSymbol.Name = "speedSymbol";
            this.speedSymbol.Size = new System.Drawing.Size(93, 21);
            this.speedSymbol.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(62, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Symbol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(164, 274);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(121, 23);
            this.Power.TabIndex = 11;
            this.Power.Text = "Power";
            this.Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attackPower1
            // 
            this.attackPower1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attackPower1.FormattingEnabled = true;
            this.attackPower1.Items.AddRange(new object[] {
            "None",
            "Blades/Claws/Fangs",
            "Energy Explosion",
            "Pulse Wave",
            "Quake",
            "Super Strength",
            "Incapacitate",
            "Penetrating/Psychic Blast",
            "Smoke Cloud",
            "Precision Strike",
            "Poison",
            "Steal Energy",
            "Telekinesis",
            "Special"});
            this.attackPower1.Location = new System.Drawing.Point(164, 327);
            this.attackPower1.Name = "attackPower1";
            this.attackPower1.Size = new System.Drawing.Size(121, 21);
            this.attackPower1.TabIndex = 12;
            // 
            // defensePower1
            // 
            this.defensePower1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defensePower1.FormattingEnabled = true;
            this.defensePower1.Items.AddRange(new object[] {
            "None",
            "Super Senses",
            "Toughness",
            "Defend",
            "Combat Reflexes",
            "Energy Shield/Deflection",
            "Barrier",
            "MasterMind",
            "WillPower",
            "Invincible",
            "Impervious",
            "Regeneration",
            "Invulnerability",
            "Special"});
            this.defensePower1.Location = new System.Drawing.Point(164, 354);
            this.defensePower1.Name = "defensePower1";
            this.defensePower1.Size = new System.Drawing.Size(121, 21);
            this.defensePower1.TabIndex = 13;
            // 
            // damagePower1
            // 
            this.damagePower1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.damagePower1.FormattingEnabled = true;
            this.damagePower1.Items.AddRange(new object[] {
            "None",
            "Ranged Combat Expert",
            "Battle Fury",
            "Support",
            "Exploit Weakness",
            "Enhancement",
            "Probability Control",
            "Shape Change",
            "Close Combat Expert",
            "Empower",
            "Perplex",
            "Outwit",
            "Leadership",
            "Special"});
            this.damagePower1.Location = new System.Drawing.Point(164, 383);
            this.damagePower1.Name = "damagePower1";
            this.damagePower1.Size = new System.Drawing.Size(121, 21);
            this.damagePower1.TabIndex = 14;
            // 
            // speedValue1
            // 
            this.speedValue1.Location = new System.Drawing.Point(294, 302);
            this.speedValue1.Name = "speedValue1";
            this.speedValue1.Size = new System.Drawing.Size(42, 20);
            this.speedValue1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(291, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attackValue1
            // 
            this.attackValue1.Location = new System.Drawing.Point(294, 328);
            this.attackValue1.Name = "attackValue1";
            this.attackValue1.Size = new System.Drawing.Size(42, 20);
            this.attackValue1.TabIndex = 17;
            // 
            // defenseValue1
            // 
            this.defenseValue1.Location = new System.Drawing.Point(294, 355);
            this.defenseValue1.Name = "defenseValue1";
            this.defenseValue1.Size = new System.Drawing.Size(42, 20);
            this.defenseValue1.TabIndex = 18;
            // 
            // damageValue1
            // 
            this.damageValue1.Location = new System.Drawing.Point(294, 384);
            this.damageValue1.Name = "damageValue1";
            this.damageValue1.Size = new System.Drawing.Size(42, 20);
            this.damageValue1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(164, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Click 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(634, 70);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(35, 13);
            this.output.TabIndex = 21;
            this.output.Text = "label8";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(339, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Click 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // damageValue2
            // 
            this.damageValue2.Location = new System.Drawing.Point(469, 384);
            this.damageValue2.Name = "damageValue2";
            this.damageValue2.Size = new System.Drawing.Size(42, 20);
            this.damageValue2.TabIndex = 31;
            // 
            // defenseValue2
            // 
            this.defenseValue2.Location = new System.Drawing.Point(469, 355);
            this.defenseValue2.Name = "defenseValue2";
            this.defenseValue2.Size = new System.Drawing.Size(42, 20);
            this.defenseValue2.TabIndex = 30;
            // 
            // attackValue2
            // 
            this.attackValue2.Location = new System.Drawing.Point(469, 328);
            this.attackValue2.Name = "attackValue2";
            this.attackValue2.Size = new System.Drawing.Size(42, 20);
            this.attackValue2.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(466, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Value";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedValue2
            // 
            this.speedValue2.Location = new System.Drawing.Point(469, 302);
            this.speedValue2.Name = "speedValue2";
            this.speedValue2.Size = new System.Drawing.Size(42, 20);
            this.speedValue2.TabIndex = 27;
            // 
            // damagePower2
            // 
            this.damagePower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.damagePower2.FormattingEnabled = true;
            this.damagePower2.Items.AddRange(new object[] {
            "None",
            "Ranged Combat Expert",
            "Battle Fury",
            "Support",
            "Exploit Weakness",
            "Enhancement",
            "Probability Control",
            "Shape Change",
            "Close Combat Expert",
            "Empower",
            "Perplex",
            "Outwit",
            "Leadership",
            "Special"});
            this.damagePower2.Location = new System.Drawing.Point(342, 383);
            this.damagePower2.Name = "damagePower2";
            this.damagePower2.Size = new System.Drawing.Size(121, 21);
            this.damagePower2.TabIndex = 26;
            // 
            // defensePower2
            // 
            this.defensePower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defensePower2.FormattingEnabled = true;
            this.defensePower2.Items.AddRange(new object[] {
            "None",
            "Super Senses",
            "Toughness",
            "Defend",
            "Combat Reflexes",
            "Energy Shield/Deflection",
            "Barrier",
            "MasterMind",
            "WillPower",
            "Invincible",
            "Impervious",
            "Regeneration",
            "Invulnerability",
            "Special"});
            this.defensePower2.Location = new System.Drawing.Point(342, 354);
            this.defensePower2.Name = "defensePower2";
            this.defensePower2.Size = new System.Drawing.Size(121, 21);
            this.defensePower2.TabIndex = 25;
            // 
            // attackPower2
            // 
            this.attackPower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attackPower2.FormattingEnabled = true;
            this.attackPower2.Items.AddRange(new object[] {
            "None",
            "Blades/Claws/Fangs",
            "Energy Explosion",
            "Pulse Wave",
            "Quake",
            "Super Strength",
            "Incapacitate",
            "Penetrating/Psychic Blast",
            "Smoke Cloud",
            "Precision Strike",
            "Poison",
            "Steal Energy",
            "Telekinesis",
            "Special"});
            this.attackPower2.Location = new System.Drawing.Point(342, 327);
            this.attackPower2.Name = "attackPower2";
            this.attackPower2.Size = new System.Drawing.Size(121, 21);
            this.attackPower2.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(339, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Power";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedPower2
            // 
            this.speedPower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedPower2.FormattingEnabled = true;
            this.speedPower2.Items.AddRange(new object[] {
            "None",
            "Flurry",
            "Leap/Climb",
            "Phasing/Teleport",
            "EarthBound/Neutralized",
            "Mind Control",
            "Plasticity",
            "Force Blast",
            "SideStep",
            "Hypersonic Speed",
            "Stealth",
            "Running Shot",
            "Special"});
            this.speedPower2.Location = new System.Drawing.Point(342, 300);
            this.speedPower2.Name = "speedPower2";
            this.speedPower2.Size = new System.Drawing.Size(121, 21);
            this.speedPower2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 416);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.damageValue2);
            this.Controls.Add(this.defenseValue2);
            this.Controls.Add(this.attackValue2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.speedValue2);
            this.Controls.Add(this.damagePower2);
            this.Controls.Add(this.defensePower2);
            this.Controls.Add(this.attackPower2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.speedPower2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.damageValue1);
            this.Controls.Add(this.defenseValue1);
            this.Controls.Add(this.attackValue1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speedValue1);
            this.Controls.Add(this.damagePower1);
            this.Controls.Add(this.defensePower1);
            this.Controls.Add(this.attackPower1);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedSymbol);
            this.Controls.Add(this.attackSymbol);
            this.Controls.Add(this.defenseSymbol);
            this.Controls.Add(this.damageSymbol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.speedPower1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox speedPower1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox damageSymbol;
        private System.Windows.Forms.ComboBox defenseSymbol;
        private System.Windows.Forms.ComboBox attackSymbol;
        private System.Windows.Forms.ComboBox speedSymbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.ComboBox attackPower1;
        private System.Windows.Forms.ComboBox defensePower1;
        private System.Windows.Forms.ComboBox damagePower1;
        private System.Windows.Forms.TextBox speedValue1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attackValue1;
        private System.Windows.Forms.TextBox defenseValue1;
        private System.Windows.Forms.TextBox damageValue1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox damageValue2;
        private System.Windows.Forms.TextBox defenseValue2;
        private System.Windows.Forms.TextBox attackValue2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox speedValue2;
        private System.Windows.Forms.ComboBox damagePower2;
        private System.Windows.Forms.ComboBox defensePower2;
        private System.Windows.Forms.ComboBox attackPower2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox speedPower2;
    }
}

