using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu1 : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
