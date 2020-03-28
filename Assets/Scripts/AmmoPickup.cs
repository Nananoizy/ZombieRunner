using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] AudioClip cogerMunicion;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("PickUpsSound").GetComponent<AudioSource>().PlayOneShot(cogerMunicion);
            other.gameObject.transform.GetComponent<Ammo>().pickUpAmmo();
            Destroy(gameObject);
        }
    }
    
}
