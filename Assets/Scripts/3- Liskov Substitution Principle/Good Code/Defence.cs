using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class Defence : IFootball,IDefend,IAssist,IShoot
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Defence(string playerName)
        {
            PlayerName = playerName;
        }
        public void Assist()
        {
            Debug.Log("Defans assist yapıyor..");
        }

        public void Defend()
        {
            Debug.Log("Defans defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Defans koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Defans şut çekiyor.");
        }

    }
}
