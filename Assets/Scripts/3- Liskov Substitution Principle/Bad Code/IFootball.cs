using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Bad_Code
{
    public interface IFootball
    {
        void Shoot();
        void Assist();
        void Run();
        void Defend();
        void TakeTheBall();
    }
}