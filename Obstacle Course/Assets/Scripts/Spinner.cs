using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float _x = 0f;
    [SerializeField] float _y = 0.5f;
    [SerializeField] float _z = 0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(_x,_y,_z);
    }
}
