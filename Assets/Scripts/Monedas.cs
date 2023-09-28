using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI Contador;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.Points();
            Contador.text = gameManager.Puntuacion.ToString();
            FindAnyObjectByType<GameManager>().CheckLevelComleted();
            Destroy(gameObject);
        }
    }
}
