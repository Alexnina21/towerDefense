using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocity;

    private Vector3 direction;

    private MovmentBehavior mv;

    private int currentPointer;

    void Start()
    {
        mv = GetComponent<MovmentBehavior>();


        currentPointer = 0;
        direction = Route.pointsList[currentPointer + 1].position - Route.pointsList[currentPointer].position;
        direction.Normalize();
        transform.position = Route.pointsList[currentPointer].position;
        mv.RotateDirection(direction, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPointer + 1 < Route.pointsList.Length)
        {
            if (Vector3.Distance(transform.position, Route.pointsList[currentPointer + 1].position) > 0.1f)
                transform.position = transform.position + velocity * direction * Time.deltaTime;
            else
            {
                currentPointer++;
                if (currentPointer + 1 < Route.pointsList.Length)
                {
                    direction = Route.pointsList[currentPointer + 1].position - Route.pointsList[currentPointer].position;
                    direction.Normalize();
                    mv.RotateDirection(direction, 0);
                }

            }
        }
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyGenerator.listEnemies.Remove(gameObject);
        Destroy(gameObject);
    }*/

    public void Dead()
    {
        EnemyGenerator.listEnemies.Remove(gameObject);
        Destroy(gameObject);
    }
}
