using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;
    [SerializeField] Text ammoText;

    private void Update()
    {
        DisplayAmmo();
    }

    private void DisplayAmmo()
    {
        ammoText.text = ammoAmount.ToString();
    }

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }

    public void IncreaseAmmo()
    {

    }

    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }

    public void pickUpAmmo()
    {
        ammoAmount += 10;
    }
}
