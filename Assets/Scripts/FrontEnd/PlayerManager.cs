using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class PlayerManager: MonoBehaviour {
        public Text countOfKilledEnemies;
        public Text healthText;

        int health = 100;

        PlayerData playerData;
        PlayerLogic playerLogic;

        void Awake() {
            playerData = this.gameObject.GetComponent<PlayerData>();
            playerLogic = GameObject.Find("Player").GetComponent<PlayerLogic>();
            
            //playerLogic.SetHealth(health);
        }

        void Update () {
            if (!countOfKilledEnemies.text.Equals(playerData.CountOfKilledEnemies.ToString())) {
                countOfKilledEnemies.text = playerData.CountOfKilledEnemies.ToString();
            }
            if (!healthText.text.Equals(playerData.Health.ToString())) {
                healthText.text = playerData.Health.ToString();
            }
        }
    }
}
