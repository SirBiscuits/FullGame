using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour

{  
    public int damage = 5;

    private Enemy Ehealth;
    private Boss Bhealth;
      private void OnTriggerEnter2D(Collider2D other)
    {   //If projectiles hit an enemy or wall they disappear
        if (other.CompareTag("Enemy")|| other.CompareTag("Walls") || other.CompareTag("Boss"))
        {
            DestroyProjectile();
            if(other.CompareTag("Boss"))
            {
                other.gameObject.GetComponent<Boss>().TakeDamage(damage);
            }
            else if(other.CompareTag("Enemy"))
            {
                other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            }  
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

}
