﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

    public override void Update()
    {
        Debug.Log("MossGiant update");
    }
}
