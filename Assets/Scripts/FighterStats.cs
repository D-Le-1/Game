using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Import SceneManager
using System;

public class FighterStats : MonoBehaviour, IComparable
{
    [SerializeField]
    private GameObject healthFill;
    [SerializeField]
    private GameObject magicFill;

    [Header("Stats")]
    public float health;
    public float magic;
    public float skill1;
    public float skill2;
    public float magicRange;
    public float defense;

    public float speed;
    public float experience;

    private float startHealth;
    private float startMagic;

    [HideInInspector]
    public int nextActTurn;

    private bool dead = false;

    //Resize health and magic bar
    private Transform healthTransform;
    private Transform magicTransform;

    private Vector2 healthScale;
    private Vector2 magicSacle;

    private float xNewHealthScale;
    private float xNewMagicScale;

    public int sceneBuildIndex;

    private void Start()
    {
        healthTransform = healthFill.GetComponent<RectTransform>();
        healthScale = healthFill.transform.localScale;

        magicTransform = magicFill.GetComponent<RectTransform>();
        magicSacle = magicFill.transform.localScale;

        startHealth = health;
        startMagic = magic;

        
    }

    public void ReceiveDamage(float damage)
    {
        health = health - damage;
        //animator.Play("Player");

        //set damage text
        if (health <= 0)
        {
            dead = true;
            gameObject.tag = "Dead";
            Destroy(healthFill);
            Destroy(gameObject);

            // Chuyển về scene trước đó
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
        else
        {
            xNewHealthScale = healthScale.x * (health / startHealth);
            healthFill.transform.localScale = new Vector2(xNewHealthScale, healthScale.y);
        }
    }

    public void UpdateMagicFill(float cost)
    {
        magic = magic - cost;
        xNewMagicScale = magicSacle.x * (magic / startMagic);
        magicFill.transform.localScale = new Vector2(xNewMagicScale, magicSacle.y);
    }

    public bool GetDead()
    {
        return dead;
    }

    public void CalculateNextTurn(int currentTurn)
    {
        nextActTurn = currentTurn + Mathf.CeilToInt(100f / speed);
    }

    public int CompareTo(object otherStats)
    {
        int nex = nextActTurn.CompareTo(((FighterStats)otherStats).nextActTurn);
        return nex;
    }
}
