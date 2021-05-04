using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene("2Game");
    }

    public void MenuReturn() {
        SceneManager.LoadScene("1Intro");
    }

    public void Credits() {
        SceneManager.LoadScene("3Exit");
    }

    public void QuitGame() {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}