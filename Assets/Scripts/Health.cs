using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHp = 100f;
    public float hp = 100f;

    public void ReduceHp(float damage)
    {
        hp = hp - damage;

        if (hp < 0)
        {
            hp = 0;
        }

        if (hp == 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
