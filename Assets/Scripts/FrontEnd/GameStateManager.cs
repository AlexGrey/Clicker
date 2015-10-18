using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class GameStateManager: MonoBehaviour {

        public Button nextLevel;

        public Image losePanel;
        public Text text;
        public Button restart;

        GameStateData gameStateData;
        GameStateLogic gameStateLogic;
        PlayerData playerData;

        void Awake() {
            playerData = GameObject.Find("Player").GetComponent<PlayerData>();
            gameStateData = this.gameObject.GetComponent<GameStateData>();
            gameStateLogic = this.gameObject.GetComponent<GameStateLogic>();
        }

        void Update() {
            if (gameStateData.IsCanLoadNextLevel == true) {
                nextLevel.interactable = true;
            }

            if (playerData.Health <= 0) {
                Time.timeScale = 0;
                gameStateLogic.SetPause();
                losePanel.gameObject.SetActive(true);
            } else if (playerData.Health >= 0) {
                Time.timeScale = 1;
            }
        }
    }
}
