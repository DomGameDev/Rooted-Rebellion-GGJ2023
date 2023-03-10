using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public Scrollbar healthBar;

    private float health;
    private GameController gameController;

    private AudioSource audioSource;
    public AudioClip damageSound;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.size = health / maxHealth;
        if (health <= 0)
        {
            gameController.PlayerLose();
        }
    }
}
