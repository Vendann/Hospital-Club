using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageCount = 1;

    void OnCollisionEnter(Collision collision)
    {
        PlayerManager.Damage(damageCount);
    }
}
