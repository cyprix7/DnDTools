using DnDTools.Controllers;
using DnDTools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDTools
{
    public partial class FormAddPartyCharacter : Form
    {
        public FormAddPartyCharacter()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CharacterParty partyCharacter = new CharacterParty();
            lblFeedback.Visible = false;

            if (tbxName.Text != "" && tbxHealth.Text != "")
            {
                partyCharacter.Name = tbxName.Text;
                partyCharacter.HealthCurrent = Validation.CheckIfValidInt(tbxHealth.Text);
                partyCharacter.Rations = Validation.CheckIfValidDouble(tbxRations.Text);
                partyCharacter.Gold = Validation.CheckIfValidInt(tbxGold.Text);

                partyCharacter.SpellSlots1stLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot1stLevel.Text);
                partyCharacter.SpellSlots2ndLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot2ndLevel.Text);
                partyCharacter.SpellSlots3rdLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot3rdLevel.Text);
                partyCharacter.SpellSlots4thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot4thLevel.Text);
                partyCharacter.SpellSlots5thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot5thLevel.Text);
                partyCharacter.SpellSlots6thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot6thLevel.Text);
                partyCharacter.SpellSlots7thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot7thLevel.Text);
                partyCharacter.SpellSlots8thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot8thLevel.Text);
                partyCharacter.SpellSlots9thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot9thLevel.Text);

                FormMain.DataStorage.CreatePartyCharacter(partyCharacter);

                
                lblFeedback.Visible = true;
                lblFeedback.Text = $"{tbxName.Text.ToString()} added!";
                FormController.TbxClear(this);
            }
            else
            {
                MessageBox.Show("You must enter at least a name and starting health.", "Error");
            }
        }

    }
}
