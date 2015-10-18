using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class GameStateData : MonoBehaviour {


        void Start() {
            IsCanLoadNextLevel = false;
            Pause = false;
        }

        public int LivingEnemies { get; set; }
        public bool IsCanLoadNextLevel { get; set; }
        public bool Pause { get; set; }
    }
}
