using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Xml;

namespace Assets.Scripts {
    public class EnemiesData: MonoBehaviour {
        XmlDocument xDoc;


        EnemiesData() {            
            EnemiesInPosition = new Dictionary<int, int>();
            EnemiesInPosition.Add(1, 0);
            EnemiesInPosition.Add(2, 0);
            EnemiesInPosition.Add(3, 0);
            EnemiesInPosition.Add(4, 0);
            EnemiesInPosition.Add(5, 0);
        }


        public Dictionary<int, int> EnemiesInPosition { get; set; }

        void LoadValue() {
            //later...
        }

        void SaveValue() {
            //later...
        }
    }
}
