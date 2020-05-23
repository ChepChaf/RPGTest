using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehaviour : MonoBehaviour, IDamageable
{
    public Unit stats;
    public void TakeDamage(int value)
    {
        if (value > 0)
        {
            stats.health -= value;
        } else
        {
            Debug.LogWarning("Negative value for damage: " + value);
        }
    }
}
