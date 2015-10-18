using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class PlayerLogic : MonoBehaviour {

        PlayerData playerData;

        void Awake() {
            playerData = GameObject.Find("Player").GetComponent<PlayerData>();            
        }

        void Start() {
            SetHealth(100);
        }

        public void SetHealth(int health) {
           playerData.Health = health;
        }

        public void SetActiveWeapon(string weapon) {
            playerData.ActiveWeapon = weapon;
        }

        public void IncreaseCountOfKilledEnemies(int count) {
            playerData.CountOfKilledEnemies += count;
        }
    }
}
