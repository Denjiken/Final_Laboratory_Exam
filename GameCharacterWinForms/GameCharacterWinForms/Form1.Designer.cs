namespace GameCharacterWinForms
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(62, 40);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 22);
            this.txtLevel.TabIndex = 2;
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(62, 68);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(100, 22);
            this.txtHealth.TabIndex = 3;
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(62, 96);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(121, 24);
            this.cmbCharacterType.TabIndex = 4;
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterType_SelectedIndexChanged);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(83, 126);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(100, 22);
            this.txtStrength.TabIndex = 5;
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(62, 154);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(100, 22);
            this.txtMana.TabIndex = 6;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(93, 185);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(100, 22);
            this.txtIntelligence.TabIndex = 7;
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.ItemHeight = 16;
            this.listBoxCharacters.Location = new System.Drawing.Point(63, 249);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(129, 148);
            this.listBoxCharacters.TabIndex = 8;
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.Location = new System.Drawing.Point(546, 40);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(100, 306);
            this.txtCharacterDetails.TabIndex = 9;
            this.txtCharacterDetails.Text = "Character details will appear here.";
            // 
            // battleLog
            // 
            this.battleLog.FormattingEnabled = true;
            this.battleLog.ItemHeight = 16;
            this.battleLog.Location = new System.Drawing.Point(652, 40);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(120, 404);
            this.battleLog.TabIndex = 10;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(163, 214);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(124, 23);
            this.btnAddCharacter.TabIndex = 11;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.Location = new System.Drawing.Point(145, 403);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(129, 23);
            this.btnSelectCharacter.TabIndex = 12;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.SystemColors.Control;
            this.btnAttack.Location = new System.Drawing.Point(292, 374);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(107, 40);
            this.btnAttack.TabIndex = 13;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(405, 374);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(107, 40);
            this.btnDefend.TabIndex = 14;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(518, 374);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(117, 40);
            this.btnLevelUp.TabIndex = 15;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Intelligence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Character;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::GameCharacterWinForms.Properties.Resources.a083c595_d9c8_4f0c_98fa_5a24b8_unscreen;
            this.pictureBox1.Location = new System.Drawing.Point(278, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Character;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::GameCharacterWinForms.Properties.Resources.db3f043b_8304_4ced_a767_a661723297e7;
            this.pictureBox2.Location = new System.Drawing.Point(405, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GameCharacterWinForms.Properties.Resources.Register_Login_unscreen;
            this.pictureBox3.Location = new System.Drawing.Point(278, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources._8af020ee_c6af_4496_bd2d_9513fd533b031;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.listBoxCharacters);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.ListBox battleLog;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

