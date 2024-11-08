using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public event Action Quit;
    public event Action StartAnotherScene;

    public void StartScene(int sceneIndex)
    {
        StartAnotherScene?.Invoke();
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Quit?.Invoke();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
