using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    ILevel level;

    void Start()
    {
        level = new Level(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, level.EndObject.transform.position,
            level.PlayerSpeed );

        if (level.EndObject.transform.position.x - 1 < this.transform.position.x)
        {
            // level.EndObject = GameObject.Find("End_2");
            Application.Quit();
        }
    }

    
}
