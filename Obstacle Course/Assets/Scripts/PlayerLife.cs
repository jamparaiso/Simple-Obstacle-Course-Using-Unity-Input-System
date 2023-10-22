using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] int _playerLife;

    public GameOverScreen gameOverScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "interactable")
        {
            if (_playerLife > 0)
            {
                Debug.Log("Player Life " + _playerLife--);
            }
            else
            {
                gameOverScreen.Setup("Game Over");
                Debug.Log("Game Over!");
                Destroy(gameObject);
            }
        }

    }
}
