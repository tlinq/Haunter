using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public List<string> stringList;

    public Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        stringList = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput() {
        if (Input.GetKey(KeyCode.W)) {
            moveDirection = new Vector2(0, 1);
            rb.velocity = moveDirection * speed;
        } else if (Input.GetKey(KeyCode.S)) {
            moveDirection = new Vector2(0, -1);
            rb.velocity = moveDirection * speed;
        } else if (Input.GetKey(KeyCode.D)) {
            moveDirection = new Vector2(1, 0);
            rb.velocity = moveDirection * speed;
        } else if (Input.GetKey(KeyCode.A)) {
            moveDirection = new Vector2(-1, 0);
            rb.velocity = moveDirection * speed;
        } else {
            moveDirection = new Vector2(0, 0);
            rb.velocity = moveDirection * speed;
        }

    }
}
