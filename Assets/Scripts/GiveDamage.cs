using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour
{
    public float damage = 10f;
    public bool dieOnHit = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var otherHp = other.gameObject.GetComponent<Health>();
        if (otherHp)
        {
            otherHp.ReduceHp(damage);

            if (dieOnHit)
            {
                Destroy(gameObject);
            }
        }

       
    }
}
