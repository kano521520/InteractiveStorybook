using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    // 专用方法 - 直接跳转到Scene2A
    public void LoadScene2A()
    {
        SceneManager.LoadScene("Scene2A");
    }
}