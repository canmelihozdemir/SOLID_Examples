﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class Midfield : IFootball,IDefend,IAssist,IShoot
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Midfield(string playerName)
        {
            PlayerName = playerName;
        }
        public void Assist()
        {
            Debug.Log("Orta saha assist yapıyor..");
        }

        public void Defend()
        {
            Debug.Log("Orta saha defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Orta saha koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Orta saha şut çekiyor.");
        }


    }
}
