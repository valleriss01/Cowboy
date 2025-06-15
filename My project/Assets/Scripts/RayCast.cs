using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera cam;
    Vector3 Directory;
    public GameObject Hero;
    float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        Directory = Vector3.zero;
    }

    public void RayMove()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit)) //ray.origin - ���������  ����� ����.    ray.direction - ����������� ����.    RaycastHit hit - ����� ����������� ���� � ������-�� ������� (����� �� ���������)
            {
                Debug.DrawLine(cam.transform.position, hit.point, Color.green, 0.3f); //������ ��� �� ������ �� ����� �����������
                Directory = hit.point - Hero.transform.position; //������������� ����������� ����� ������ ����������� � ������
                Hero.transform.position = Hero.transform.position + Directory.normalized * speed * Time.deltaTime;
                //Hero.transform.Translate(Directory.normalized * speed * Time.deltaTime);
                Hero.transform.LookAt(hit.point);
                Hero.transform.GetChild(0).GetComponent<Animator>().Play("Walk_F");
            }
        }
        else
        {
            Hero.transform.GetChild(0).GetComponent<Animator>().Play("Idle");
        }
    }


    // Update is called once per frame
    void Update()
    {
        RayMove();
        cam.transform.position = Hero.transform.position + new Vector3(0, 10, -6);
    }
}
