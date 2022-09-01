using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject nextLevelPanel;

    public static bool nextScene;


    private static UIManager instance;



    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        nextScene = false;
        nextLevelPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        LoadNextScene();
    }

    private void Update()
    {

        if (nextScene)
        {
            nextLevelPanel.SetActive(true);
        }
    }

}
