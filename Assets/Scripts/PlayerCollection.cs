using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollection : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    private void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Only destroy if collectible
        if (other.CompareTag("Collectible"))
        {
            
            Destroy(other.gameObject);
            Add(1);
        }
    }
    private void Add (int value)
    {
        score = score + value;
        scoreText.text = $"<b>Score:</b> {score}";
    }
}
