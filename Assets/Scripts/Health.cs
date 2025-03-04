using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;
    private Vector3 startPoint;
    void Start()
    {
        startPoint = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap")){
            Damage(1);
        }
    }
    //to remove some health points
    private void Damage(int value)
    {
        points = points - value;
        if (points < 1){
            //HOMEWORK: do not destroy player, move the player to the start and reset the points to 5
            points = 5;
            
            transform.position = startPoint;
        }
    }
}
