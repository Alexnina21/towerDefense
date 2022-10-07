using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentBehavior : MonoBehaviour
{
    public float velocity;

    public void RotateDirection(Vector3 dir, float initialRotation)
    {
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - initialRotation);
    }

    public void MoveTowards(Vector3 dir)
    {
        transform.position = transform.position + velocity * dir * Time.deltaTime;
    }
}
