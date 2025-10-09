using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public float timer;
    public float gameTimeLimit = 30f;
    public float timeLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //amount of time that has passed since th elast frame
        timer += Time.deltaTime;
    }
    void FixedUpdate()
    {

    }
    
}
