using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Bad_Code
{
    public class PlayerTeleport : MonoBehaviour
    {

        private void Start()
        {
            GetTeleportPoint();
        }

        private void GetTeleportPoint()
        {
            if (GetComponent<ArcherTeleportPoint>()!=null)
            {
                transform.position = GetComponent<ArcherTeleportPoint>().TeleportPoint;
                Debug.Log("Oyuncu A noktasına ışınlandı");
            }
            else if (GetComponent<WarriorTeleportPoint>() != null)
            {
                transform.position = GetComponent<WarriorTeleportPoint>().TeleportPoint;
                Debug.Log("Oyuncu B noktasına ışınlandı");
            }
            else if (GetComponent<MagicTeleportPoint>() != null)
            {
                transform.position = GetComponent<MagicTeleportPoint>().TeleportPoint;
                Debug.Log("Oyuncu C noktasına ışınlandı");
            }
            else
            {
                Debug.Log("Herhangi bir bölge bulunamadı!");
            }
            
        }
    }

}
