﻿using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;

public class NonPlayerCharacter : ObjectiveLogic
{
    private string _dialogText;
    // Start is called before the first frame update
    void Start()
    {
        HandleDialogInit(Name);
    }

    void Update()
    { 
       
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (ShowsDialog)
            HandleObjective();
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (!ShowsDialog)
            return;
        DialogBox.SetActive(false);
    }
}