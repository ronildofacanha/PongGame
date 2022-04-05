using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public float speedBall = 10;
    Vector3 speed = new Vector3(1, 1, 0);

    public string keyToCheck = "Player";
    void Update()
    {
        transform.Translate((speed * Time.deltaTime)* speedBall);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == keyToCheck)
            speed.x = speed.x * -1;
        else
            speed.y = speed.y * -1;
    }
}
