using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    ILevel level;
    GameObject target;
    
    void Start()
    {
        level = new Level(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        target = GameObject.Find("Player");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, level.MonsterSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.name == "Terrain" || collision.gameObject.name.Contains("Road") || 
            collision.gameObject.name.Contains("Plane"))
        {

        }
        else { Destroy(this.gameObject); }*/
    }

}
