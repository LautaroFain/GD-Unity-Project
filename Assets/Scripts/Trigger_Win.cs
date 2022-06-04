using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Win : MonoBehaviour
{
    public GameObject uiObject;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player) 
    {
        uiObject.SetActive(true);        
    }
}
