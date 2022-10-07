using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    public int delayEnemy;

    public static List<GameObject> listEnemies;

    private float time;
    private void Start()
    {
        time = 0;
        listEnemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 1)
        {
            time = 0;
            GameObject en=Instantiate(Enemy, transform.position, Quaternion.identity);
            listEnemies.Add(en);
        }
        
    }

    public static GameObject GetFirstEnemy()
    {
        return listEnemies[0];
    }

    public static GameObject GetClosestEnemy(Vector3 currentPos)
    {
        GameObject eMin = null;
        float minDist = Mathf.Infinity;

        foreach(GameObject e in listEnemies)
        {
            float dist = Vector3.Distance(e.transform.position, currentPos);
            if(dist < minDist)
            {
                eMin = e;
                minDist = dist;
            }
        }
        return eMin;
    }

   
}
