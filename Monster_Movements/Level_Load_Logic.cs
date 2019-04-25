using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOfGame : MonoBehaviour
{
    // Start is called before the first frame update
    public string screentoload;
    public float countt = 0;
    void Start()
    {
        SceneManager.LoadSceneAsync("Level1");
        Debug.Log("Level1 Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(countt);
        countt = countt + 1;
        if (countt > 2)
        {
            SceneManager.UnloadSceneAsync("Level1");
            Debug.Log("Terminated");
        }
        else
        {
            Debug.Log(countt);
        }
    }
}
