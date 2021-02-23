using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID_Examples.Single_Responsibility_Principle.Good_Code
{
    public class SceneManager : MonoBehaviour
    {

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


    }
}