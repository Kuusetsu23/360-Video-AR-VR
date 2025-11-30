using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    [Header("Fade Panel (CanvasGroup)")]
    public CanvasGroup fadePanel;

    [Header("Durasi Fade")]
    public float fadeDuration = 1f;

    public void FadeOutAndLoad(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    private System.Collections.IEnumerator FadeOut(string sceneName)
    {
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadePanel.alpha = Mathf.Lerp(0, 1, t / fadeDuration);
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}
