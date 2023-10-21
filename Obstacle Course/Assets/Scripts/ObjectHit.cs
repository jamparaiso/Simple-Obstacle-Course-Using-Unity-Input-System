using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectHit : MonoBehaviour
{
    MeshRenderer m_Renderer;

    private void Start()
    {
        gameObject.tag = "interactable";
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_Renderer = GetComponent<MeshRenderer>();

        if (collision.gameObject.tag == "Player")
        {
            m_Renderer.material.color = Color.blue;
            gameObject.tag = "Untagged";
        }

        if (TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }

    }
}
