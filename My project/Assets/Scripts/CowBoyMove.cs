using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboymove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    //public void ControllMove()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        //gameObject.GetComponent<Transform>().Translate(0, 0, 0.01f); //GetComponent<Transform>() == transform
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //движение вперёд 1 метр в секунду
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Forward");
    //    }
    //    else
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
    //    }
    //}


    //public void WASDMove()
    //{
    //    if (Input.GetKey(KeyCode.W)) //если зажата клавиша W
    //    {
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //движение вперёд 1 метр в секунду
    //    }
    //    else if (Input.GetKey(KeyCode.S)) //если зажата клавиша S
    //    {
    //        transform.Translate(0, 0, -1.0f * Time.deltaTime); //движение вперёд 1 метр в секунду
    //    }
    //    if (Input.GetKey(KeyCode.A)) //если зажата клавиша A
    //    {
    //        transform.Translate(-1.0F * Time.deltaTime, 0, 0); //движение вперёд 1 метр в секунду
    //    }
    //    else if (Input.GetKey(KeyCode.D)) //если зажата клавиша D
    //    {
    //        transform.Translate(1 * Time.deltaTime, 0, 0); //движение вперёд 1 метр в секунду
    //    }

    //    if (Input.GetKey(KeyCode.W)) //если зажата клавиша W
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Forward");
    //    }
    //    else if (Input.GetKey(KeyCode.S)) //если зажата клавиша S
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Backward");
    //    }
    //    else if (Input.GetKey(KeyCode.A)) //если зажата клавиша A
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Left");
    //    }
    //    else if (Input.GetKey(KeyCode.D)) //если зажата клавиша D
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Right");
    //    }
    //    else
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
    //    }
    //}


    //public void RotateMove()
    //{
    //    if (Input.GetKey(KeyCode.W)) //если зажата клавиша W
    //    {
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //движение вперёд 1 метр в секунду
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Forward");
    //    }
    //    else
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.Rotate(0, -50 * Time.deltaTime, 0);
    //    }
    //    else if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.Rotate(0, 50 * Time.deltaTime, 0);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        //ControllMove();
        //WASDMove();
        //RotateMove();
    }
}