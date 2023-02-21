using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : MonoBehaviour
{
    private Transform player;
    private Health health;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        health = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    public void Use()
    {
        
        health.health++;
        Destroy(gameObject);
        
    }
}
