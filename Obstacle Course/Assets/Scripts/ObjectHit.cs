using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;

        if (TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }

    }
}
