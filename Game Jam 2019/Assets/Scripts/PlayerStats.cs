using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health;
    public float stamina;
    public bool canAttack;

    private void Awake()
    {
        canAttack = true;
    }

    public void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Damage(float damage)
    {
        health -= damage;
    }
}
