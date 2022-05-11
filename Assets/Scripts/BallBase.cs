using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public float speedBall = 10;
    Vector3 speed = new Vector3(1, 1, 0);

    public string keyToCheck = "Player";

    [Header("Rand")]
    public Vector2 randX = new Vector2(1, 10);
    public Vector2 randY = new Vector2(1, 30);

    void Update()
    {
        transform.Translate((speed * Time.deltaTime)* speedBall);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == keyToCheck)
            onPlayerCollision();
        else
            speed.y *= -1;
    }


    private void onPlayerCollision()
    {
        speed.x *= -1;

        float rand = Random.Range(randX.x, randX.y);

        if (speed.x < 0)
            rand = -rand;

        speed.x = rand;

        rand = Random.Range(randY.x, randY.y);
        speed.y = rand;
    }

}