using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class EnemiesLogic: MonoBehaviour {

        int quantityNotEmptyPosition;

        EnemiesData enemiesData;

        void Awake() {
            enemiesData = this.gameObject.GetComponent<EnemiesData>();
        }

        List<int> NotEmptyPosition { get; set; }
        public Dictionary<int, int> TempEnemiesInPosition { get; set; }


        EnemiesLogic() {
            NotEmptyPosition = new List<int>();
            TempEnemiesInPosition = new Dictionary<int, int>();
        }



        void GenerateNotEmptyPosition() {
            
            int valueOfNullCell = 0;
            for (int i = 0; i < 5; i++) {
                quantityNotEmptyPosition = UnityEngine.Random.Range(0, 4);
                if (quantityNotEmptyPosition == 0) {
                    valueOfNullCell++;
                }

                if (valueOfNullCell != 4) {
                    NotEmptyPosition.Add(quantityNotEmptyPosition);
                } else {
                    quantityNotEmptyPosition = UnityEngine.Random.Range(1, 4);
                    NotEmptyPosition.Add(quantityNotEmptyPosition);
                }
                
            }
            GameObject.Find("GameState").GetComponent<GameStateLogic>().SetLivingEnemies(5 - valueOfNullCell);

        }

        public void GenerateEnemiesInPosition() {
              
            int i = 0;
            GenerateNotEmptyPosition();
            foreach (KeyValuePair<int, int> entry in enemiesData.EnemiesInPosition) {
                
                TempEnemiesInPosition.Add(entry.Key, NotEmptyPosition[i]);
                i++;
            }

            enemiesData.EnemiesInPosition = TempEnemiesInPosition;
        }
    }
}
