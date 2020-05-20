namespace DnDTools
{
    partial class FormAddPartyCharacter
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblHealth = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.tbxHealthCurrent = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.lblRations = new System.Windows.Forms.Label();
			this.tbxRations = new System.Windows.Forms.TextBox();
			this.lblSpellSlots = new System.Windows.Forms.Label();
			this.lblSpellSlotFirstLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotSecondLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotThirdLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotFourthLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotFifthLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotSixthLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotSeventhLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotEigthLevel = new System.Windows.Forms.Label();
			this.lblSpellSlotNinthLevel = new System.Windows.Forms.Label();
			this.tbxSpellSlot1stLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot2ndLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot3rdLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot4thLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot5thLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot6thLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot7thLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot8thLevelCurrent = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot9thLevelCurrent = new System.Windows.Forms.TextBox();
			this.lblGold = new System.Windows.Forms.Label();
			this.tbxGold = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot9thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot8thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot7thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot6thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot5thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot4thLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot3rdLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot2ndLevelMaximum = new System.Windows.Forms.TextBox();
			this.tbxSpellSlot1stLevelMaximum = new System.Windows.Forms.TextBox();
			this.lblGeneral = new System.Windows.Forms.Label();
			this.lblHealthOf = new System.Windows.Forms.Label();
			this.tbxHealthMaximum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(9, 73);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// lblHealth
			// 
			this.lblHealth.AutoSize = true;
			this.lblHealth.Location = new System.Drawing.Point(9, 100);
			this.lblHealth.Name = "lblHealth";
			this.lblHealth.Size = new System.Drawing.Size(38, 13);
			this.lblHealth.TabIndex = 1;
			this.lblHealth.Text = "Health";
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(60, 70);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(66, 20);
			this.tbxName.TabIndex = 0;
			// 
			// tbxHealthCurrent
			// 
			this.tbxHealthCurrent.Location = new System.Drawing.Point(60, 96);
			this.tbxHealthCurrent.Name = "tbxHealthCurrent";
			this.tbxHealthCurrent.Size = new System.Drawing.Size(30, 20);
			this.tbxHealthCurrent.TabIndex = 1;
			this.tbxHealthCurrent.Leave += new System.EventHandler(this.tbxHealthCurrent_Leave);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(160, 189);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.Location = new System.Drawing.Point(170, 224);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(35, 13);
			this.lblFeedback.TabIndex = 7;
			this.lblFeedback.Text = "label1";
			this.lblFeedback.Visible = false;
			// 
			// lblRations
			// 
			this.lblRations.AutoSize = true;
			this.lblRations.Location = new System.Drawing.Point(9, 125);
			this.lblRations.Name = "lblRations";
			this.lblRations.Size = new System.Drawing.Size(43, 13);
			this.lblRations.TabIndex = 8;
			this.lblRations.Text = "Rations";
			// 
			// tbxRations
			// 
			this.tbxRations.Location = new System.Drawing.Point(60, 122);
			this.tbxRations.Name = "tbxRations";
			this.tbxRations.Size = new System.Drawing.Size(45, 20);
			this.tbxRations.TabIndex = 2;
			// 
			// lblSpellSlots
			// 
			this.lblSpellSlots.AutoSize = true;
			this.lblSpellSlots.Location = new System.Drawing.Point(230, 24);
			this.lblSpellSlots.Name = "lblSpellSlots";
			this.lblSpellSlots.Size = new System.Drawing.Size(130, 13);
			this.lblSpellSlots.TabIndex = 10;
			this.lblSpellSlots.Text = "Spell Slots (Current / Max)";
			// 
			// lblSpellSlotFirstLevel
			// 
			this.lblSpellSlotFirstLevel.AutoSize = true;
			this.lblSpellSlotFirstLevel.Location = new System.Drawing.Point(199, 54);
			this.lblSpellSlotFirstLevel.Name = "lblSpellSlotFirstLevel";
			this.lblSpellSlotFirstLevel.Size = new System.Drawing.Size(50, 13);
			this.lblSpellSlotFirstLevel.TabIndex = 11;
			this.lblSpellSlotFirstLevel.Text = "1st Level";
			// 
			// lblSpellSlotSecondLevel
			// 
			this.lblSpellSlotSecondLevel.AutoSize = true;
			this.lblSpellSlotSecondLevel.Location = new System.Drawing.Point(198, 92);
			this.lblSpellSlotSecondLevel.Name = "lblSpellSlotSecondLevel";
			this.lblSpellSlotSecondLevel.Size = new System.Drawing.Size(54, 13);
			this.lblSpellSlotSecondLevel.TabIndex = 12;
			this.lblSpellSlotSecondLevel.Text = "2nd Level";
			// 
			// lblSpellSlotThirdLevel
			// 
			this.lblSpellSlotThirdLevel.AutoSize = true;
			this.lblSpellSlotThirdLevel.Location = new System.Drawing.Point(198, 132);
			this.lblSpellSlotThirdLevel.Name = "lblSpellSlotThirdLevel";
			this.lblSpellSlotThirdLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotThirdLevel.TabIndex = 13;
			this.lblSpellSlotThirdLevel.Text = "3rd Level";
			// 
			// lblSpellSlotFourthLevel
			// 
			this.lblSpellSlotFourthLevel.AutoSize = true;
			this.lblSpellSlotFourthLevel.Location = new System.Drawing.Point(268, 54);
			this.lblSpellSlotFourthLevel.Name = "lblSpellSlotFourthLevel";
			this.lblSpellSlotFourthLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotFourthLevel.TabIndex = 14;
			this.lblSpellSlotFourthLevel.Text = "4th Level";
			// 
			// lblSpellSlotFifthLevel
			// 
			this.lblSpellSlotFifthLevel.AutoSize = true;
			this.lblSpellSlotFifthLevel.Location = new System.Drawing.Point(268, 93);
			this.lblSpellSlotFifthLevel.Name = "lblSpellSlotFifthLevel";
			this.lblSpellSlotFifthLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotFifthLevel.TabIndex = 15;
			this.lblSpellSlotFifthLevel.Text = "5th Level";
			// 
			// lblSpellSlotSixthLevel
			// 
			this.lblSpellSlotSixthLevel.AutoSize = true;
			this.lblSpellSlotSixthLevel.Location = new System.Drawing.Point(268, 131);
			this.lblSpellSlotSixthLevel.Name = "lblSpellSlotSixthLevel";
			this.lblSpellSlotSixthLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotSixthLevel.TabIndex = 16;
			this.lblSpellSlotSixthLevel.Text = "6th Level";
			// 
			// lblSpellSlotSeventhLevel
			// 
			this.lblSpellSlotSeventhLevel.AutoSize = true;
			this.lblSpellSlotSeventhLevel.Location = new System.Drawing.Point(337, 54);
			this.lblSpellSlotSeventhLevel.Name = "lblSpellSlotSeventhLevel";
			this.lblSpellSlotSeventhLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotSeventhLevel.TabIndex = 17;
			this.lblSpellSlotSeventhLevel.Text = "7th Level";
			// 
			// lblSpellSlotEigthLevel
			// 
			this.lblSpellSlotEigthLevel.AutoSize = true;
			this.lblSpellSlotEigthLevel.Location = new System.Drawing.Point(337, 93);
			this.lblSpellSlotEigthLevel.Name = "lblSpellSlotEigthLevel";
			this.lblSpellSlotEigthLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotEigthLevel.TabIndex = 18;
			this.lblSpellSlotEigthLevel.Text = "8th Level";
			// 
			// lblSpellSlotNinthLevel
			// 
			this.lblSpellSlotNinthLevel.AutoSize = true;
			this.lblSpellSlotNinthLevel.Location = new System.Drawing.Point(337, 132);
			this.lblSpellSlotNinthLevel.Name = "lblSpellSlotNinthLevel";
			this.lblSpellSlotNinthLevel.Size = new System.Drawing.Size(51, 13);
			this.lblSpellSlotNinthLevel.TabIndex = 19;
			this.lblSpellSlotNinthLevel.Text = "9th Level";
			// 
			// tbxSpellSlot1stLevelCurrent
			// 
			this.tbxSpellSlot1stLevelCurrent.Location = new System.Drawing.Point(201, 70);
			this.tbxSpellSlot1stLevelCurrent.Name = "tbxSpellSlot1stLevelCurrent";
			this.tbxSpellSlot1stLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot1stLevelCurrent.TabIndex = 5;
			this.tbxSpellSlot1stLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot1stLevelCurrent_Leave);
			// 
			// tbxSpellSlot2ndLevelCurrent
			// 
			this.tbxSpellSlot2ndLevelCurrent.Location = new System.Drawing.Point(201, 109);
			this.tbxSpellSlot2ndLevelCurrent.Name = "tbxSpellSlot2ndLevelCurrent";
			this.tbxSpellSlot2ndLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot2ndLevelCurrent.TabIndex = 6;
			this.tbxSpellSlot2ndLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot2ndLevelCurrent_Leave);
			// 
			// tbxSpellSlot3rdLevelCurrent
			// 
			this.tbxSpellSlot3rdLevelCurrent.Location = new System.Drawing.Point(201, 148);
			this.tbxSpellSlot3rdLevelCurrent.Name = "tbxSpellSlot3rdLevelCurrent";
			this.tbxSpellSlot3rdLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot3rdLevelCurrent.TabIndex = 7;
			this.tbxSpellSlot3rdLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot3rdLevelCurrent_Leave);
			// 
			// tbxSpellSlot4thLevelCurrent
			// 
			this.tbxSpellSlot4thLevelCurrent.Location = new System.Drawing.Point(271, 70);
			this.tbxSpellSlot4thLevelCurrent.Name = "tbxSpellSlot4thLevelCurrent";
			this.tbxSpellSlot4thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot4thLevelCurrent.TabIndex = 8;
			this.tbxSpellSlot4thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot4thLevelCurrent_Leave);
			// 
			// tbxSpellSlot5thLevelCurrent
			// 
			this.tbxSpellSlot5thLevelCurrent.Location = new System.Drawing.Point(271, 109);
			this.tbxSpellSlot5thLevelCurrent.Name = "tbxSpellSlot5thLevelCurrent";
			this.tbxSpellSlot5thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot5thLevelCurrent.TabIndex = 9;
			this.tbxSpellSlot5thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot5thLevelCurrent_Leave);
			// 
			// tbxSpellSlot6thLevelCurrent
			// 
			this.tbxSpellSlot6thLevelCurrent.Location = new System.Drawing.Point(271, 148);
			this.tbxSpellSlot6thLevelCurrent.Name = "tbxSpellSlot6thLevelCurrent";
			this.tbxSpellSlot6thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot6thLevelCurrent.TabIndex = 10;
			this.tbxSpellSlot6thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot6thLevelCurrent_Leave);
			// 
			// tbxSpellSlot7thLevelCurrent
			// 
			this.tbxSpellSlot7thLevelCurrent.Location = new System.Drawing.Point(340, 70);
			this.tbxSpellSlot7thLevelCurrent.Name = "tbxSpellSlot7thLevelCurrent";
			this.tbxSpellSlot7thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot7thLevelCurrent.TabIndex = 11;
			this.tbxSpellSlot7thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot7thLevelCurrent_Leave);
			// 
			// tbxSpellSlot8thLevelCurrent
			// 
			this.tbxSpellSlot8thLevelCurrent.Location = new System.Drawing.Point(340, 109);
			this.tbxSpellSlot8thLevelCurrent.Name = "tbxSpellSlot8thLevelCurrent";
			this.tbxSpellSlot8thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot8thLevelCurrent.TabIndex = 12;
			this.tbxSpellSlot8thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot8thLevelCurrent_Leave);
			// 
			// tbxSpellSlot9thLevelCurrent
			// 
			this.tbxSpellSlot9thLevelCurrent.Location = new System.Drawing.Point(340, 148);
			this.tbxSpellSlot9thLevelCurrent.Name = "tbxSpellSlot9thLevelCurrent";
			this.tbxSpellSlot9thLevelCurrent.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot9thLevelCurrent.TabIndex = 13;
			this.tbxSpellSlot9thLevelCurrent.Leave += new System.EventHandler(this.tbxSpellSlot9thLevelCurrent_Leave);
			// 
			// lblGold
			// 
			this.lblGold.AutoSize = true;
			this.lblGold.Location = new System.Drawing.Point(10, 151);
			this.lblGold.Name = "lblGold";
			this.lblGold.Size = new System.Drawing.Size(29, 13);
			this.lblGold.TabIndex = 20;
			this.lblGold.Text = "Gold";
			// 
			// tbxGold
			// 
			this.tbxGold.Location = new System.Drawing.Point(60, 148);
			this.tbxGold.Name = "tbxGold";
			this.tbxGold.Size = new System.Drawing.Size(45, 20);
			this.tbxGold.TabIndex = 3;
			// 
			// tbxSpellSlot9thLevelMaximum
			// 
			this.tbxSpellSlot9thLevelMaximum.Location = new System.Drawing.Point(368, 148);
			this.tbxSpellSlot9thLevelMaximum.Name = "tbxSpellSlot9thLevelMaximum";
			this.tbxSpellSlot9thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot9thLevelMaximum.TabIndex = 29;
			this.tbxSpellSlot9thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot8thLevelMaximum
			// 
			this.tbxSpellSlot8thLevelMaximum.Location = new System.Drawing.Point(368, 109);
			this.tbxSpellSlot8thLevelMaximum.Name = "tbxSpellSlot8thLevelMaximum";
			this.tbxSpellSlot8thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot8thLevelMaximum.TabIndex = 28;
			this.tbxSpellSlot8thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot7thLevelMaximum
			// 
			this.tbxSpellSlot7thLevelMaximum.Location = new System.Drawing.Point(368, 70);
			this.tbxSpellSlot7thLevelMaximum.Name = "tbxSpellSlot7thLevelMaximum";
			this.tbxSpellSlot7thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot7thLevelMaximum.TabIndex = 27;
			this.tbxSpellSlot7thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot6thLevelMaximum
			// 
			this.tbxSpellSlot6thLevelMaximum.Location = new System.Drawing.Point(299, 148);
			this.tbxSpellSlot6thLevelMaximum.Name = "tbxSpellSlot6thLevelMaximum";
			this.tbxSpellSlot6thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot6thLevelMaximum.TabIndex = 26;
			this.tbxSpellSlot6thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot5thLevelMaximum
			// 
			this.tbxSpellSlot5thLevelMaximum.Location = new System.Drawing.Point(299, 109);
			this.tbxSpellSlot5thLevelMaximum.Name = "tbxSpellSlot5thLevelMaximum";
			this.tbxSpellSlot5thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot5thLevelMaximum.TabIndex = 25;
			this.tbxSpellSlot5thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot4thLevelMaximum
			// 
			this.tbxSpellSlot4thLevelMaximum.Location = new System.Drawing.Point(299, 70);
			this.tbxSpellSlot4thLevelMaximum.Name = "tbxSpellSlot4thLevelMaximum";
			this.tbxSpellSlot4thLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot4thLevelMaximum.TabIndex = 24;
			this.tbxSpellSlot4thLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot3rdLevelMaximum
			// 
			this.tbxSpellSlot3rdLevelMaximum.Location = new System.Drawing.Point(229, 148);
			this.tbxSpellSlot3rdLevelMaximum.Name = "tbxSpellSlot3rdLevelMaximum";
			this.tbxSpellSlot3rdLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot3rdLevelMaximum.TabIndex = 23;
			this.tbxSpellSlot3rdLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot2ndLevelMaximum
			// 
			this.tbxSpellSlot2ndLevelMaximum.Location = new System.Drawing.Point(229, 109);
			this.tbxSpellSlot2ndLevelMaximum.Name = "tbxSpellSlot2ndLevelMaximum";
			this.tbxSpellSlot2ndLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot2ndLevelMaximum.TabIndex = 22;
			this.tbxSpellSlot2ndLevelMaximum.TabStop = false;
			// 
			// tbxSpellSlot1stLevelMaximum
			// 
			this.tbxSpellSlot1stLevelMaximum.Location = new System.Drawing.Point(229, 70);
			this.tbxSpellSlot1stLevelMaximum.Name = "tbxSpellSlot1stLevelMaximum";
			this.tbxSpellSlot1stLevelMaximum.Size = new System.Drawing.Size(20, 20);
			this.tbxSpellSlot1stLevelMaximum.TabIndex = 21;
			this.tbxSpellSlot1stLevelMaximum.TabStop = false;
			// 
			// lblGeneral
			// 
			this.lblGeneral.AutoSize = true;
			this.lblGeneral.Location = new System.Drawing.Point(57, 24);
			this.lblGeneral.Name = "lblGeneral";
			this.lblGeneral.Size = new System.Drawing.Size(44, 13);
			this.lblGeneral.TabIndex = 30;
			this.lblGeneral.Text = "General";
			// 
			// lblHealthOf
			// 
			this.lblHealthOf.AutoSize = true;
			this.lblHealthOf.Location = new System.Drawing.Point(92, 99);
			this.lblHealthOf.Name = "lblHealthOf";
			this.lblHealthOf.Size = new System.Drawing.Size(16, 13);
			this.lblHealthOf.TabIndex = 31;
			this.lblHealthOf.Text = "of";
			// 
			// tbxHealthMaximum
			// 
			this.tbxHealthMaximum.Location = new System.Drawing.Point(110, 96);
			this.tbxHealthMaximum.Name = "tbxHealthMaximum";
			this.tbxHealthMaximum.Size = new System.Drawing.Size(30, 20);
			this.tbxHealthMaximum.TabIndex = 32;
			this.tbxHealthMaximum.TabStop = false;
			// 
			// FormAddPartyCharacter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 260);
			this.Controls.Add(this.tbxHealthMaximum);
			this.Controls.Add(this.lblHealthOf);
			this.Controls.Add(this.lblGeneral);
			this.Controls.Add(this.tbxSpellSlot9thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot8thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot7thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot6thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot5thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot4thLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot3rdLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot2ndLevelMaximum);
			this.Controls.Add(this.tbxSpellSlot1stLevelMaximum);
			this.Controls.Add(this.tbxGold);
			this.Controls.Add(this.lblGold);
			this.Controls.Add(this.tbxSpellSlot9thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot8thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot7thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot6thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot5thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot4thLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot3rdLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot2ndLevelCurrent);
			this.Controls.Add(this.tbxSpellSlot1stLevelCurrent);
			this.Controls.Add(this.lblSpellSlotNinthLevel);
			this.Controls.Add(this.lblSpellSlotEigthLevel);
			this.Controls.Add(this.lblSpellSlotSeventhLevel);
			this.Controls.Add(this.lblSpellSlotSixthLevel);
			this.Controls.Add(this.lblSpellSlotFifthLevel);
			this.Controls.Add(this.lblSpellSlotFourthLevel);
			this.Controls.Add(this.lblSpellSlotThirdLevel);
			this.Controls.Add(this.lblSpellSlotSecondLevel);
			this.Controls.Add(this.lblSpellSlotFirstLevel);
			this.Controls.Add(this.lblSpellSlots);
			this.Controls.Add(this.tbxRations);
			this.Controls.Add(this.lblRations);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbxHealthCurrent);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.lblHealth);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormAddPartyCharacter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Party Characters";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxHealthCurrent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblRations;
        private System.Windows.Forms.TextBox tbxRations;
        private System.Windows.Forms.Label lblSpellSlots;
        private System.Windows.Forms.Label lblSpellSlotFirstLevel;
        private System.Windows.Forms.Label lblSpellSlotSecondLevel;
        private System.Windows.Forms.Label lblSpellSlotThirdLevel;
        private System.Windows.Forms.Label lblSpellSlotFourthLevel;
        private System.Windows.Forms.Label lblSpellSlotFifthLevel;
        private System.Windows.Forms.Label lblSpellSlotSixthLevel;
        private System.Windows.Forms.Label lblSpellSlotSeventhLevel;
        private System.Windows.Forms.Label lblSpellSlotEigthLevel;
        private System.Windows.Forms.Label lblSpellSlotNinthLevel;
        private System.Windows.Forms.TextBox tbxSpellSlot1stLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot2ndLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot3rdLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot4thLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot5thLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot6thLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot7thLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot8thLevelCurrent;
        private System.Windows.Forms.TextBox tbxSpellSlot9thLevelCurrent;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.TextBox tbxGold;
		private System.Windows.Forms.TextBox tbxSpellSlot9thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot8thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot7thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot6thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot5thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot4thLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot3rdLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot2ndLevelMaximum;
		private System.Windows.Forms.TextBox tbxSpellSlot1stLevelMaximum;
		private System.Windows.Forms.Label lblGeneral;
		private System.Windows.Forms.Label lblHealthOf;
		private System.Windows.Forms.TextBox tbxHealthMaximum;
	}
}

