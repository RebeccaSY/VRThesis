using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour
{
    public GameObject nextObject;

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Cube Enter " + coll.gameObject.name);
        nextObject.SetActive(true);

    }

    void OnTriggerExit(Collider coll)
    {
        Debug.Log("Cube Exit " + coll.gameObject.name);
        //GameObject.Find("tetsing obj (1)").SetActive(true);
    }

}
