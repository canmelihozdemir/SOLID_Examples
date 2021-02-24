using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Good_Code
{
    public class PlayerTeleport : MonoBehaviour
    {
        private BaseTeleport _teleportPointToGo;

  
        private void Awake()
        {
            _teleportPointToGo = GetComponent<BaseTeleport>();
        }
        private void Start()
        {
            GetTeleportPoint(_teleportPointToGo);
        }

        private void GetTeleportPoint(BaseTeleport teleportPointToGo)
        {
            if (teleportPointToGo!=null)
            {
                transform.position = _teleportPointToGo.teleportPoint;
            }
            else
            {
                Debug.Log("Herhangi bir bölge bulunamadı!");
            }
            
            
        }
    }

}
