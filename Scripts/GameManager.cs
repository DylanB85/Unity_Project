using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text Time_Remaining;
    private CountdownTimer countDownTimer; //reference to countdown timer
    private int totalSeconds = 60;

    void Start()
    {
        countDownTimer = GetComponent<CountdownTimer>();//
        countDownTimer.ResetTimer(totalSeconds);//
    }

    void Update()
    {
        string msg = "" + countDownTimer.GetSecondsRemaining();
        Time_Remaining.text = msg;
        checkGameOver();
    }

    private void checkGameOver()
    {
        if(countDownTimer.GetSecondsRemaining()<0)
        {
            SceneManager.LoadScene("scene1_Over");
        }
    }
}