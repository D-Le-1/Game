using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FighterAction : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject enemy;
    private GameObject hero;

    [SerializeField]
    private GameObject skill1Prefab;
    [SerializeField]
    private GameObject skill2Prefab;
    [SerializeField]
    private GameObject skill3Prefab;
    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject skill1Attack;
    private GameObject skill2Attack;
    private GameObject skill3Attack;

    private void Start()
    {
        hero = GameObject.FindGameObjectWithTag("Hero");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

    }
    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        if (tag == "Hero")
        {
            victim = enemy;
        }
        if (btn.CompareTo("skill1") == 0)
        {
            skill1Prefab.GetComponent<AttackScript>().Attack(victim);
        }
        else if (btn.CompareTo("skill2") == 0)
        {
            skill2Prefab.GetComponent<AttackScript>().Attack(victim);
        }
        else
            Debug.Log("skill3");
    }
}



