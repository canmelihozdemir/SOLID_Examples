using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public class FootballManager : MonoBehaviour
    {
        private List<IGoalKeeper> _goalKeeperPlayers;
        private List<IDefence> _defencePlayers;
        private List<IMidfield> _midfieldPlayers;
        private List<IForward> _forwardPlayers;
        public FootballManager()
        {
            InitializeFootballPlayers();
        }

        private void InitializeFootballPlayers()
        {
            _goalKeeperPlayers = new List<IGoalKeeper>();
            _defencePlayers = new List<IDefence>();
            _midfieldPlayers = new List<IMidfield>();
            _forwardPlayers = new List<IForward>();

            AddGoalKeeper(new GoalKeeper("Mehmet"));
            AddDefence(new Defence("Sevgi"));
            AddMidfield(new Midfield("Okan"));
            AddMidfield(new Midfield("Eda"));
            AddMidfield(new Midfield("Recai"));
            AddForward(new Forward("Gizem"));
            
        }

        private void AddGoalKeeper(GoalKeeper goalKeeper)
        {
            _goalKeeperPlayers.Add(goalKeeper);
        }
        private void AddDefence(Defence defence)
        {
            _defencePlayers.Add(defence);
        }
        private void AddMidfield(Midfield midfield)
        {
            _midfieldPlayers.Add(midfield);
        }
        private void AddForward(Forward forward)
        {
            _forwardPlayers.Add(forward);
        }

        private void Start()
        {
            //Defence();
            //Shoot();
            //TakeTheBall();
            Assist();
        }
        private void Defence()
        {
            _defencePlayers.ForEach(defencePlayer =>
                {
                    defencePlayer.Defend();
                    defencePlayer.Assist();
                    defencePlayer.Run();
                    defencePlayer.Shoot();
                    defencePlayer.Walk();
                }
            );
        }
        private void Shoot()
        {
            _forwardPlayers.ForEach(forwardPlayer =>
            {
                forwardPlayer.Run();
                forwardPlayer.Assist();
                forwardPlayer.Shoot();
                forwardPlayer.Walk();
            }
            );
        }
        private void Assist()
        {
            _midfieldPlayers.ForEach(midfieldPlayer =>
            {
                midfieldPlayer.Assist();
                midfieldPlayer.Defend();
                midfieldPlayer.Run();
                midfieldPlayer.Shoot();
                midfieldPlayer.Walk();
            }
            );
        }
       
        private void TakeTheBall()
        {
            _goalKeeperPlayers.ForEach(goalKeeperPlayer =>
            {
                goalKeeperPlayer.Defend();
                goalKeeperPlayer.Run();
                goalKeeperPlayer.TakeTheBall();
                goalKeeperPlayer.Walk();
            }
            );
        }
    }
}