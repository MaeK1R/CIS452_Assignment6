/*
 * Matt Kirchoff
 * GunShoot.cs
 * CIS452 Assignment 5
 * Client class for the factory
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public SimpleAmmoFactory factory;
    public SimplePrefabFactory prefabFactory;

    private GameObject ammo;

    public float ammoSpeed;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        ammoSpeed = 20f;
        player = Camera.main.transform;
    }

    public void ShootGun(string type)
    {

        ammo = prefabFactory.LoadGun(type);

       
        ammo = factory.AddAmmoScript(ammo, type);

        Vector3 spawnPos = player.position +
                           player.forward * 1f +
                           new Vector3(-7, 0, 0);
        Instantiate(ammo, spawnPos, player.rotation);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ShootGun("laser");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ShootGun("rocket");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ShootGun("bullet");
        }

    }
}
