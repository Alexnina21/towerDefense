using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class HealthBehavior : MonoBehaviour
{
    public UnityEvent<int> ChangeHealth;
    public UnityEvent Dead;

    [SerializeField]
    private int maxHealth;

    [SerializeField]
    private int health;
    
    public void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int damage)
    {
        health -= damage;
        ChangeHealth.Invoke(health);
        if (health<=0)
        {
            Dead.Invoke();
            
        }
    }

    public void AddHealth(int h)
    {
        health += h;
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        ChangeHealth.Invoke(health);
    }


}
