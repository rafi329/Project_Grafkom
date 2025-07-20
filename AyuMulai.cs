using UnityEngine;
using UnityEngine.SceneManagement;

public class AyuMulai : MonoBehaviour
{
  
    public void GoToscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
    public void Keluar()
    {
        Application.Quit();
        Debug.Log("Keluar Dari Aplikasi.");
    }
}
