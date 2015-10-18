using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class EnemiesManager: MonoBehaviour {

        EnemiesLogic enemiesLogic;
        EnemiesData enemiesData;

        void Awake() {
            enemiesLogic = this.gameObject.GetComponent<EnemiesLogic>();
            enemiesData = this.gameObject.GetComponent<EnemiesData>();
        }

        void Start() {
            enemiesLogic.GenerateEnemiesInPosition();

            foreach (KeyValuePair<int, int> entry in enemiesData.EnemiesInPosition) {
                Instaniate(entry.Key, entry.Value);
            }
        }

        void Instaniate(int cell, int typeOfEnemy) {
            if (cell == 1 && typeOfEnemy != 0) {
                GameObject instance = Instantiate(Resources.Load("Prefabs/" + ConvertTypeToGameObject(typeOfEnemy), typeof(GameObject))) as GameObject;
                instance.transform.position = new Vector3(-6f, 0f, 0f);                 
            } else if (cell == 2 && typeOfEnemy != 0) {
                GameObject instance = Instantiate(Resources.Load("Prefabs/" + ConvertTypeToGameObject(typeOfEnemy), typeof(GameObject))) as GameObject;
                instance.transform.position = new Vector3(-4f, 0f, 0f);
            } else if (cell == 3 && typeOfEnemy != 0) {
                GameObject instance = Instantiate(Resources.Load("Prefabs/" + ConvertTypeToGameObject(typeOfEnemy), typeof(GameObject))) as GameObject;
                instance.transform.position = new Vector3(-2f, 0f, 0f);
            } else if (cell == 4 && typeOfEnemy != 0) {
                GameObject instance = Instantiate(Resources.Load("Prefabs/" + ConvertTypeToGameObject(typeOfEnemy), typeof(GameObject))) as GameObject;
                instance.transform.position = new Vector3(0f, 0f, 0f);
            } else if (cell == 5 && typeOfEnemy != 0) {
                GameObject instance = Instantiate(Resources.Load("Prefabs/" + ConvertTypeToGameObject(typeOfEnemy), typeof(GameObject))) as GameObject;
                instance.transform.position = new Vector3(2f, 0f, 0f);
            }

        }

        string ConvertTypeToGameObject(int typeOfEnemy) {
            if (typeOfEnemy == 1) {
                return "Enemy1";
            } else if (typeOfEnemy == 2) {
                return "Enemy2";
            } else if (typeOfEnemy == 3) {
                return "Enemy3";
            } else {
                return null;
            }
        }

    }
}
