using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class FootballManager : MonoBehaviour
    {
        private List<IFootball> _footballPlayers;

        public FootballManager()
        {
            InitializeFootballPlayers();
        }

        private void InitializeFootballPlayers()
        {
            _footballPlayers = new List<IFootball>();
            _footballPlayers.Add(new GoalKeeper());
            _footballPlayers.Add(new Defence());
            _footballPlayers.Add(new Midfield());
            _footballPlayers.Add(new Forward());
        }

        private void Start()
        {
            ShootTarget();      
        }

        private void ShootTarget()
        {
            _footballPlayers.ForEach(players =>
            {
                if (!(players is GoalKeeper))
                {
                    players.Shoot();
                }
            });
        }
    }
}