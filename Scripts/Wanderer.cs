﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : Kinematic
{
    public Wander myMoveType;
    public LookWhereGoing myRotateType;

    void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;
        myMoveType.characterTrans = GetComponent<Transform>();

        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;

        base.Update();
    }
}
