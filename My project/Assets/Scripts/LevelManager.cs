using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> Levels = new List<GameObject>(4);
    public GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        int randomlvl = Random.Range(0, 4);
        for (int i = 0; i < Levels.Count; i++)
        {
            if(i == randomlvl)
            {
                Levels[i].SetActive(true);
            }
            else
            {
                Levels[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}