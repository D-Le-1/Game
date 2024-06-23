using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove : MonoBehaviour
{
    public int sceneBuildIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        if (other.tag == "Player")
        {
            // L?u d? li?u tr??c khi chuy?n c?nh
            SavePlayerData(other.gameObject);

            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }

    private void SavePlayerData(GameObject player)
    {
        // Gi? s? b?n mu?n l?u v? trí c?a ng??i ch?i
        Vector3 playerPosition = player.transform.position;
        PlayerPrefs.SetFloat("PlayerPosX", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerPosY", playerPosition.y);
        PlayerPrefs.SetFloat("PlayerPosZ", playerPosition.z);

        // G?i hàm này ?? l?u d? li?u xu?ng ? ??a
        PlayerPrefs.Save();

        print("Player data saved");
    }
}
