using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 startPoint;
    public TMP_Text healthText;
    public ScreenAnimation gameOverScreen;
    void Start()
    {
        startPoint = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap")){
            Damage(1);
        }else if (other.CompareTag("Checkpoint"))
        {
            //set the position based on the checkpoint, but the y variable stays the same
            startPoint = other.transform.position;
            startPoint.y = transform.position.y;
        }else if (other.CompareTag("fireball"))
        {
            Damage(2);
            Destroy(other.gameObject);
        }
    }
    //to remove some health points
    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health:</b> {points}";
        //$ lets you put the entire text into "" instead of "Health:" + points
            //points = 5;
            
            transform.position = startPoint;
        if (points < 1)
        {
            gameOverScreen.StartFade();
             Destroy(gameObject);
        }
    }
}
