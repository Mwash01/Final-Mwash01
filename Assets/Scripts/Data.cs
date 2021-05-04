using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    [SerializeField]
    public static int points;
    [SerializeField]
    public static int lives;
    [SerializeField]
    public static string playerName;
    [SerializeField]
    public static float time;

    public InputField NameInput;
    public Dropdown LivesDropdown;
    public Slider CountdownSlider;

    void Start()
    {
        time = 60f;
        lives = 1;
    }

    public void InputName() {
        playerName = NameInput.text;
    }

    public void ChangeLives() {
        switch(LivesDropdown.value) {
            case 0:
                lives = 1;
                break;
            case 1:
                lives = 2;
                break;
            case 2:
                lives = 3;
                break;
            case 3:
                lives = 4;
                break;
            case 4:
                lives = 5;
                break;
            case 5:
                lives = 6;
                break;
            case 6:
                lives = 7;
                break;
            case 7:
                lives = 8;
                break;
            case 8:
                lives = 9;
                break;
        }
    }

    public void ChangeTime() {
        time = CountdownSlider.value;
    }
}
