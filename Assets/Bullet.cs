using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collider2D collision) 
    {
        Destroy(gameObject);    

    }
}
