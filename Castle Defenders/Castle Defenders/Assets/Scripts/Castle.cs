﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    private float startHealth = 100;

    public float health;

    public Image healthBar;


    private void Start()
    {
        health = startHealth;
    }


    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;


    }

    //private void OnTriggerEnter(Collider other)
    //{
        //TakeDamage(EnemyDragon.damage);
    //}
}
