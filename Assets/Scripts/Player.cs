using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Calculate the direction based on the player's click
            Vector2 direction = (clickPosition.x < transform.position.x) ? Vector2.left : Vector2.right;

            // Apply force in the calculated direction
            rb.AddForce(direction * moveSpeed);
        }
        else
        {
            // Stop the player if no mouse button is clicked
            rb.velocity = Vector2.zero;
        }
    }
}
