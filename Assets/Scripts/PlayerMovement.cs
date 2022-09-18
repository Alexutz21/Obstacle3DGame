using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //This is a referance to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

    //We use FixedUpdates instead of Update because we 
    //are messing with the physics in Unity
    void FixedUpdate()
    {
        // rb.useGravity = false;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // x, y, z-axis
        PlayerMove();
    }


    void PlayerMove()
    {
        //if input a or LeftArrow
        if (Input.GetKey("a") || (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //if input d or RightArrow
        if (Input.GetKey("d") || (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }


}
