using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class FootballManager : MonoBehaviour
    {
        private List<IFootball> _footballPlayers;
        [SerializeField]private int _footballPlayerId;
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
            _footballPlayers[_footballPlayerId].TakeTheBall();
            _footballPlayers[_footballPlayerId].Defend();
            _footballPlayers[_footballPlayerId].Assist();
            _footballPlayers[_footballPlayerId].Shoot();
        }

    }
}