using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D myRB;
    public bool jumped = false;
    public bool grounded = false;
    public float jumpForce = 300f;
    public int DestroyedScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && grounded)
        {
            jumped = true;
        }
    }

    private void FixedUpdate()
    {
        //let's start writing a WASD controller
        Vector3 velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = Speed;

        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = Speed;
        }
        myRB.AddForce(velocity);
        if (jumped)
        {
            Jump();
            jumped = false;
        }
    }

    void Jump()
    {
        myRB.AddForce(Vector3.up * jumpForce);
        
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("start jumping with" + collision.gameObject);
        grounded = true;    
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("stopped collinding with" + collision.gameObject);
        grounded = false;
    }

}
