using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HorseDestroyer : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "horse")
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
