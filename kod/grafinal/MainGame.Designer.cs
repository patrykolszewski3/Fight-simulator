namespace grafinal
{
    partial class MainGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxCharacter = new System.Windows.Forms.ComboBox();
            this.buttonAddCharacter = new System.Windows.Forms.Button();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.comboBoxCharacter2 = new System.Windows.Forms.ComboBox();
            this.labelPickCharacter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCharacterHp = new System.Windows.Forms.TextBox();
            this.labelCharacterHp = new System.Windows.Forms.Label();
            this.labelCharacterHp2 = new System.Windows.Forms.Label();
            this.textBoxCharacterHp2 = new System.Windows.Forms.TextBox();
            this.labelCharacterDmg = new System.Windows.Forms.Label();
            this.textBoxCharacterDmg = new System.Windows.Forms.TextBox();
            this.labelCharacterDmg2 = new System.Windows.Forms.Label();
            this.textBoxCharacterDmg2 = new System.Windows.Forms.TextBox();
            this.textBoxNewCharacterHp = new System.Windows.Forms.TextBox();
            this.textBoxNewCharacterName = new System.Windows.Forms.TextBox();
            this.textBoxNewCharacterDamage = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAttackCharacter = new System.Windows.Forms.Button();
            this.buttonHealCharacter = new System.Windows.Forms.Button();
            this.buttonHealCharacter2 = new System.Windows.Forms.Button();
            this.buttonAttackCharacter2 = new System.Windows.Forms.Button();
            this.buttonEndTurn = new System.Windows.Forms.Button();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBoxCharacter
            // 
            this.comboBoxCharacter.FormattingEnabled = true;
            this.comboBoxCharacter.Location = new System.Drawing.Point(114, 157);
            this.comboBoxCharacter.Name = "comboBoxCharacter";
            this.comboBoxCharacter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharacter.TabIndex = 0;
            this.comboBoxCharacter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacter_SelectedIndexChanged);
            // 
            // buttonAddCharacter
            // 
            this.buttonAddCharacter.Location = new System.Drawing.Point(347, 25);
            this.buttonAddCharacter.Name = "buttonAddCharacter";
            this.buttonAddCharacter.Size = new System.Drawing.Size(100, 23);
            this.buttonAddCharacter.TabIndex = 1;
            this.buttonAddCharacter.Text = "Dodaj postać";
            this.buttonAddCharacter.UseVisualStyleBackColor = true;
            this.buttonAddCharacter.Click += new System.EventHandler(this.buttonAddCharacter_Click);
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerOne.Location = new System.Drawing.Point(108, 87);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(139, 39);
            this.labelPlayerOne.TabIndex = 3;
            this.labelPlayerOne.Text = "Gracz 1";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerTwo.Location = new System.Drawing.Point(583, 87);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(139, 39);
            this.labelPlayerTwo.TabIndex = 4;
            this.labelPlayerTwo.Text = "Gracz 2";
            // 
            // comboBoxCharacter2
            // 
            this.comboBoxCharacter2.FormattingEnabled = true;
            this.comboBoxCharacter2.Location = new System.Drawing.Point(592, 157);
            this.comboBoxCharacter2.Name = "comboBoxCharacter2";
            this.comboBoxCharacter2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharacter2.TabIndex = 5;
            this.comboBoxCharacter2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacter2_SelectedIndexChanged);
            // 
            // labelPickCharacter
            // 
            this.labelPickCharacter.AutoSize = true;
            this.labelPickCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPickCharacter.Location = new System.Drawing.Point(132, 141);
            this.labelPickCharacter.Name = "labelPickCharacter";
            this.labelPickCharacter.Size = new System.Drawing.Size(94, 13);
            this.labelPickCharacter.TabIndex = 6;
            this.labelPickCharacter.Text = "Wybierz postać";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(611, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz postać";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCharacterHp
            // 
            this.textBoxCharacterHp.Location = new System.Drawing.Point(150, 190);
            this.textBoxCharacterHp.Name = "textBoxCharacterHp";
            this.textBoxCharacterHp.Size = new System.Drawing.Size(27, 20);
            this.textBoxCharacterHp.TabIndex = 9;
            this.textBoxCharacterHp.TextChanged += new System.EventHandler(this.textBoxCharacterHp_TextChanged);
            // 
            // labelCharacterHp
            // 
            this.labelCharacterHp.AutoSize = true;
            this.labelCharacterHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterHp.Location = new System.Drawing.Point(112, 193);
            this.labelCharacterHp.Name = "labelCharacterHp";
            this.labelCharacterHp.Size = new System.Drawing.Size(24, 13);
            this.labelCharacterHp.TabIndex = 10;
            this.labelCharacterHp.Text = "HP";
            // 
            // labelCharacterHp2
            // 
            this.labelCharacterHp2.AutoSize = true;
            this.labelCharacterHp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterHp2.Location = new System.Drawing.Point(598, 193);
            this.labelCharacterHp2.Name = "labelCharacterHp2";
            this.labelCharacterHp2.Size = new System.Drawing.Size(24, 13);
            this.labelCharacterHp2.TabIndex = 12;
            this.labelCharacterHp2.Text = "HP";
            // 
            // textBoxCharacterHp2
            // 
            this.textBoxCharacterHp2.Location = new System.Drawing.Point(637, 190);
            this.textBoxCharacterHp2.Name = "textBoxCharacterHp2";
            this.textBoxCharacterHp2.Size = new System.Drawing.Size(27, 20);
            this.textBoxCharacterHp2.TabIndex = 11;
            this.textBoxCharacterHp2.TextChanged += new System.EventHandler(this.textBoxCharacterHp2_TextChanged);
            // 
            // labelCharacterDmg
            // 
            this.labelCharacterDmg.AutoSize = true;
            this.labelCharacterDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterDmg.Location = new System.Drawing.Point(111, 223);
            this.labelCharacterDmg.Name = "labelCharacterDmg";
            this.labelCharacterDmg.Size = new System.Drawing.Size(35, 13);
            this.labelCharacterDmg.TabIndex = 14;
            this.labelCharacterDmg.Text = "DMG";
            // 
            // textBoxCharacterDmg
            // 
            this.textBoxCharacterDmg.Location = new System.Drawing.Point(150, 220);
            this.textBoxCharacterDmg.Name = "textBoxCharacterDmg";
            this.textBoxCharacterDmg.Size = new System.Drawing.Size(27, 20);
            this.textBoxCharacterDmg.TabIndex = 13;
            // 
            // labelCharacterDmg2
            // 
            this.labelCharacterDmg2.AutoSize = true;
            this.labelCharacterDmg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterDmg2.Location = new System.Drawing.Point(598, 220);
            this.labelCharacterDmg2.Name = "labelCharacterDmg2";
            this.labelCharacterDmg2.Size = new System.Drawing.Size(35, 13);
            this.labelCharacterDmg2.TabIndex = 16;
            this.labelCharacterDmg2.Text = "DMG";
            // 
            // textBoxCharacterDmg2
            // 
            this.textBoxCharacterDmg2.Location = new System.Drawing.Point(637, 217);
            this.textBoxCharacterDmg2.Name = "textBoxCharacterDmg2";
            this.textBoxCharacterDmg2.Size = new System.Drawing.Size(27, 20);
            this.textBoxCharacterDmg2.TabIndex = 15;
            // 
            // textBoxNewCharacterHp
            // 
            this.textBoxNewCharacterHp.Location = new System.Drawing.Point(347, 79);
            this.textBoxNewCharacterHp.Name = "textBoxNewCharacterHp";
            this.textBoxNewCharacterHp.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewCharacterHp.TabIndex = 17;
            this.textBoxNewCharacterHp.Text = "HP";
            this.textBoxNewCharacterHp.TextChanged += new System.EventHandler(this.textBoxNewCharacterHp_TextChanged);
            // 
            // textBoxNewCharacterName
            // 
            this.textBoxNewCharacterName.Location = new System.Drawing.Point(347, 54);
            this.textBoxNewCharacterName.Name = "textBoxNewCharacterName";
            this.textBoxNewCharacterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewCharacterName.TabIndex = 18;
            this.textBoxNewCharacterName.Text = "Nazwa";
            // 
            // textBoxNewCharacterDamage
            // 
            this.textBoxNewCharacterDamage.Location = new System.Drawing.Point(347, 105);
            this.textBoxNewCharacterDamage.Name = "textBoxNewCharacterDamage";
            this.textBoxNewCharacterDamage.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewCharacterDamage.TabIndex = 19;
            this.textBoxNewCharacterDamage.Text = "DMG";
            this.textBoxNewCharacterDamage.TextChanged += new System.EventHandler(this.textBoxNewCharacterDamage_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(361, 187);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAttackCharacter
            // 
            this.buttonAttackCharacter.Location = new System.Drawing.Point(114, 257);
            this.buttonAttackCharacter.Name = "buttonAttackCharacter";
            this.buttonAttackCharacter.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackCharacter.TabIndex = 21;
            this.buttonAttackCharacter.Text = "Atak";
            this.buttonAttackCharacter.UseVisualStyleBackColor = true;
            this.buttonAttackCharacter.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonHealCharacter
            // 
            this.buttonHealCharacter.Location = new System.Drawing.Point(114, 286);
            this.buttonHealCharacter.Name = "buttonHealCharacter";
            this.buttonHealCharacter.Size = new System.Drawing.Size(75, 23);
            this.buttonHealCharacter.TabIndex = 22;
            this.buttonHealCharacter.Text = "Leczenie";
            this.buttonHealCharacter.UseVisualStyleBackColor = true;
            this.buttonHealCharacter.Click += new System.EventHandler(this.buttonDefenseCharacter_Click);
            // 
            // buttonHealCharacter2
            // 
            this.buttonHealCharacter2.Location = new System.Drawing.Point(601, 286);
            this.buttonHealCharacter2.Name = "buttonHealCharacter2";
            this.buttonHealCharacter2.Size = new System.Drawing.Size(75, 23);
            this.buttonHealCharacter2.TabIndex = 24;
            this.buttonHealCharacter2.Text = "Leczenie";
            this.buttonHealCharacter2.UseVisualStyleBackColor = true;
            this.buttonHealCharacter2.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAttackCharacter2
            // 
            this.buttonAttackCharacter2.Location = new System.Drawing.Point(601, 257);
            this.buttonAttackCharacter2.Name = "buttonAttackCharacter2";
            this.buttonAttackCharacter2.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackCharacter2.TabIndex = 23;
            this.buttonAttackCharacter2.Text = "Atak";
            this.buttonAttackCharacter2.UseVisualStyleBackColor = true;
            this.buttonAttackCharacter2.Click += new System.EventHandler(this.buttonAttackCharacter2_Click);
            // 
            // buttonEndTurn
            // 
            this.buttonEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEndTurn.Location = new System.Drawing.Point(361, 216);
            this.buttonEndTurn.Name = "buttonEndTurn";
            this.buttonEndTurn.Size = new System.Drawing.Size(75, 23);
            this.buttonEndTurn.TabIndex = 25;
            this.buttonEndTurn.Text = "Koniec tury";
            this.buttonEndTurn.UseVisualStyleBackColor = true;
            this.buttonEndTurn.Click += new System.EventHandler(this.buttonEndTurn_Click);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInformation.Location = new System.Drawing.Point(315, 260);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(170, 131);
            this.textBoxInformation.TabIndex = 26;
            this.textBoxInformation.Text = "Aby rozpocząć walkę, wybierz postacie i wciśnij przycisk \"Start\".";
            this.textBoxInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInformation.TextChanged += new System.EventHandler(this.textBoxInformation_TextChanged);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grafinal.Properties.Resources.ring;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.buttonEndTurn);
            this.Controls.Add(this.buttonHealCharacter2);
            this.Controls.Add(this.buttonAttackCharacter2);
            this.Controls.Add(this.buttonHealCharacter);
            this.Controls.Add(this.buttonAttackCharacter);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxNewCharacterDamage);
            this.Controls.Add(this.textBoxNewCharacterName);
            this.Controls.Add(this.textBoxNewCharacterHp);
            this.Controls.Add(this.labelCharacterDmg2);
            this.Controls.Add(this.textBoxCharacterDmg2);
            this.Controls.Add(this.labelCharacterDmg);
            this.Controls.Add(this.textBoxCharacterDmg);
            this.Controls.Add(this.labelCharacterHp2);
            this.Controls.Add(this.textBoxCharacterHp2);
            this.Controls.Add(this.labelCharacterHp);
            this.Controls.Add(this.textBoxCharacterHp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPickCharacter);
            this.Controls.Add(this.comboBoxCharacter2);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Controls.Add(this.buttonAddCharacter);
            this.Controls.Add(this.comboBoxCharacter);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCharacter;
        private System.Windows.Forms.Button buttonAddCharacter;
        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.ComboBox comboBoxCharacter2;
        private System.Windows.Forms.Label labelPickCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCharacterHp;
        private System.Windows.Forms.Label labelCharacterHp;
        private System.Windows.Forms.Label labelCharacterHp2;
        private System.Windows.Forms.TextBox textBoxCharacterHp2;
        private System.Windows.Forms.Label labelCharacterDmg;
        private System.Windows.Forms.TextBox textBoxCharacterDmg;
        private System.Windows.Forms.Label labelCharacterDmg2;
        private System.Windows.Forms.TextBox textBoxCharacterDmg2;
        private System.Windows.Forms.TextBox textBoxNewCharacterHp;
        private System.Windows.Forms.TextBox textBoxNewCharacterName;
        private System.Windows.Forms.TextBox textBoxNewCharacterDamage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAttackCharacter;
        private System.Windows.Forms.Button buttonHealCharacter;
        private System.Windows.Forms.Button buttonHealCharacter2;
        private System.Windows.Forms.Button buttonAttackCharacter2;
        private System.Windows.Forms.Button buttonEndTurn;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.Timer timerCounter;
    }
}

