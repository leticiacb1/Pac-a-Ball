using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class digitalClock : MonoBehaviour
{
    public float TimeLeft = 300.0f;
    public bool TimerOn = false;
    private int END_GAME_SCENE = 2;

    public TextMeshProUGUI TimerTxt;
   
    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Go to Game Over Screen");
                TimeLeft = 0;
                TimerOn = false;

                SceneManager.LoadScene(END_GAME_SCENE);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
