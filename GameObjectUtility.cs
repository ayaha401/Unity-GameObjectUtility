using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AyahaGraphicDevelopTools
{
    public static class GameObjectUtility
    {
        /// <summary>
        /// Scene上の親オブジェクトを全部返す
        /// </summary>
        public static GameObject[] GetSceneRootGameObjects()
        {
            var activeScene = SceneManager.GetActiveScene();
            return activeScene.GetRootGameObjects();
        }

        /// <summary>
        /// 空のGameObjectを作成する
        /// </summary>
        /// <param name="objName">オブジェクト名前</param>
        /// <param name="attachComponentTypes">アタッチするコンポーネント</param>
        public static GameObject CreateEmptyGameObject(string objName, Type[] attachComponentTypes = null)
        {
            var emptyObj = new GameObject(objName);

            if (attachComponentTypes != null)
            {
                foreach (var type in attachComponentTypes)
                {
                    emptyObj.AddComponent(type);
                }
            }

            return emptyObj;
        }
    }
}
