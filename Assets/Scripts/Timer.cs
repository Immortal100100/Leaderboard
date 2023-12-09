using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timer = 0;
    public TMP_Text TimeText;
    bool over = false;
    public string level_number;
    private void Update()
    {
        if (!over)
        {
            timer += Time.deltaTime;
            
                float minutes = Mathf.FloorToInt(timer / 60);
                float seconds = Mathf.FloorToInt(timer % 60);
                TimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
        }
    }

    public void GameOver()
    {
        int Score = 10 * Mathf.FloorToInt(timer);
        over = true;
        PlayerPrefs.SetInt("Score" + level_number,Score);
        SceneManager.LoadScene("Leaderboard");
    }

}
