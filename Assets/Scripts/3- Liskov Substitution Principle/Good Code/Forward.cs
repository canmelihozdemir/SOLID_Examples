using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class Forward : IForward
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Forward(string playerName)
        {
            PlayerName = playerName;
        }
        public void Assist()
        {
            Debug.Log("Forvet oyuncusu " + PlayerName + " assist yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Forvet oyuncusu " + PlayerName + " koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Forvet oyuncusu " + PlayerName + " şut çekiyor..");
        }

        public void Walk()
        {
            Debug.Log("Forvet oyuncusu " + PlayerName + " yürüyor..");
        }
    }
}