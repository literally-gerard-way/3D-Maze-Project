using UnityEngine;

public class LevelExit : MonoBehaviour
{
    public ScreenAnimation winScreen;


    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            //turns player off
            other.gameObject.SetActive(false);
            winScreen.StartFade();
        }
    }
}
