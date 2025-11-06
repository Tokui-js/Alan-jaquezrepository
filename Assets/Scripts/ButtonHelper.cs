using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHelper : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void Start()
    {

    }

    public void ChangeScene(string LivingRoom)
    {
        SceneManager.LoadScene(LivingRoom);
    }
}
