using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject Cube;
    private void Start()
    {
        var lights = Cube.GetComponentsInChildren<Light>();
        //print(lights);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    print(other.tag);
    //    if (other.gameObject.tag is "Player")
    //    {
    //        Debug.Log("in tunnel");
    //    }
    //}
}
