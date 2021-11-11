using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject saltPrefab;
    public float saltForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot() 
    {
        GameObject salt = Instantiate(saltPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = salt.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * saltForce, ForceMode2D.Impulse);
    
    }
}
