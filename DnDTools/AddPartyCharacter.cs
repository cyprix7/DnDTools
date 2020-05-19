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
                partyCharacter.Health = Validation.CheckIfValidInt(tbxHealth.Text);
                partyCharacter.Rations = Validation.CheckIfValidDouble(tbxRations.Text);
                partyCharacter.Gold = Validation.CheckIfValidInt(tbxGold.Text);

                partyCharacter.SpellSlots1stLevel = Validation.CheckIfValidInt(tbxSpellSlot1stLevel.Text);
                partyCharacter.SpellSlots2ndLevel = Validation.CheckIfValidInt(tbxSpellSlot2ndLevel.Text);
                partyCharacter.SpellSlots3rdLevel = Validation.CheckIfValidInt(tbxSpellSlot3rdLevel.Text);
                partyCharacter.SpellSlots4thLevel = Validation.CheckIfValidInt(tbxSpellSlot4thLevel.Text);
                partyCharacter.SpellSlots5thLevel = Validation.CheckIfValidInt(tbxSpellSlot5thLevel.Text);
                partyCharacter.SpellSlots6thLevel = Validation.CheckIfValidInt(tbxSpellSlot6thLevel.Text);
                partyCharacter.SpellSlots7thLevel = Validation.CheckIfValidInt(tbxSpellSlot7thLevel.Text);
                partyCharacter.SpellSlots8thLevel = Validation.CheckIfValidInt(tbxSpellSlot8thLevel.Text);
                partyCharacter.SpellSlots9thLevel = Validation.CheckIfValidInt(tbxSpellSlot9thLevel.Text);

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
