using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public class WarriorTeleportPoint : BaseTeleportPoint
    {
        public WarriorTeleportPoint()
        {
            teleportPoint = new Vector3(-2f, 0.75f, -1f);
        }

        public override void WriteTeleportPoint()
        {
            Debug.Log("Oyuncu Savaşçı bölgesine ışınlandı!");
        }
    }
}
