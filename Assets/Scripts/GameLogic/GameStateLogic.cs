using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class GameStateLogic: MonoBehaviour {

        GameStateData gameStateData;

        void Awake() {
            gameStateData = this.gameObject.GetComponent<GameStateData>();
        }

        void Update() {
            if (gameStateData.LivingEnemies == 0) {
                SetIsCanLoadNextLevel();
            }
        }

        public void SetLivingEnemies(int enemies) {
            gameStateData.LivingEnemies = enemies;
        }

        public void IncreaseLivingEnemies(int enemy) {
            gameStateData.LivingEnemies += enemy;
        }

        public void ReduceLivingEnemies(int enemy) {
            gameStateData.LivingEnemies -= enemy;
        }

        void SetIsCanLoadNextLevel() {
            gameStateData.IsCanLoadNextLevel = true;
        }

        public void SetPause() {
            gameStateData.Pause = true;
        }
    }
}
