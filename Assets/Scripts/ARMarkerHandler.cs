using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ARMarkerHandler : MonoBehaviour
{
    private ObserverBehaviour observerBehaviour;

    [Header("Canvas / UI Overlay")]
    public GameObject uiCanvas;     // Canvas yang ingin ditampilkan saat marker terdeteksi

    [Header("VR Scene Name")]
    public string vrSceneName = "VR_Scene";

    private void Start()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();

        // Event listener status marker
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        // Pastikan canvas hilang di awal
        if (uiCanvas != null)
            uiCanvas.SetActive(false);
    }

    private void OnDestroy()
    {
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool isVisible =
            status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED;

        if (isVisible)
            OnFound();
        else
            OnLost();
    }

    private void OnFound()
    {
        Debug.Log("Marker terdeteksi!");

        if (uiCanvas != null)
            uiCanvas.SetActive(true);
    }

    private void OnLost()
    {
        Debug.Log("Marker hilang!");

        if (uiCanvas != null)
            uiCanvas.SetActive(false);
    }

    // Jika tombol "Masuk VR" ditekan
    public void LoadVRScene()
    {
        Debug.Log("Memuat VR Scene…");
        SceneManager.LoadScene(vrSceneName);
    }
}
