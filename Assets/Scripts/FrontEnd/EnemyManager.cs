using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class EnemyManager : MonoBehaviour {

    public int health;
    public string type;
    public int dps;

    EnemyLogic enemyLogic;
    EnemyData enemyData;
    PlayerData playerData;
    GameStateData gameStateData;

    void Awake() {
        enemyLogic = this.gameObject.GetComponent<EnemyLogic>();
        enemyData = this.gameObject.GetComponent<EnemyData>();
        playerData = GameObject.Find("Player").GetComponent<PlayerData>();
        gameStateData = GameObject.Find("GameState").GetComponent<GameStateData>();
    }

    // Use this for initialization
    void Start () {
        enemyLogic.SetEnemyHealth(health);
        enemyLogic.SetEnemyType(type);
        enemyLogic.SetEnemyDPS(dps);

        WaitForSeconds delay = new WaitForSeconds(1f);
        StartCoroutine(enemyLogic.CauseDamageCoroutine(delay));
    }
	
	// Update is called once per frame
	void Update () {
        if (enemyData.isDead) {
            Destroy(this.gameObject);

        }
	}

    void OnMouseDown() {
        if (gameStateData.Pause != true) {
            if (enemyData.Type.Equals(playerData.ActiveWeapon)) {
                enemyLogic.RecieveDamage(35);
            } else {
                enemyLogic.RecieveDamage(20);
            }
        }        
    }
}
