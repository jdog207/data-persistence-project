using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    
    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}