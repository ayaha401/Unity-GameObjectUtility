using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AyahaGraphicDevelopTools
{
    public static class GameObjectUtility
    {
        /// <summary>
        /// Scene上の親オブジェクトを返す
        /// </summary>
        public static GameObject[] GetSceneRootGameObjects()
        {
            var activeScene = SceneManager.GetActiveScene();
            return activeScene.GetRootGameObjects();
        }
    }
}
