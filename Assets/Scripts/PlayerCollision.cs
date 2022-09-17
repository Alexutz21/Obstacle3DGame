using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] PlayerMovement movementRef;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles" ||
        other.gameObject.tag == "Obstacles1" ||
        other.gameObject.tag == "Obstacles2")
        {
            movementRef.enabled = false;
        }
    }
}
