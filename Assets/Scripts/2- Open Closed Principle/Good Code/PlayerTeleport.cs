using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public class PlayerTeleport : MonoBehaviour
    {
        private BaseTeleportPoint _teleportPointToGo;

  
        private void Awake()
        {
            _teleportPointToGo = GetComponent<BaseTeleportPoint>();
        }
        private void Start()
        {
            GetTeleportPoint(_teleportPointToGo);
        }

        private void GetTeleportPoint(BaseTeleportPoint teleportPointToGo)
        {
            if (teleportPointToGo!=null)
            {
                transform.position = teleportPointToGo.teleportPoint;
                teleportPointToGo.WriteTeleportPoint();

            }
            else
            {
                Debug.Log("Herhangi bir bölge bulunamadı!");
            }
            
            
        }
    }

}
