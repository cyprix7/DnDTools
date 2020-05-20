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

            if (tbxName.Text != "" && tbxHealthCurrent.Text != "")
            {
				#region Set properties
				partyCharacter.Name = tbxName.Text;
                partyCharacter.HealthCurrent = Validation.CheckIfValidInt(tbxHealthCurrent.Text);
                partyCharacter.HealthMaximum = Validation.CheckIfValidInt(tbxHealthMaximum.Text);
                partyCharacter.Rations = Validation.CheckIfValidDouble(tbxRations.Text);
                partyCharacter.Gold = Validation.CheckIfValidInt(tbxGold.Text);

                partyCharacter.SpellSlots1stLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot1stLevelCurrent.Text);
                partyCharacter.SpellSlots2ndLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot2ndLevelCurrent.Text);
                partyCharacter.SpellSlots3rdLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot3rdLevelCurrent.Text);
                partyCharacter.SpellSlots4thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot4thLevelCurrent.Text);
                partyCharacter.SpellSlots5thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot5thLevelCurrent.Text);
                partyCharacter.SpellSlots6thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot6thLevelCurrent.Text);
                partyCharacter.SpellSlots7thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot7thLevelCurrent.Text);
                partyCharacter.SpellSlots8thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot8thLevelCurrent.Text);
                partyCharacter.SpellSlots9thLevelCurrent = Validation.CheckIfValidInt(tbxSpellSlot9thLevelCurrent.Text);

                partyCharacter.SpellSlots1stLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot1stLevelMaximum.Text);
                partyCharacter.SpellSlots2ndLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot2ndLevelMaximum.Text);
                partyCharacter.SpellSlots3rdLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot3rdLevelMaximum.Text);
                partyCharacter.SpellSlots4thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot4thLevelMaximum.Text);
                partyCharacter.SpellSlots5thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot5thLevelMaximum.Text);
                partyCharacter.SpellSlots6thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot6thLevelMaximum.Text);
                partyCharacter.SpellSlots7thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot7thLevelMaximum.Text);
                partyCharacter.SpellSlots8thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot8thLevelMaximum.Text);
                partyCharacter.SpellSlots9thLevelMaximum = Validation.CheckIfValidInt(tbxSpellSlot9thLevelMaximum.Text);

				#endregion

				#region Check inputs
				if (!(partyCharacter.HealthCurrent <= 0))
                {
                    if (!(partyCharacter.HealthMaximum < partyCharacter.HealthCurrent))
                    {

                        if (!(partyCharacter.SpellSlots1stLevelMaximum < partyCharacter.SpellSlots1stLevelCurrent)
                            && !(partyCharacter.SpellSlots2ndLevelMaximum < partyCharacter.SpellSlots2ndLevelCurrent)
                            && !(partyCharacter.SpellSlots3rdLevelMaximum < partyCharacter.SpellSlots3rdLevelCurrent)
                            && !(partyCharacter.SpellSlots4thLevelMaximum < partyCharacter.SpellSlots4thLevelCurrent)
                            && !(partyCharacter.SpellSlots5thLevelMaximum < partyCharacter.SpellSlots5thLevelCurrent)
                            && !(partyCharacter.SpellSlots6thLevelMaximum < partyCharacter.SpellSlots6thLevelCurrent)
                            && !(partyCharacter.SpellSlots7thLevelMaximum < partyCharacter.SpellSlots7thLevelCurrent)
                            && !(partyCharacter.SpellSlots8thLevelMaximum < partyCharacter.SpellSlots8thLevelCurrent)
                            && !(partyCharacter.SpellSlots9thLevelMaximum < partyCharacter.SpellSlots9thLevelCurrent))
                        {
                            FormMain.DataStorage.CreatePartyCharacter(partyCharacter);

                            lblFeedback.Visible = true;
                            lblFeedback.Text = $"{tbxName.Text} added!";
                            FormController.TbxClear(this);
                        }
                        else
                        {
                            MessageBox.Show("Current spell slots cannot be greater than maximum spell slots.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current health cannot be greater than maximum health.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot have a character with 0 starting health or less.", "Error");
                }
            }
            else
            {
                MessageBox.Show("You must enter at least a name and starting health.", "Error");
            }

			#endregion
		}

		#region Events - Autofill
		private void tbxHealthCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxHealthCurrent.Text != "" && tbxHealthMaximum.Text == "")
            {
                tbxHealthMaximum.Text = tbxHealthCurrent.Text;
            }
        }

        private void tbxSpellSlot1stLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot1stLevelCurrent.Text != "" && tbxSpellSlot1stLevelMaximum.Text == "")
            {
                tbxSpellSlot1stLevelMaximum.Text = tbxSpellSlot1stLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot2ndLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot2ndLevelCurrent.Text != "" && tbxSpellSlot2ndLevelMaximum.Text == "")
            {
                tbxSpellSlot2ndLevelMaximum.Text = tbxSpellSlot2ndLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot3rdLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot3rdLevelCurrent.Text != "" && tbxSpellSlot3rdLevelMaximum.Text == "")
            {
                tbxSpellSlot3rdLevelMaximum.Text = tbxSpellSlot3rdLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot4thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot4thLevelCurrent.Text != "" && tbxSpellSlot4thLevelMaximum.Text == "")
            {
                tbxSpellSlot4thLevelMaximum.Text = tbxSpellSlot4thLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot5thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot5thLevelCurrent.Text != "" && tbxSpellSlot5thLevelMaximum.Text == "")
            {
                tbxSpellSlot5thLevelMaximum.Text = tbxSpellSlot5thLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot6thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot6thLevelCurrent.Text != "" && tbxSpellSlot6thLevelMaximum.Text == "")
            {
                tbxSpellSlot6thLevelMaximum.Text = tbxSpellSlot6thLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot7thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot7thLevelCurrent.Text != "" && tbxSpellSlot7thLevelMaximum.Text == "")
            {
                tbxSpellSlot7thLevelMaximum.Text = tbxSpellSlot7thLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot8thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot8thLevelCurrent.Text != "" && tbxSpellSlot8thLevelMaximum.Text == "")
            {
                tbxSpellSlot8thLevelMaximum.Text = tbxSpellSlot8thLevelCurrent.Text;
            }
        }

        private void tbxSpellSlot9thLevelCurrent_Leave(object sender, EventArgs e)
        {
            if (tbxSpellSlot9thLevelCurrent.Text != "" && tbxSpellSlot9thLevelMaximum.Text == "")
            {
                tbxSpellSlot9thLevelMaximum.Text = tbxSpellSlot9thLevelCurrent.Text;
            }
        }

		#endregion
	}
}
