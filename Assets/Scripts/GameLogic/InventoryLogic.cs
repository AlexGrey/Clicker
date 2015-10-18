using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {

    public class InventoryLogic : MonoBehaviour {

        InventoryData inventoryData;
        PlayerLogic playerLogic;

        void Awake() {
            inventoryData = this.gameObject.GetComponent<InventoryData>();
            playerLogic = GameObject.Find("Player").GetComponent<PlayerLogic>();
        }

        public void SetActiveWeapon(int weaponNumber) {            
            inventoryData.Value = weaponNumber.ToString();
            if (weaponNumber == 1) {
                playerLogic.SetActiveWeapon("red");
            } else if (weaponNumber == 2) {
                playerLogic.SetActiveWeapon("blue");
            } else if (weaponNumber == 3) {
                playerLogic.SetActiveWeapon("yellow");
            }

        }
    }
}
