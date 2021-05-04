using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public Text PointsDisplay;
    public Text LivesDisplay;
    public Text NameDisplay;
    public Text TimeDisplay;
    
    void Start()
    {
        Data.points = 0;
    }

    private void Update() {
        PointsDisplay.text = "Points: " + Data.points.ToString();
        LivesDisplay.text = "Lives: " + Data.lives.ToString();
        TimeDisplay.text = "Seconds left: " + Data.time.ToString("F2");
        NameDisplay.text = Data.playerName;

        Data.time = Data.time - Time.deltaTime;
        if (Data.time <= 0) {
            SceneManager.LoadScene("3Exit");
        }
    }

    public void IncreasePoints() {
        Data.points = Data.points + 1;
    }
    public void DecreasePoints() {
        Data.points = Data.points - 1;
    }
    public void IncreaseLives() {
        Data.lives = Data.lives + 1;
    }
    public void DecreaseLives() {
        Data.lives = Data.lives - 1;
    }
}
