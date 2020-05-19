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
    public partial class FormMain : Form
    {
        int _currentCharacter = 0;
        public static CharacterDataStorage DataStorage = new CharacterDataStorage();

        public FormMain()
        {
            InitializeComponent();
            new FormAddPartyCharacter().ShowDialog();

            // Check if characters in partychar list   
            if (DataStorage.PartyCharacters.Any())
            {
                RefreshComboBox();
                SetComboBoxDefault();
                RefreshStats(_currentCharacter);
            }
            else
                Close();
        }

        // FORM FUNCTIONS //

        private void RefreshComboBox()
        {
            cbxStatsSelectCharacter.Items.Clear();

            foreach (Character i in DataStorage.PartyCharacters)
            {
                cbxStatsSelectCharacter.Items.Add(i.Name);
            }
        }

        private void SetComboBoxDefault()
        {
            cbxStatsSelectCharacter.SelectedIndex = _currentCharacter;
            _currentCharacter = cbxStatsSelectCharacter.SelectedIndex;
        }

        private void RefreshStats(int currentCharacter)
        {
            CharacterParty character = DataStorage.PartyCharacters[_currentCharacter];

            // Basic stuff
            lblStatsValueName.Text = character.Name;
            lblStatsValueStatus.Text = character.Status.ToString();

            lblStatsValueHealth.Text = character.Health.ToString();
            lblStatsValueRations.Text = character.Rations.ToString();
            lblStatsValueGold.Text = character.Gold.ToString();

            // Death Saves
            lblStatsValueDeathSavesSuccesses.Text = $"{character.DeathSavingThrowSuccess} / 3";
            lblStatsValueDeathSavesFailures.Text = $"{character.DeathSavingThrowFailure} / 3";

            // Spell Slots
            lblStatsValueSpellSlot1stLevel.Text = character.SpellSlots1stLevel.ToString();
            lblStatsValueSpellSlot2ndLevel.Text = character.SpellSlots2ndLevel.ToString();
            lblStatsValueSpellSlot3rdLevel.Text = character.SpellSlots3rdLevel.ToString();
            lblStatsValueSpellSlot4thLevel.Text = character.SpellSlots4thLevel.ToString();
            lblStatsValueSpellSlot5thLevel.Text = character.SpellSlots5thLevel.ToString();
            lblStatsValueSpellSlot6thLevel.Text = character.SpellSlots6thLevel.ToString();
            lblStatsValueSpellSlot7thLevel.Text = character.SpellSlots7thLevel.ToString();
            lblStatsValueSpellSlot8thLevel.Text = character.SpellSlots8thLevel.ToString();
            lblStatsValueSpellSlot9thLevel.Text = character.SpellSlots9thLevel.ToString();
        }

        // EVENTS //

        private void cbxSelectPartyCharacter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _currentCharacter = cbxStatsSelectCharacter.SelectedIndex;
            RefreshStats(_currentCharacter);
        }

        private void btnCreatePartyCharacter_Click(object sender, EventArgs e)
        {
            new FormAddPartyCharacter().ShowDialog();
            RefreshComboBox();
            SetComboBoxDefault();
        }

        private void btnStatsDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (DataStorage.PartyCharacters.Count > 1)
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to delete {DataStorage.PartyCharacters[_currentCharacter].Name}?", "Confirm Remove Character", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DataStorage.PartyCharacters.RemoveAt(_currentCharacter);
                    _currentCharacter = 0;
                    RefreshComboBox();
                    SetComboBoxDefault();
                    RefreshStats(_currentCharacter);
                }
            }
            else
                MessageBox.Show("You cannot remove the only party character.", "Error");    
        }

        private void cbxSetStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataStorage.PartyCharacters[_currentCharacter].Status = (Character.StatusTypes)cbxStatsSetStatus.SelectedIndex;
            cbxStatsSetStatus.Visible = false;
            RefreshStats(_currentCharacter);
        }

        private void lblValueStatus_Click(object sender, EventArgs e)
        {
            cbxStatsSetStatus.Items.Clear();
            foreach (var en in Enum.GetValues(typeof(Character.StatusTypes)))
            {
                cbxStatsSetStatus.Items.Add(en);
            }
            cbxStatsSetStatus.SelectedIndex = (int)DataStorage.PartyCharacters[_currentCharacter].Status;
            cbxStatsSetStatus.Visible = true;
            cbxStatsSetStatus.Focus();
        }

        private void lblValueHealth_Click(object sender, EventArgs e)
        {
            FormController.TbxHide(this, "tbxStatsSet");
            tbxStatsSetHealth.Visible = true;
            tbxStatsSetHealth.Text = DataStorage.PartyCharacters[_currentCharacter].Health.ToString();
            tbxStatsSetHealth.Focus();
        }

        private void lblValueRations_Click(object sender, EventArgs e)
        {
            FormController.TbxHide(this, "tbxStatsSet");
            tbxStatsSetRations.Visible = true;
            tbxStatsSetRations.Text = DataStorage.PartyCharacters[_currentCharacter].Rations.ToString();
            tbxStatsSetRations.Focus();
        }

        private void lblValueGold_Click(object sender, EventArgs e)
        {
            FormController.TbxHide(this, "tbxStatsSet");
            tbxStatsSetGold.Visible = true;
            tbxStatsSetGold.Text = DataStorage.PartyCharacters[_currentCharacter].Gold.ToString();
            tbxStatsSetGold.Focus();
        }

        private void btnSetHealth_Click(object sender, EventArgs e)
        {
            if (tbxStatsSetHealth.Text != "")
            {
                DataStorage.PartyCharacters[_currentCharacter].Health = Validation.CheckIfValidInt(tbxStatsSetHealth.Text.ToString());
                FormController.TbxClear(this, "tbxStatsSet");
                tbxStatsSetHealth.Visible = false;
                RefreshStats(_currentCharacter);
            }
        }

        private void btnSetRations_Click(object sender, EventArgs e)
        {
            if (tbxStatsSetRations.Text != "")
            {
                DataStorage.PartyCharacters[_currentCharacter].Rations = Validation.CheckIfValidInt(tbxStatsSetRations.Text.ToString());
                FormController.TbxClear(this, "tbxStatsSet");
                tbxStatsSetRations.Visible = false;
                RefreshStats(_currentCharacter);
            }
        }

        private void btnSetGold_Click(object sender, EventArgs e)
        {
            if (tbxStatsSetGold.Text != "")
            {
                DataStorage.PartyCharacters[_currentCharacter].Gold = Validation.CheckIfValidInt(tbxStatsSetGold.Text.ToString());
                FormController.TbxClear(this, "tbxStatsSet");
                tbxStatsSetGold.Visible = false;
                RefreshStats(_currentCharacter);
            }
        }

        private void btnStatsDeathSavesAddSuccess_Click(object sender, EventArgs e)
        {
            if (DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowSuccess < 3)
            {
                DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowSuccess++;
                RefreshStats(_currentCharacter);
            }
        }

        private void btnStatsDeathSavesAddFailure_Click(object sender, EventArgs e)
        {
            if (DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowFailure < 3)
            {
                DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowFailure++;
                RefreshStats(_currentCharacter);
            }
        }

        private void btnStatsDeathSavesResetSuccess_Click(object sender, EventArgs e)
        {
            DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowSuccess = 0;
            RefreshStats(_currentCharacter);
        }

        private void btnStatsDeathSavesResetFailure_Click(object sender, EventArgs e)
        {
            DataStorage.PartyCharacters[_currentCharacter].DeathSavingThrowFailure = 0;
            RefreshStats(_currentCharacter);
        }

        private void lblStatsValueSpellSlot1stLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot2ndLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot3rdLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot4thLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot5thLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot6thLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot7thLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot8thLevel_Click(object sender, EventArgs e)
        {

        }

        private void lblStatsValueSpellSlot9thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots1stLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots2ndLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots3rdLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots4thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots5thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots6thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots7thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots8thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSetSpellSlots9thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast1stLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast2ndLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast3rdLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast4thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast5thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast6thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast7thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast8thLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnStatsSpellSlotsCast9thLevel_Click(object sender, EventArgs e)
        {

        }
    }    
}
