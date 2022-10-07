using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 direction;
    public int damage;

    void Start()
    {
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MovmentBehavior>().MoveTowards(direction);
    }

    public void SetTarget(Vector3 targetDir)
    {
        direction = targetDir;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<HealthBehavior>().Hurt(damage);
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
