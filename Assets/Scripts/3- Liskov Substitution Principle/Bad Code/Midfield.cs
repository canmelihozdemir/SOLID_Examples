using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class Midfield : IFootball
    {
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

        public void TakeTheBall()
        {
            throw new System.NotImplementedException();
        }
    }
}
