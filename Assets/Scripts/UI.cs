using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}