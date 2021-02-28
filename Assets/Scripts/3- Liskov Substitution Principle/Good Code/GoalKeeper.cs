using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class GoalKeeper : IFootball,ITakeTheBall,IDefend
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName=value; }
        public GoalKeeper(string playerName)
        {
            PlayerName = playerName;
        }

        public void Defend()
        {
            Debug.Log("Kaleci defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Kaleci koşuyor..");
        }

        public void TakeTheBall()
        {
            Debug.Log("Kaleci topu eline alıyor..");
        }
    }
}