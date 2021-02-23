using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Single_Responsibility_Principle.Good_Code
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


    }
}