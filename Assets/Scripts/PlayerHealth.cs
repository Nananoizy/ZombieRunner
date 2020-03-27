using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float hitPoints = 100f;
    [SerializeField] Text hpText;

    private void Update()
    {
        hpText.text = "HP: " +  hitPoints.ToString();
    }

    public void TakeDamage(float damage)
    {
        hitPoints = hitPoints - damage;

        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
