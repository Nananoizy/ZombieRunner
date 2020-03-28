using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage= 40f;

    [SerializeField] AudioClip ataque;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) { return; }

        target.TakeDamage(damage);

        GetComponent<AudioSource>().PlayOneShot(ataque);

    }

 
}
