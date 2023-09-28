using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Jugador : MonoBehaviour
{
    public float force;
    private Vector3 StartPosition;
    [SerializeField] Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        RB.AddForce(direction * force, ForceMode.Force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position = StartPosition;
            RB.velocity = Vector3.zero;
        }
    }
    /*
    void OnCollisionEnter(Collision collision2)
    {
        if (collision2.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Winner");
        }
    }*/
}
