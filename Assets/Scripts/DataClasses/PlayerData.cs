using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Assets.Scripts {
    public class PlayerData : MonoBehaviour {
        //XmlDocument xDoc;

        public int Health { get; set; }
        public string ActiveWeapon { get; set; }
        public int CountOfKilledEnemies { get; set; }

        void Start() {
            //xDoc = new XmlDocument();
            LoadValue();
        }

        public void LoadValue() {

            /* xDoc.Load("Assets/Scripts/Data/Player.xml");
             // получим корневой элемент
             XmlElement xRoot = xDoc.DocumentElement;

             foreach (XmlNode xnode in xRoot) {
                 if (xnode.Name.Equals("CountOfKilledEnemies")) {
                     CountOfKilledEnemies = Convert.ToInt32(xnode.InnerText);
                 }

             }*/
            CountOfKilledEnemies = PlayerPrefs.GetInt("CountOfKilledEnemies");

        }

        public void SaveValue() {
            /*xDoc.Load("Assets/Scripts/Data/Player.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot) {
                if (xnode.Name.Equals("CountOfKilledEnemies")) {
                    xnode.InnerText = CountOfKilledEnemies.ToString();
                }

            }
            xDoc.Save("Assets/Scripts/Data/Player.xml");*/
            PlayerPrefs.SetInt("CountOfKilledEnemies", CountOfKilledEnemies);
        }

        public void SetNullValue() {
            /*xDoc.Load("Assets/Scripts/Data/Player.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot) {
                if (xnode.Name.Equals("CountOfKilledEnemies")) {
                    xnode.InnerText = "0";
                }

            }
            xDoc.Save("Assets/Scripts/Data/Player.xml");*/
            PlayerPrefs.SetInt("CountOfKilledEnemies", 0);
        }
    }
}
