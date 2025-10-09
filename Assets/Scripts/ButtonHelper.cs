using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHelper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   public void ChangeScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
