using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private int _playerLife = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "interactable")
        {
            Debug.Log("Player Life " + _playerLife++);
        }

    }
}
