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
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //�������� ����� 1 ���� � �������
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Forward");
    //    }
    //    else
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
    //    }
    //}


    //public void WASDMove()
    //{
    //    if (Input.GetKey(KeyCode.W)) //���� ������ ������� W
    //    {
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //�������� ����� 1 ���� � �������
    //    }
    //    else if (Input.GetKey(KeyCode.S)) //���� ������ ������� S
    //    {
    //        transform.Translate(0, 0, -1.0f * Time.deltaTime); //�������� ����� 1 ���� � �������
    //    }
    //    if (Input.GetKey(KeyCode.A)) //���� ������ ������� A
    //    {
    //        transform.Translate(-1.0F * Time.deltaTime, 0, 0); //�������� ����� 1 ���� � �������
    //    }
    //    else if (Input.GetKey(KeyCode.D)) //���� ������ ������� D
    //    {
    //        transform.Translate(1 * Time.deltaTime, 0, 0); //�������� ����� 1 ���� � �������
    //    }

    //    if (Input.GetKey(KeyCode.W)) //���� ������ ������� W
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Forward");
    //    }
    //    else if (Input.GetKey(KeyCode.S)) //���� ������ ������� S
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Backward");
    //    }
    //    else if (Input.GetKey(KeyCode.A)) //���� ������ ������� A
    //    {
    //        gameObject.transform.GetChild(0).GetComponent<Animator>().Play("HumanM@Walk01_Left");
    //    }
    //    else if (Input.GetKey(KeyCode.D)) //���� ������ ������� D
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
    //    if (Input.GetKey(KeyCode.W)) //���� ������ ������� W
    //    {
    //        transform.Translate(0, 0, 1.5f * Time.deltaTime); //�������� ����� 1 ���� � �������
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