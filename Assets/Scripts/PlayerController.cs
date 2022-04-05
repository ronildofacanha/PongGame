using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    [Header("Key setup")]
    public KeyCode keyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode keyCodeMoveDown = KeyCode.DownArrow;

    void Update()
    {
        if (Input.GetKey(keyCodeMoveUp))
        {
            transform.GetComponent<Rigidbody2D>().MovePosition(transform.position + transform.up * (speed * Time.deltaTime));
        }
        else if (Input.GetKey(keyCodeMoveDown))
        {
            {
                transform.GetComponent<Rigidbody2D>().MovePosition(transform.position - transform.up * (speed * Time.deltaTime));
            }
        }
    }
}
