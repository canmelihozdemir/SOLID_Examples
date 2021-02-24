using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Bad_Code
{
    public class ArcherTeleportPoint : MonoBehaviour
    {
        private Vector3 _teleportPoint;
        public ArcherTeleportPoint()
        {
            _teleportPoint = new Vector3(2f, 0.75f, 1f);
        }
        public Vector3 TeleportPoint { get => _teleportPoint; }

    }
}
