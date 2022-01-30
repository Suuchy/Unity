using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPatroling : MonoBehaviour
{

    public bool mustPatrol;
    public float walkSpeed;
    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public Transform playerPos;

    private bool mustTurn;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }

    }

    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            attackPlayer();
            mustPatrol = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag != "Player")
            return;

        if (walkSpeed > 0)
        {
            transform.rotation = Quaternion.identity;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        mustPatrol = true;
    }

    void Patrol()
    {
        if(mustTurn)
        {
            Flip();
        }
        rb.velocity = new Vector2(walkSpeed * Time.deltaTime, rb.velocity.y);
    }
    void attackPlayer()
    {
        Vector2 tmp = new Vector2(playerPos.position.x, transform.position.y);
        if (playerPos.position.x > transform.position.x)
        {
            transform.rotation = Quaternion.identity;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        rb.transform.position = Vector2.MoveTowards(transform.position, playerPos.position , Time.deltaTime * 2f);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }
}
