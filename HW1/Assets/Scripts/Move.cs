using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject right;
    public GameObject left;
    void Start()
    {
        right.gameObject.SetActive(false);
        left.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.z += 100;
            transform.position = pos;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tunnel")
        {
            right.gameObject.SetActive(true);
            left.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Tunnel")
        {

            right.gameObject.SetActive(false);
            left.gameObject.SetActive(false);
        }
    }
}
