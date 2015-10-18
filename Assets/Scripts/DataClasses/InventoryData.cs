using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Assets.Scripts {
    public class InventoryData : MonoBehaviour {
        //XmlDocument xDoc;

        public string Value { get; set; }

        void LoadValue() {
            /*string value = "";
            xDoc = new XmlDocument();
            xDoc.Load("Assets/Scripts/Data/Inventory.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot) {
                if (xnode.Name == "currentItem") {
                    value = xnode.InnerText;
                }
            }
            Value = value;*/
            Value = PlayerPrefs.GetString("InventoryData.Value");        
        }

        void SaveValue() {
            /*
            xDoc = new XmlDocument();
            xDoc.Load("Assets/Scripts/Data/Inventory.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot) {
                if (xnode.Name == "currentItem") {
                    xnode.InnerText = Value;
                }
            }
            xDoc.Save("Assets/Scripts/Data/Inventory.xml");*/
            PlayerPrefs.SetString("InventoryData.Value", Value);
        }
    }
}
