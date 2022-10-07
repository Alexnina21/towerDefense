using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destoyer : MonoBehaviour
{
    public UnityEvent<int> Hurt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hurt.Invoke(10);
        EnemyGenerator.listEnemies.Remove(collision.gameObject);
        Destroy(collision.gameObject);
    }
}
