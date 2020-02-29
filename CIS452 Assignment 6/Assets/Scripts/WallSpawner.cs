/*
 * Matt Kirchoff
 * WallSpawner.cs
 * CIS452 Assignment 5
 * spawns wall obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public SimpleAmmoFactory factory;
    public SimplePrefabFactory prefabFactory;

    private GameObject wall;

    public float wallSpeed;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        wallSpeed = 20f;
        player = Camera.main.transform;
    }

    public void ShootWall(string type)
    {

        wall = prefabFactory.LoadWall(type);


        wall = factory.AddAmmoScript(wall, type);

        Vector3 spawnPos = player.position +
                           player.forward * 1f +
                           new Vector3(7, 0, 0);
        Instantiate(wall, spawnPos, player.rotation);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ShootWall("laserWall");
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            ShootWall("rocketWall");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            ShootWall("bulletWall");
        }

    }
}