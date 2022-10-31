using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHp = 100;
    public float hp = 100;
    public bool canTakeDamage = true;
    public bool canHeal = true;

    private void Start()
    {
        hp = maxHp;
    }

    public void ReduceHp(float damage)
    {
        if (canTakeDamage)
        {
            UpdateHp(hp - damage);
        }
    }

    public void Heal(float healAmount)
    {
        if (canHeal)
        {
            UpdateHp(hp + healAmount);
        }
    }

    private void UpdateHp(float newHp)
    {
        if (newHp <= 0)
        {
            Kill();
        }
        if (newHp > maxHp)
        {
            hp = maxHp;
        }
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}
