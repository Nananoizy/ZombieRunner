﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem flash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Ammo ammoSlot;
    [SerializeField] AudioClip disparo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (ammoSlot.GetCurrentAmmo() > 0)
            {
                Shoot();
            }
            
        }
    }

    private void Shoot()
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().PlayOneShot(disparo);
        PlayFlash();
        ProcessRaycast();
        ammoSlot.ReduceCurrentAmmo();
    }

    private void PlayFlash()
    {
        flash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            if (target == null)
                return;

            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject hitGO = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));

        Destroy(hitGO, 0.1f);
    }
}
