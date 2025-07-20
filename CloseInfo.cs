using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseInfo : MonoBehaviour
{
    public void Close()
    {
        SceneManager.LoadScene("Menu");
    }
}