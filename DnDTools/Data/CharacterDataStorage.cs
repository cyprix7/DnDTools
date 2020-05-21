using DnDTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools
{
    public class CharacterDataStorage
    {
        private int _idPartyCounter = 1;
        private int _idEnemyCounter = 1;
        public  List<CharacterParty> PartyCharacters = new List<CharacterParty>();
        public List<CharacterEnemy> EnemyCharacters = new List<CharacterEnemy>();

        public void CreatePartyCharacter(CharacterParty partyCharacter)
        {
            partyCharacter.Id = _idPartyCounter;
            _idPartyCounter++;

            PartyCharacters.Add(partyCharacter);
        }
        public void CreateEnemyCharacter(CharacterEnemy enemyCharacter)
        {
            enemyCharacter.Id = _idEnemyCounter;
            _idEnemyCounter++;

            EnemyCharacters.Add(enemyCharacter);
        }

    }
}
