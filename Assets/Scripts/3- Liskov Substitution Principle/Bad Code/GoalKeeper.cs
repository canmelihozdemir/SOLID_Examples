using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class GoalKeeper : IFootball
    {
        public void Assist()
        {
            throw new System.NotImplementedException();
        }

        public void Defend()
        {
            Debug.Log("Kaleci defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Kaleci koşuyor..");
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public void TakeTheBall()
        {
            Debug.Log("Kaleci topu eline alıyor..");
        }
    }
}