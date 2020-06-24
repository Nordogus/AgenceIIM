﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnHoverBnt(string Bool)
    {
        if(animator != null)
        {
            if (!animator.GetBool(Bool)) animator.SetBool(Bool, true);
        }
    }
    public void OnHoverExit(string Bool)
    {
        if (animator != null)
        {
            if (animator.GetBool(Bool)) animator.SetBool(Bool, false);
        }
    }
    
}