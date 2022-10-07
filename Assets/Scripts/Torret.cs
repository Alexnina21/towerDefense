using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    Vector3 enemieTargetDir;
    public float cadency;
    public float aimRadius;
    public GameObject Bullet;

    public GameObject enemy;

    private MovmentBehavior mv;

    private float time;
    void Start()
    {
        mv = GetComponent<MovmentBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
        time = time + Time.deltaTime;
        //enemy = EnemyGenerator.GetFirstEnemy();

        if (EnemyGenerator.listEnemies.Count > 0)
        {
            enemy = EnemyGenerator.GetClosestEnemy(transform.position);

            enemieTargetDir = enemy.transform.position - transform.position;

            if (enemieTargetDir.magnitude < aimRadius)
            {
                enemieTargetDir.Normalize();
                mv.RotateDirection(enemieTargetDir, 90);

                if(time >= cadency)
                {
                    time = 0;
                    GameObject newBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
                    newBullet.GetComponent<Bullet>().SetTarget(enemieTargetDir);
                }
            }
        }
        
        /*GameObject e = EnemyGenerator.GetFirstEnemy(transform.position);
        if(e != null)
        {
            Vector3 dir = e.transform.position - transform.position;
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        } */
    }
}
