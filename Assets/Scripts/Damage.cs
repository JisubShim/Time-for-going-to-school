using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private Health health1;
    // Start is called before the first frame update
    void Start()
    {
        health1 = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            health1.health--;
        }
    }
}
