using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubMove : MonoBehaviour
{
    public GameObject JoyStick;
    public GameObject Stick;
    public GameObject Hero;
    Vector2 Directory;
    float speed = 10.0f;
    public GameObject Camera;
    public GameObject OgrableniePanel;
    public GameObject CastomPanel;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ograblenie")
        {
            OgrableniePanel.SetActive(true);
        }
        if (other.gameObject.name == "Castom")
        {
            CastomPanel.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Ograblenie")
        {
            OgrableniePanel.SetActive(false);
        }
        if (other.gameObject.name == "Castom")
        {
            CastomPanel.SetActive(false);
        }
    }

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
        if (Input.GetMouseButton(0))
        {
            Hero.transform.GetChild(0).GetComponent<Animator>().Play("RunForward");
        }
        else
        {
            Hero.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
        }
    }


    public void JoyStickControll()
    {
        Camera.transform.position = Hero.transform.position + new Vector3(0, 6, -5);
        if (Input.GetMouseButton(0))
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

