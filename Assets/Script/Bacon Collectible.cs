using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
       Player controller = other.GetComponent<Player>(); 
      
    }

    void Update()
    {
        
    }
}
