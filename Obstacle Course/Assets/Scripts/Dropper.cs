using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public float _seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _seconds = Time.time % 60f;
        if (_seconds >= 3f)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }

    }
}
