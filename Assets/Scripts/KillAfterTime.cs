using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAfterTime : MonoBehaviour
{
    public bool killAfter = true;
    public float killDelay = 5f;

    private void OnEnable()
    {
        Destroy(gameObject, killDelay);
    }
}
