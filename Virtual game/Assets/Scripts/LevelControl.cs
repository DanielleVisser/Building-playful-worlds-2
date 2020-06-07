using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Loading level with Index
            SceneManager.LoadScene(index);

            //loading level with scene name
            //SceneManager.LoadScene(levelName);

            //Restart lvl
            //Scenemanager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
