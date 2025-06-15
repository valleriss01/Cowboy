using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    float TimerValue = 10;
    float MaxLevelTime = 90;
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] GameObject LosePanel;
    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject Hero;

    [SerializeField] AudioClip GameMusic;
    [SerializeField] AudioClip PauseMusic;

    public void Pobeda()
    {
        WinPanel.SetActive(true);
        GetComponent<AudioSource>().clip = PauseMusic;
        GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
    }
    public void Porazenie()
    {
        LosePanel.SetActive(true);
        GetComponent<AudioSource>().clip = PauseMusic;
        GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
    }
    public void NewGame()
    {
        TimerValue = MaxLevelTime;
        if (TimerValue > 9.5f)
        {
            TimerText.text =  System.Convert.ToInt32(TimerValue).ToString();
        }
        else
        {
            TimerText.text = "0" + System.Convert.ToInt32(TimerValue).ToString();
        }
        Hero.GetComponent<BagGetter>().NewGameScore();
        Hero.transform.position = Vector3.zero;
    }
    public void Timer_Running()
    {
        TimerValue -= Time.deltaTime;
        if (TimerValue > 9.5f)
        {
            TimerText.text = System.Convert.ToInt32(TimerValue).ToString();
        }
        else
        {
            TimerText.text = "0" + System.Convert.ToInt32(TimerValue).ToString();
        }
        if (TimerValue <= 0)
        {
            Porazenie();
        }
    }

    public void ADContinue()
    {
        TimerValue = 30;
        LosePanel.SetActive(false);
        GetComponent<AudioSource>().clip = GameMusic;
        GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        TimerValue = MaxLevelTime;
        if (TimerValue > 9.5f)
        {
            TimerText.text = System.Convert.ToInt32(TimerValue % 60).ToString();
        }
        else
        {
            TimerText.text = "0" + System.Convert.ToInt32(TimerValue % 60).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(LosePanel.activeSelf == false)
        {
            Timer_Running();
        }
    }
}