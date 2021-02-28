using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class FootballManager : MonoBehaviour
    {
        private Dictionary<string,IFootball> _footballPlayers;
        private Dictionary<string, ITakeTheBall> _goalKeeper;
        private Dictionary<string, IDefend> _defence;
        private Dictionary<string, IAssist> _midfield;
        private Dictionary<string, IShoot> _forward;
        [SerializeField]private string _footballPlayerName;
        public FootballManager()
        {
            InitializeFootballPlayers();
        }

        private void InitializeFootballPlayers()
        {
            _footballPlayers = new Dictionary<string,IFootball>();
            _goalKeeper = new Dictionary<string, ITakeTheBall>();
            _defence = new Dictionary<string, IDefend>();
            _midfield = new Dictionary<string, IAssist>();
            _forward = new Dictionary<string, IShoot>();

            SetGoalKeeper(new GoalKeeper("Mehmet"));
            SetDefence(new Defence("Sevgi"));
            SetMidfield(new Midfield("Okan"));
            SetForward(new Forward("Gizem"));
            
        }

        private void SetGoalKeeper(GoalKeeper goalKeeper)
        {
            _footballPlayers.Add(goalKeeper.PlayerName,goalKeeper);
            _goalKeeper.Add(goalKeeper.PlayerName, goalKeeper);
            _defence.Add(goalKeeper.PlayerName, goalKeeper);
        }
        private void SetDefence(Defence defence)
        {
            _footballPlayers.Add(defence.PlayerName, defence);
            _midfield.Add(defence.PlayerName, defence);
            _defence.Add(defence.PlayerName, defence);
            _forward.Add(defence.PlayerName, defence);
        }
        private void SetMidfield(Midfield midfield)
        {
            _footballPlayers.Add(midfield.PlayerName, midfield);
            _midfield.Add(midfield.PlayerName, midfield);
            _defence.Add(midfield.PlayerName, midfield);
            _forward.Add(midfield.PlayerName, midfield);
        }
        private void SetForward(Forward forward)
        {
            _footballPlayers.Add(forward.PlayerName, forward);
            _midfield.Add(forward.PlayerName, forward);
            _forward.Add(forward.PlayerName, forward);
        }

        private void Start()
        {
            //RunForwardPlayer(_footballPlayerName);
            RunMidfieldPlayer(_footballPlayerName);
            //RunDefencePlayer(_footballPlayerName);
            //RunGoalKeeperPlayer(_footballPlayerName);
        }

        private void RunForwardPlayer(string footballPlayerName)
        {
            _footballPlayers[_footballPlayerName].Run();
            _midfield[_footballPlayerName].Assist();
            _forward[_footballPlayerName].Shoot();
        }
        private void RunMidfieldPlayer(string footballPlayerName)
        {
            _footballPlayers[_footballPlayerName].Run();
            _midfield[_footballPlayerName].Assist();
            _forward[_footballPlayerName].Shoot();
            _defence[_footballPlayerName].Defend();
        }
        private void RunDefencePlayer(string footballPlayerName)
        {
            _footballPlayers[_footballPlayerName].Run();
            _midfield[_footballPlayerName].Assist();
            _forward[_footballPlayerName].Shoot();
            _defence[_footballPlayerName].Defend();
        }
        private void RunGoalKeeperPlayer(string footballPlayerName)
        {
            _footballPlayers[_footballPlayerName].Run();
            _goalKeeper[_footballPlayerName].TakeTheBall();
            _defence[_footballPlayerName].Defend();
        }
    }
}