using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        transform.position = position;
    }
}
