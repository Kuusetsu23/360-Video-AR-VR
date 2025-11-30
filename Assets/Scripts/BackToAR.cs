using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToAR : MonoBehaviour
{
    [Header("Nama Scene AR")]
    public string arSceneName = "SampleScene"; // ganti sesuai nama scene AR kamu

    public void LoadARScene()
    {
        Debug.Log("Kembali ke AR...");
        SceneManager.LoadScene(arSceneName);
    }
}
