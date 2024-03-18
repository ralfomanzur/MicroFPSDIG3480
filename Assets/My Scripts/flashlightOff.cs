using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightOff : MonoBehaviour
{
    public bool isOFF = false;
    public GameObject flashlight;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isOFF == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashlight.SetActive(false);
                isOFF = true;
            }
        }
        else if (isOFF == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashlight.SetActive(true);
                isOFF = false;
            }
        }
    }
}