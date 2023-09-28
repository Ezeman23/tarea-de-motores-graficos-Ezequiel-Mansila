using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  [HideInInspector] public int Puntuacion;
    public void Points()
    {
        Puntuacion += 1;
    }
    public void CheckLevelComleted()
    {
        if (transform.childCount <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
