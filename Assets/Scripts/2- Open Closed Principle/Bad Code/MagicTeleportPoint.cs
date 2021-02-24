using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Bad_Code
{
    public class MagicTeleportPoint : MonoBehaviour
    {
        private Vector3 _teleportPoint;
        public MagicTeleportPoint()
        {
            _teleportPoint = new Vector3(1f, 0.75f, 0f);
        }
        public Vector3 TeleportPoint { get => _teleportPoint; }

    }
}
