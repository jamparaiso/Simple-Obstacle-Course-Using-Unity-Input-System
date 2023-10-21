using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] bool leftToRight;
    [SerializeField] bool upToDown;
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftToRight)
        {
            Vector3 x = startingPosition;
            x.x += distanceToCover * Mathf.Sin(Time.time * speed);
            transform.position = x;
        }

        if (upToDown)
        {
            Vector3 z = startingPosition;
            z.z += distanceToCover * Mathf.Sin(Time.time * speed);
            transform.position = z;
        }
    }
}