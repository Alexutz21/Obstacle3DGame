using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{

    [SerializeField] PlayerMovement movementRef;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            movementRef.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

