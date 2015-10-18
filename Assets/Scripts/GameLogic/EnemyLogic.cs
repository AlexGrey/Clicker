using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Assets.Scripts {
    public class EnemyLogic: MonoBehaviour {
        EnemyData enemyData;
        GameStateLogic gameStateLogic;


        PlayerData playerData;
        PlayerLogic playerLogic;

        void Awake() {
            playerData = GameObject.Find("Player").GetComponent<PlayerData>();
            playerLogic = GameObject.Find("Player").GetComponent<PlayerLogic>();
            enemyData = this.gameObject.GetComponent<EnemyData>();
            gameStateLogic = GameObject.Find("GameState").GetComponent<GameStateLogic>();
        }

        void Start() {
            
           
        }

        public void SetEnemyHealth(int health) {
            enemyData.Health = health;
        }

        public void SetEnemyType(string type) {
            enemyData.Type = type;
        }

        public void SetEnemyDPS(int dps) {
            enemyData.DPS = dps;
        }

        public void RecieveDamage(int damage) {
            enemyData.Health -= damage;

            if (enemyData.Health <= 0) {
                SetIsDead();
                gameStateLogic.ReduceLivingEnemies(1);
                playerLogic.IncreaseCountOfKilledEnemies(1);
            }             
        }

        public void CauseDamage() {
            playerData.Health -= enemyData.DPS;
        }

        void SetIsDead() {
            enemyData.isDead = true;
        }

        public IEnumerator CauseDamageCoroutine(WaitForSeconds delay) {
            while (true) {
                CauseDamage();                
                yield return delay;
           }
        }
    }
}
