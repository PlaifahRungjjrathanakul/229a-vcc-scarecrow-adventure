using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class SceneController : MonoBehaviour
{
    public float delayBeforeLoad = 5f;
    public string nextSceneName = "Credit";

    public Button skipButton; 

    //void Start()
    //{
    //    Invoke("LoadNextScene", delayBeforeLoad);

        
    //    if (skipButton != null)
    //    {
    //        skipButton.onClick.AddListener(SkipScene);
    //    }
    //}

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    void SkipScene()
    {
        CancelInvoke(); 
        LoadNextScene(); 
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SkipScene();
        }
    }
}
