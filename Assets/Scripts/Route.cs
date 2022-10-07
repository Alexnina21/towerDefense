using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    public static Transform[] pointsList;
    
    // Start is called before the first frame update
    void Awake()
    {
        pointsList=GetComponentsInChildren<Transform>();
    }
}
