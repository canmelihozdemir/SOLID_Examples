using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Liskov_Substitution_Principle.Good_Code
{
    public interface IFootball
    {
        string PlayerName { get; set; }
        void Run();
    }
}