using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision2)
    {
        if (collision2.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Winner");
        }
    }
}
