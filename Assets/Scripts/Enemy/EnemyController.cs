using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector2 direction = Vector2.right;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > 7.5f || transform.position.x < -7.5f)
        {
            direction *= -1;
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        }
    }
}
