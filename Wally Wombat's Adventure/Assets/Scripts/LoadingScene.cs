using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingScene : MonoBehaviour
{
    public void LoadScene(string leveltoLoad)
    {
        MMSceneLoadingManager.LoadScene(leveltoLoad);
    }
}