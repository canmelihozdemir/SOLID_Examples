using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class GoalKeeper : IGoalKeeper
    {
        private string _playerName;
        public string PlayerName { get => _playerName; set => _playerName=value; }
        public GoalKeeper(string playerName)
        {
            PlayerName = playerName;
        }

        public void Defend()
        {
            Debug.Log(PlayerName + " adlı kaleci defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log(PlayerName+" adlı kaleci koşuyor..");
        }

        public void TakeTheBall()
        {
            Debug.Log(PlayerName + " adlı kaleci topu eline alıyor..");
        }

        public void Walk()
        {
            Debug.Log(PlayerName + " adlı kaleci yürüyor..");
        }
    }
}