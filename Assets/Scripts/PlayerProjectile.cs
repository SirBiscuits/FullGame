using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed;


    public Transform player;


    public int damage = 5;
    public float bulletForce =20f;

    private Enemy Ehealth;
    private Boss Bhealth;

    public GameObject shot;
    public Camera cam;
    Vector3 mousePos;


    private void Update()
    {
        //Shooting for player
        if (Input.GetButtonDown("Fire1"))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = (Vector2)((mousePos - transform.position));
            dir.Normalize();
            GameObject bullet = (GameObject)Instantiate(shot, transform.position + (Vector3)(dir * 0.5f), Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletForce;
        }

    }


    

}
