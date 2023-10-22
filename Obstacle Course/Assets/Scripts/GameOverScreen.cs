using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    public void Setup(string message)
    {
        gameObject.SetActive(true);
        textMeshPro.text = message;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
