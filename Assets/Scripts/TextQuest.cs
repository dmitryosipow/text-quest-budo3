using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public Text locationNameLabel;
    public Text contentLabel;
    
    public Step initStep;
    
    public Image locationImage;

    private Step _currentStep;

    #endregion

    #region Unity lifeCycle

    private void Start()
    {
        SetStep(initStep);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetStep(_currentStep.Steps[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetStep(_currentStep.Steps[1]);
        }
    }

    #endregion

    private void SetStep(Step nextStep)
    {
        if (nextStep == null)
        {
            return;
        }

        _currentStep = nextStep;
        contentLabel.text = nextStep.Content;
        locationNameLabel.text = nextStep.Location;
        locationImage.sprite = nextStep.Picture;
    }
}