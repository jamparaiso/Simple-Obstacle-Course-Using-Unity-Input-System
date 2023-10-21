using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer m_Renderer;
    Rigidbody m_rigidbody;

    [SerializeField] bool _isTrigger;
    [SerializeField] float _secondsToDrop = 3f;
    public float _seconds;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_rigidbody = GetComponent<Rigidbody>();

        m_rigidbody.useGravity = false;
        m_Renderer.enabled = false;

        if (_isTrigger)
        {
            gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        _seconds = Time.time % 60f;
        if (_seconds >= _secondsToDrop)
        {
            m_rigidbody.useGravity = true;
            m_Renderer.enabled = true;
        }

    }
}
