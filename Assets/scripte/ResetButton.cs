using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
