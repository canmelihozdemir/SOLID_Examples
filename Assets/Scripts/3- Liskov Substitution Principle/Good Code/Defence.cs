using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class Defence : IDefence
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Defence(string playerName)
        {
            PlayerName = playerName;
        }
        public void Assist()
        {
            Debug.Log("Defans oyuncusu " + PlayerName + " assist yapıyor..");
        }

        public void Defend()
        {
            Debug.Log("Defans oyuncusu " + PlayerName + " defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Defans oyuncusu " + PlayerName + " koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Defans oyuncusu " + PlayerName + " şut çekiyor.");
        }
        public void Walk()
        {
            Debug.Log("Defans oyuncusu " + PlayerName + " yürüyor..");
        }
    }
}
