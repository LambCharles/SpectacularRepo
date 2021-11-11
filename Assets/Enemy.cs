using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 1;

    public void takeDamage(int damage) {

        enemyHealth -= damage;

        if (enemyHealth <= 0) {
            Die();
        }
    }

    void Die() {

        Destroy(gameObject);
    }
}
