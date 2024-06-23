using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Cần thiết để sử dụng UI components

public class MakeButtons : MonoBehaviour
{
    [SerializeField]
    private bool physical;
    private GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        hero = GameObject.FindGameObjectWithTag("Hero");
        Debug.Log("MakeButtons script started on ");
    }

    private void AttachCallback(string btn)
    {
        
        if (btn.CompareTo("Skill1Btn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("skill1");
        }
        else if (btn.CompareTo("Skill2Btn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("skill2");
        }
        else
        {
            hero.GetComponent<FighterAction>().SelectAttack("skill3");
        }
        
        
    }
    
 
}
