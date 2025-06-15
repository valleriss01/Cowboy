using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] Horses = new GameObject[10];
    [SerializeField] Transform SpawnPoint;

    float CurrentTimer = 1;

    public void Generator()
    {
        GameObject NewHorse = Instantiate(Horses[Random.Range(0, 10)],SpawnPoint);
        NewHorse.transform.localPosition = new Vector3(Random.Range(-4,4),0,0);
        NewHorse.transform.GetChild(1).GetComponent<Animator>().speed = Random.Range(Random.Range(0.4f, 0.8f), Random.Range(1.0f, 1.8f));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CurrentTimer -= Time.deltaTime;
        if(CurrentTimer < 0)
        {
            Generator();
            CurrentTimer = Random.Range(0.0f,1.5f);
        }
    }
}
