using UnityEngine;
using UnityEngine.SceneManagement;

public class Kembali : MonoBehaviour
{
 
    public void GoToscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
