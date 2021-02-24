using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public abstract class BaseTeleport:MonoBehaviour
    {
        public Vector3 teleportPoint { get; set; }
    }
}
