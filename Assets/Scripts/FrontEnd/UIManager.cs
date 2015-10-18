using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class UIManager : MonoBehaviour {
    Sprite[] sprite;

    PlayerData playerData;
    PlayerLogic playerLogic;

    InventoryData inventoryData;
    InventoryLogic inventoryLogic;

    // Use this for initialization
    void Start () {
        sprite = Resources.LoadAll<Sprite>("InventoryIcons");
        ChangeInventorySprite("1");
        playerLogic.SetActiveWeapon("red");
    }

    void Awake () {
        inventoryData = this.gameObject.GetComponent<InventoryData>();
        inventoryLogic = this.gameObject.GetComponent<InventoryLogic>();
        playerData = GameObject.Find("Player").GetComponent<PlayerData>();
        playerLogic = GameObject.Find("Player").GetComponent<PlayerLogic>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("1")) {
            inventoryLogic.SetActiveWeapon(1);
            ChangeInventorySprite(inventoryData.Value);
        } else if (Input.GetKeyDown("2")) {
            inventoryLogic.SetActiveWeapon(2);
            ChangeInventorySprite(inventoryData.Value);
        } else if (Input.GetKeyDown("3")) {
            inventoryLogic.SetActiveWeapon(3);
            ChangeInventorySprite(inventoryData.Value);
        }
	}

    public void StartNewGame() {
        Application.LoadLevel("Game");
    }

    public void ShowRecordsTable() {
        Debug.Log("UIManager.ShowRecordsTable is locked");
    }

    public void ExitGame() {
        Debug.Log("UIManager.ExitGame is locked");
    }

    public void ToNextLevel() {
        Application.LoadLevel("Game");
        playerData.SaveValue();
    }

    public void RestartLevel() {
        Application.LoadLevel("Game");
        playerData.SetNullValue();
    }

    void OnApplicationQuit() {
        playerData.SetNullValue();
    }

    public void ChangeInventorySprite(string number) {
        if (number.Equals("1")) {
            SetWeaponInventorySprite("FirstWeapon", 3);
            SetWeaponInventorySprite("SecondWeapon", 1);
            SetWeaponInventorySprite("ThirdWeapon", 2);
        }
        else if (number.Equals("2")) {
            SetWeaponInventorySprite("FirstWeapon", 0);
            SetWeaponInventorySprite("SecondWeapon", 4);
            SetWeaponInventorySprite("ThirdWeapon", 2);
        } 
        else if (number.Equals("3")) {
            SetWeaponInventorySprite("FirstWeapon", 0);
            SetWeaponInventorySprite("SecondWeapon", 1);
            SetWeaponInventorySprite("ThirdWeapon", 5);
        }
    }

    void SetWeaponInventorySprite(string weaponObj, int numOfSprite) {
        GameObject.Find(weaponObj).GetComponent<Image>().sprite = sprite[numOfSprite];
    }

}
