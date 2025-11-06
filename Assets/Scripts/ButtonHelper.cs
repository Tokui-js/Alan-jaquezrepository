using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHelper : MonoBehaviour
{
    string

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public UIplayer myPlayer;

    void Start()
    {
        myPlayer = UIplayer._playerInstance;
        if (myPlayer == null)
        {
            Debug.LogError("No player instance found in scene");
        }
    }

   public void ChangeScene(string LivingRoom)
    {
        SceneManager.LoadScene(LivingRoom);
    }
    public void AddToInventory(string itemName)
    {
        for (int i = 0; myPlayer.inventory < i; )
        {

        }
    }
}
