﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : UnitBehaviour
{
    AttackAction attackAction;

    // TODO: This will be selectable in the future
    public EnemyBehaviour enemy;

    private new void Start()
    {
        base.Start();
        initActions();
    }

    public void initActions()
    {
        attackAction = new AttackAction();
    }

    public void onAttackBtnClick()
    {
        attackAction.Do(this, enemy);
    }
}
