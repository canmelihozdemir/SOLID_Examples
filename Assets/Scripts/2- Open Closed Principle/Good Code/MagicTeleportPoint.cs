using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public class MagicTeleportPoint : BaseTeleportPoint
    {
        public MagicTeleportPoint()
        {
            teleportPoint = new Vector3(1f, 0.75f, 0f);
        }

        public override void WriteTeleportPoint()
        {
            Debug.Log("Oyuncu Büyücü bölgesine ışınlandı!");
        }
    }
}
