﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collis)
    {
        score.scor += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
