using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public abstract class BaseTeleportPoint:MonoBehaviour
    {
        public Vector3 teleportPoint { get; set; }
        public abstract void WriteTeleportPoint();
    }
}
