using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : MonoBehaviour
{

    public int maxHealth = 10;
    public float speed;
    public float stoppingDistance;
    public float nearDistance;
    public float startTimeBtwShots;
    private float timeBtwShots;
    public int currentHealth;

    public NextLevel next;


    public GameObject shot;
    private Transform player;

    private void Start()
    {
        next = GetComponent<NextLevel>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {   //Enemy follows player or runs if too close
        if (Vector2.Distance(transform.position, player.position) < nearDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        } else if (Vector2.Distance( transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if ( Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > nearDistance)
        {
            transform.position = this.transform.position;
        }
            //Enemy Shooting
         if (timeBtwShots <= 0 && Vector2.Distance(transform.position, player.position) < 5)
        {
            Instantiate(shot, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

        public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <=0){
            Destroy(gameObject);
            FloorText.counter +=50;
            next.nextLevel();//Once dead create new map

        }

    }

}