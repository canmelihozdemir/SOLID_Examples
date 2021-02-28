using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public class Defence : IFootball
    {
        public void Assist()
        {
            Debug.Log("Defans assist yapıyor..");
        }

        public void Defend()
        {
            Debug.Log("Defans defans yapıyor..");
        }

        public void Run()
        {
            Debug.Log("Defans koşuyor..");
        }

        public void Shoot()
        {
            Debug.Log("Defans şut çekiyor.");
        }

        public void TakeTheBall()
        {
            throw new System.NotImplementedException();
        }
    }
}
