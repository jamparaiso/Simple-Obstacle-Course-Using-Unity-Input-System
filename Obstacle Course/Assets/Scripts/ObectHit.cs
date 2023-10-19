using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Im hit!");
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
