using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts {
    public class EnemyData: MonoBehaviour {
        public int Health { get; set; }

        public string Type { get; set; }

        public int DPS { get; set; }

        public bool isDead = false;

    }
}
