using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calculates how far the camera is from the Player (target)
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //check if the player exists
        if(target == null)
        {
            enabled = false;
            return;
        }
        //where the camera should go
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
    }
}
