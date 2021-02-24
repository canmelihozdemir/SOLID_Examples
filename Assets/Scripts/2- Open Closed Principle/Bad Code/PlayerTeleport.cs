using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Open_Closed_Principle.Bad_Code
{
    public class PlayerTeleport : MonoBehaviour
    {
        [SerializeField] private Vector3 _teleportAPoint;
        [SerializeField] private Vector3 _teleportBPoint;
        [SerializeField] private Vector3 _teleportCPoint;
        [SerializeField] private string _teleportPointToGo;

        private void Start()
        {
            GetTeleportPoint(_teleportPointToGo);
        }

        private void GetTeleportPoint(string teleportPointToGo)
        {
            if (teleportPointToGo.Equals("A"))
            {
                transform.position = _teleportAPoint;
                Debug.Log("Oyuncu A noktasına ışınlandı");
            }
            else if (teleportPointToGo.Equals("B"))
            {
                transform.position = _teleportBPoint;
                Debug.Log("Oyuncu B noktasına ışınlandı");
            }
            else if (teleportPointToGo.Equals("C"))
            {
                transform.position = _teleportCPoint;
                Debug.Log("Oyuncu C noktasına ışınlandı");
            }
            else
            {
                Debug.Log(teleportPointToGo + " adında bir bölge bulunamadı!");
            }
            
        }
    }

}
