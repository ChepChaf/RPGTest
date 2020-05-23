using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : IAction
{
    public void Do(UnitBehaviour actor, UnitBehaviour target)
    {
        target.TakeDamage(target.Attack);
    }
}
