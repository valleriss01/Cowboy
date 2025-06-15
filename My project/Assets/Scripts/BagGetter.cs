using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BagGetter : MonoBehaviour
{
    public GameObject JoyStickMove_Obj;
    public int BagCounter = 0;
    int Score = 0;
    [SerializeField] TextMeshProUGUI ScoreText;
    public bool Stunned = false;
    float StunnTimerCount = 0f; float MaxStunnTimer = 0.9f;
    [SerializeField] GameObject TheMeshok;
    [SerializeField] Slider BagSlider;

    [SerializeField] AudioClip WrongSound;
    [SerializeField] AudioClip GetBagSound;
    [SerializeField] AudioClip HorseCollision;
    [SerializeField] AudioClip BagsThrow;
    [SerializeField] AudioClip WinSound;

    int LevelNumber = 1;
    [SerializeField] Text LevelNumberText;

    int BagGoal = 10;
    public int GetLevelNumber()
    {
        return LevelNumber;
    }

    public void NextLevel()
    {
        LevelNumber++;
        //LevelNumberText.text = "У Р О В Е Н Ь  " + LevelNumber.ToString();
        PlayerPrefs.SetInt("LevelNumberSave", LevelNumber); //сохранение

    }

    public void NewGameScore()
    {
        Score = 0;
        ScoreText.text = "Счёт: " + Score.ToString() + " / " + BagGoal.ToString();
        BagCounter = 0;
        transform.Find("BagCouner").GetComponent<TextMeshPro>().text = BagCounter.ToString();
        JoyStickMove_Obj.GetComponent<JoyStick01>().DefaultSpeed();
    }


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Bag")
        {
            BagSlider.gameObject.SetActive(true);
            BagSlider.value += Time.deltaTime;
            if (BagSlider.value >= BagSlider.maxValue)
            {
                JoyStickMove_Obj.GetComponent<JoyStick01>().MinusSpeed();
                BagCounter++;
                GetComponent<AudioSource>().clip = GetBagSound;
                GetComponent<AudioSource>().Play();
                BagSlider.maxValue = BagCounter + 1;
                transform.Find("BagCouner").GetComponent<TextMeshPro>().text = BagCounter.ToString();
                BagSlider.value = 0;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bag")
        {
            BagSlider.gameObject.SetActive(false);
            BagSlider.value = 0;
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "КладиМешокСюда")
        {
            if (BagCounter == 0)
            {
                GetComponent<AudioSource>().clip = WrongSound;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                GetComponent<AudioSource>().clip = BagsThrow;
                GetComponent<AudioSource>().Play();
            }

            //очки прибавлять
            for (int i = 0; i < BagCounter; i++)
            {
                Score += 1;
                ScoreText.text = "Счёт: " + Score.ToString() + " / " + BagGoal.ToString();
                JoyStickMove_Obj.GetComponent<JoyStick01>().PlusSpeed();
            }
            if (Score >= BagGoal)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Pobeda();
                GetComponent<AudioSource>().clip = WinSound;
                GetComponent<AudioSource>().Play();
                NextLevel();
            }
            BagCounter = 0;
            transform.Find("BagCouner").GetComponent<TextMeshPro>().text = BagCounter.ToString();
            BagSlider.maxValue = 1;
            BagSlider.value = 0;
        }

        if (other.gameObject.tag == "horse")
        {
            //Debug.Log("лошадь =(");
            StunnTimerCount = MaxStunnTimer; //запуск таймера стана
            GetComponent<AudioSource>().clip = HorseCollision;
            GetComponent<AudioSource>().Play();

            for (int i = 0; i < BagCounter; i++)
            {
                GameObject NewMeshok = Instantiate(TheMeshok, transform);
                NewMeshok.AddComponent<Rigidbody>();
                NewMeshok.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-300, 300), 400, Random.Range(-300, 300)));
                NewMeshok.transform.SetParent(transform.parent);
                NewMeshok.transform.localScale = Vector3.one * 0.3f;
                JoyStickMove_Obj.GetComponent<JoyStick01>().PlusSpeed();
                BagCounter--;
                BagSlider.maxValue = BagCounter + 1;
                transform.Find("BagCouner").GetComponent<TextMeshPro>().text = BagCounter.ToString();
                break;
            }


        }
    }

    public void StunnScheck()
    {
        if (StunnTimerCount > 0)
        {
            Stunned = true;
            StunnTimerCount -= Time.deltaTime;
        }
        else
        {
            Stunned = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        if (PlayerPrefs.HasKey("LevelNumberSave"))
        {
            LevelNumber = PlayerPrefs.GetInt("LevelNumberSave");
        }
        else
        {
            LevelNumber = 1;
        }
        LevelNumberText.text = "У Р О В Е Н Ь  " + LevelNumber.ToString();
        if (LevelNumber <= 10)
        {
            BagGoal = LevelNumber;
        }
        else
        {
            if (LevelNumber % 10 == 0)
            {
                BagGoal = 15;
            }
            else if (LevelNumber % 10 == 1)
            {
                BagGoal = 5;
            }
            else
            {
                BagGoal = 10;
            }
        }
        ScoreText.text = "Счёт: " + Score.ToString() + " / " + BagGoal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        StunnScheck();
        TheMeshok.transform.localScale = Vector3.one * Mathf.Pow(BagCounter, 1.0f / 3.0f);

        if (Input.GetKeyDown(KeyCode.L))
        {
            LevelNumber = 1;
            LevelNumberText.text = "У Р О В Е Н Ь  " + LevelNumber.ToString();
            ScoreText.text = "Счёт: " + Score.ToString() + " / " + BagGoal.ToString();
        }
    }
}
