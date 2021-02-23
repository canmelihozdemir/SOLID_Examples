using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Single_Responsibility_Principle.Good_Code
{
    public class LevelManager : MonoBehaviour
    {

        #region Seviye sistemi ile ilgili kodlar
        public int GetLevel(int playerName,int playerLevel)
        {
            Debug.Log(playerName + " adlı oyuncunun seviyesi "+playerLevel);
            return playerLevel;
        }
        public void SetLevel(int playerName, int playerLevel,int levelCount)
        {
            playerLevel += levelCount;
            Debug.Log(playerName + " adlı oyuncuya +"+levelCount+" level eklendi!");
        }
        #endregion

    }
}