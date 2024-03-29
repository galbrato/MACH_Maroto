﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script for main menu buttons
public class MenuButtonControl : MonoBehaviour {
    
    public void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("master_volume");
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void LoadOptions() {
        print("OPTIONS");
        SceneManager.LoadScene("Opcoes");
    }
    public void LoadCredits() {
        SceneManager.LoadScene("Creditos");
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void LoadGame() {
#if UNITY_EDITOR || UNITY_STANDALONE
        SceneManager.LoadScene("Jogo");
#elif UNITY_ANDROID
        SceneManager.LoadScene("PreJogo");
#endif
    }
}
