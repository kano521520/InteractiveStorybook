using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadScene2B(string Scene2B)
    {
        SceneManager.LoadScene("Scene2B");
    }
}