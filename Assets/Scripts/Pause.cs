using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    private bool pause;
    public GameObject PauseMenu;
    public AudioSource Audio;

    void Start() {
        pause = false;
        PauseMenu = GameObject.Find("PauseCanvas");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            pause = !pause;
        }
        if (pause) {
            Time.timeScale = 0;
            PauseMenu.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (!pause) {
            Time.timeScale = 1;
            PauseMenu.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    
    public void Continue() {
        pause = !pause;
    }

    public void MusicToggle() {
        Audio.enabled = !Audio.enabled;
    }
}