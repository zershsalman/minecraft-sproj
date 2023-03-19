using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.None; // Reset the cursor lock state
        SceneManager.LoadSceneAsync("Scene1");
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = true;
        // Cursor.lockState = CursorLockMode.None;
        // Cursor.lockState = CursorLockMode.Locked;
    }
}
