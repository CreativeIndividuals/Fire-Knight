using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Damage;
    public ShooterType Type;

    public enum ShooterType
    {
        Player,
        Enemy,
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
