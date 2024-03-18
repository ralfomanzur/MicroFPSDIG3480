using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlip : MonoBehaviour
{
    public bool isRotated = false;
    public GameObject mainCam;
    public GameObject backCam;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRotated == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                backCam.SetActive (true);
                mainCam.SetActive (false);
                isRotated = true;
            }
        }
        else if (isRotated == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                backCam.SetActive(false);
                mainCam.SetActive(true);
                isRotated = false;
            }
        }
    }
}