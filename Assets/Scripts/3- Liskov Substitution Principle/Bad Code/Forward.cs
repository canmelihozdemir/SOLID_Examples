using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class Forward : IFootball
    {
        public void Assist()
        {
            Debug.Log("Forvet assist yapıyor..");
        }

        public void Defend()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            Debug.Log("Forvet koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Forvet şut çekiyor.");
        }

        public void TakeTheBall()
        {
            throw new System.NotImplementedException();
        }
    }
}