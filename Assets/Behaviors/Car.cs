using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))  {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left*0.1f);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right*0.1f);
        }
    }
}
