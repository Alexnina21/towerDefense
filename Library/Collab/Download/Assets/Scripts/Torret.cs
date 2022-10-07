using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    Vector3 enemieTargetDir;
    public float cadency;
    public float aimRadius;
    public GameObject Bullet;

    private float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if(EnemyGenerator.listEnemies.Count > 0)
        {
            enemieTargetDir = EnemyGenerator.GetCloseEnemy(transform.position).position - transform.position;

            if(enemieTargetDir.magnitude < aimRadius)
            {
                enemieTargetDir.Normalize();
                GetComponent<MonoBehaviour>().RotateDirection(enemieTargetDir, 90);

                if(time >= cadency)
                {
                    time = 0;
                    Instantiate(Bullet, transform.position, Quaternion.identity);
                }
            }
        }
        
        /*GameObject e = EnemyGenerator.GetFirstEnemy();
        Vector3 dir = e.transform.position - transform.position;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);*/
    }
}
