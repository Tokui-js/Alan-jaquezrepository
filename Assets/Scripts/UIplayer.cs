using UnityEngine;
using TMPro;

public class UIplayer : MonoBehaviour
{

    public string playerName;

    public GameObject nameField;

    public TMP_InputField inputField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        inputField = nameField.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chnageName()
    {
        playerName = inputField.text;
        Debug.Log("name change called");
    }
}
