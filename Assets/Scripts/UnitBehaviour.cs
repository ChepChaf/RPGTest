using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitBehaviour : MonoBehaviour, IDamageable
{
    // TODO: This will be handled by some sort of manager
    public Slider healthBar;

    [SerializeField]
    protected Unit stats;

    int health;
    int attack;

    public int Health { get => health; }
    public int Attack { get => attack; }

    protected void Start()
    {
        health = stats.health;
        attack = stats.attack;
    }

    private void Update()
    {
        if (healthBar != null)
            healthBar.value = Mathf.Clamp(Health, 0, 100
            );
    }

    public void TakeDamage(int value)
    {
        if (value > 0)
        {
            health -= value;
        }
        else
        {
            Debug.LogWarning("Negative value for damage: " + value);
        }
    }
}
