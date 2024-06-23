using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ki?m tra n?u có d? li?u l?u tr??c ?ó
        if (PlayerPrefs.HasKey("PlayerPosX"))
        {
            float x = PlayerPrefs.GetFloat("PlayerPosX");
            float y = PlayerPrefs.GetFloat("PlayerPosY");
            float z = PlayerPrefs.GetFloat("PlayerPosZ");

            Vector3 playerPosition = new Vector3(x, y, z);
            transform.position = playerPosition;

            print("Player data loaded");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
