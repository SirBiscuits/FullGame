using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text death;
    public NextLevel reload;

    public HealthBar healthBar;
    void Start()
    {   //Sets players Health
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <=0 )
        {//Once player dies show death annoucement
            death.enabled = true;
            Destroy(gameObject);

        }
    }
}
