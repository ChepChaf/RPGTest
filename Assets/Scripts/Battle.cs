using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle
{
    List<UnitBehaviour> allies;
    List<UnitBehaviour> enemies;

    Battle(List<UnitBehaviour> allies, List<UnitBehaviour> enemies)
    {
        this.allies = allies;
        this.enemies = enemies;
    }

    public List<UnitBehaviour> Allies { get => allies; }
    public List<UnitBehaviour> Enemies { get => enemies; }
}
