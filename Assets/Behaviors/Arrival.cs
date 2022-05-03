using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrival : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log(message:"Arrivée Trigger !");
    // }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(1);
    }
}
