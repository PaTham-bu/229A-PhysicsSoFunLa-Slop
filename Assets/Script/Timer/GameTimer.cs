using UnityEngine;
using TMPro; // if using TextMeshPro

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float timeElapsed = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (!isRunning) return;

        timeElapsed += Time.deltaTime;

        UpdateUI();
    }

    void UpdateUI()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }


    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetTime()
    {
        return timeElapsed;
    }
}