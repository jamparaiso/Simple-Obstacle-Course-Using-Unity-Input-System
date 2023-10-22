using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameOverScreen gameOverScreen;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("You win");
        gameOverScreen.Setup("You Win!");
        Destroy(other);
    }
}
