using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Graund")
        {
            Debug.Log("땅과 충돌");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 안에 들어감");
    }
}
