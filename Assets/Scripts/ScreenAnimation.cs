using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenAnimation : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void StartFade()
    {
        StartCoroutine(FadeInOutRoutine());
    }
    private IEnumerator FadeInOutRoutine()
    {
        float duration = 0.5f;
        float time = 0;
        yield return new WaitForSeconds(0.25f);
        //fade in
        while(time < duration)
        {
            time += Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);
        //fade out
        while (time > 0)
        {
            time -=Time.deltaTime;
            float distance = time / duration;
            canvasGroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("SampleScene");
    }
}
