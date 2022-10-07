using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private HealthBehavior HealthBehavior;
    void Start()
    {
        HealthBehavior = GetComponent<HealthBehavior>();
    }
    private void Update()
    {
        //HealthBehavior.ChangeHealth = HealthHudController.UpdateCanvas(HealthBehavior.helth);
    }
}
