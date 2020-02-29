/*
 * Matt Kirchoff
 * Ammo.cs
 * CIS452 Assignment 5
 * Type class for factory ammo types
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    protected string AmmoType { get; set; }

    public override string ToString()
    {
        return "EnemyType: " + this.AmmoType;
    }

}

