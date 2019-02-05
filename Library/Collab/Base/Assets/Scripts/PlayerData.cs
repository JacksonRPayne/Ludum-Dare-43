using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    public static PlayerData Instance;

    //Player Stats
    public int playerStartingHealth = 5;
    public int playerHealth;
    public float moveSpeed = 5f;
    public float jumpVel = 8.5f;
    public int maxJumps = 2;
    //Arrow Stats
    public float arrowSpeed = 5f;
    public float arrowDamage = 1f;
    public float hitTimer = 1;
    public float shotRate = 4f;
    //Enemy Stats
    public int enemyDamage = 2;

    public bool pressButton = true;

    public float minotaurSpeed = 5f;
    public float harpeySpeed = 0.01f;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerHealth = playerStartingHealth;
    }


    private void Update()
    {
        if (hitTimer >= 0)
        {
            hitTimer -= Time.deltaTime;
        }

    }


    public void LowerHealth(int amount)
    {
        if(hitTimer<=0)
            playerHealth -= amount;

        hitTimer = 0.1f;
    }


}
