using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollection : MonoBehaviour
{
    public int score;
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
            Add(1);
            Destroy(other.gameObject);
        }
    }
    private void Add (int value)
    {
        score += value;
        scoreText.text = $"<b>Score:</b> {score}";
    }
}
