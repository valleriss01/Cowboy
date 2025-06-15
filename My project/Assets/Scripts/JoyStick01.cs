using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick01 : MonoBehaviour
{
    public GameObject JoyStick;
    public GameObject Stick;
    public GameObject Hero;
    Vector2 Directory;
    float speed = 10.0f;

    public void PlusSpeed()
    {
            speed *= 1.3f;
    }
    public void MinusSpeed()
    {
            speed /= 1.3f;
    }
    public void DefaultSpeed()
    {
        speed = 7.0f;
    }
    public void AnimationController()
    {
        if (Hero.GetComponent<BagGetter>().Stunned == true)
        {
            Hero.transform.GetChild(0).GetComponent<Animator>().Play("RollBackward");
        }
        else if (Input.GetMouseButton(0))
        {
            if (Hero.GetComponent<BagGetter>().BagCounter < 5)
            {
                Hero.transform.GetChild(0).GetComponent<Animator>().Play("RunForward");
                Hero.transform.GetChild(0).GetComponent<Animator>().speed = 1 - Hero.GetComponent<BagGetter>().BagCounter / 8.0f;
            }
            else
            {
                Hero.transform.GetChild(0).GetComponent<Animator>().Play("Walk_F");
                Hero.transform.GetChild(0).GetComponent<Animator>().speed = 5.0f / Hero.GetComponent<BagGetter>().BagCounter;
            }
        }
        else
        {
            Hero.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
        }
    }


    public void JoyStickControll()
    {
        if (Input.GetMouseButton(0) && Hero.GetComponent<BagGetter>().Stunned == false)
        {
            Stick.GetComponent<RectTransform>().position = Input.mousePosition;
            if (Stick.GetComponent<RectTransform>().position.x < JoyStick.GetComponent<RectTransform>().position.x - JoyStick.GetComponent<RectTransform>().sizeDelta.x / 2)
            {
                Stick.GetComponent<RectTransform>().position = new Vector2(JoyStick.GetComponent<RectTransform>().position.x - JoyStick.GetComponent<RectTransform>().sizeDelta.x / 2, Stick.GetComponent<RectTransform>().position.y);
            }
            if (Stick.GetComponent<RectTransform>().position.x > JoyStick.GetComponent<RectTransform>().position.x + JoyStick.GetComponent<RectTransform>().sizeDelta.x / 2)
            {
                Stick.GetComponent<RectTransform>().position = new Vector2(JoyStick.GetComponent<RectTransform>().position.x + JoyStick.GetComponent<RectTransform>().sizeDelta.x / 2, Stick.GetComponent<RectTransform>().position.y);
            }

            if (Stick.GetComponent<RectTransform>().position.y < JoyStick.GetComponent<RectTransform>().position.y - JoyStick.GetComponent<RectTransform>().sizeDelta.y / 2)
            {
                Stick.GetComponent<RectTransform>().position = new Vector2(Stick.GetComponent<RectTransform>().position.x, JoyStick.GetComponent<RectTransform>().position.y - JoyStick.GetComponent<RectTransform>().sizeDelta.y / 2);
            }
            if (Stick.GetComponent<RectTransform>().position.y > JoyStick.GetComponent<RectTransform>().position.y + JoyStick.GetComponent<RectTransform>().sizeDelta.y / 2)
            {
                Stick.GetComponent<RectTransform>().position = new Vector2(Stick.GetComponent<RectTransform>().position.x, JoyStick.GetComponent<RectTransform>().position.y + JoyStick.GetComponent<RectTransform>().sizeDelta.y / 2);
            }
        }
        else
        {
            Stick.GetComponent<RectTransform>().position = JoyStick.GetComponent<RectTransform>().position;
        }
        Directory = Stick.GetComponent<RectTransform>().position - JoyStick.GetComponent<RectTransform>().position;
        Directory = Directory.normalized;

        Hero.transform.position = Hero.transform.position + new Vector3(Directory.x, 0, Directory.y) * speed * Time.deltaTime;

        Hero.transform.LookAt(new Vector3(Hero.transform.position.x + Directory.x, 0, Hero.transform.position.z + Directory.y));

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        JoyStickControll();
        AnimationController();

    }
}

