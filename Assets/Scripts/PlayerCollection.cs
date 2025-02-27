using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Only destroy if collectible
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
        }
    }
}
