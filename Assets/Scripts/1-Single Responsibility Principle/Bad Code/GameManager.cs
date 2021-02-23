using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Single_Responsibility_Principle.Bad_Code
{
    public class GameManager : MonoBehaviour
    {

        #region Oyun ile ilgili kodlar
        public void StartGame()
        {
            Debug.Log("Oyun Başladı!");
        }
        public void PauseGame()
        {
            Debug.Log("Oyun Durduruldu!");
        }
        public void ResumeGame()
        {
            Debug.Log("Oyun Devam Ediyor!");
        }
        public void EndGame()
        {
            Debug.Log("Oyun Bitti!");
        }
        #endregion



        #region Sahne ile ilgili kodlar
        public int GetScene(int sceneId)
        {
            Debug.Log(sceneId+" numaralı sahnedesiniz!");
            return sceneId;
        }
        public string GetSceneName(string sceneName)
        {
            Debug.Log(sceneName + " adlı sahnedesiniz!");
            return sceneName;
        }
        #endregion



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