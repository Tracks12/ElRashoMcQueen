using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public float timeLeft = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.timeLeft -= Time.deltaTime;

        if(this.timeLeft < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
