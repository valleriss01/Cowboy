using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    [SerializeField] GameObject Hero;

    public void ArrowPosition()
    {
        if(Hero.GetComponent<BagGetter>().BagCounter == 0)
        {
            transform.position = new Vector3(-15f, 0, 0);
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ArrowPosition();
    }
}