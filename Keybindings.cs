using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybindings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject leftCamera = GameObject.Find("Left");
        GameObject rightCamera = GameObject.Find("Right");
        GameObject mono = GameObject.Find("Mono");
        GameObject thirdPerson = GameObject.Find("ThirdPerson");
        bool isThirdPerson = thirdPerson.GetComponent<Camera>().enabled;

        if(Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            // Increase the IPD for the binocular stereoscopic camera.
            leftCamera.transform.position = leftCamera.transform.position + new Vector3(-0.1f, 0.0f, 0.0f);
            rightCamera.transform.position = rightCamera.transform.position + new Vector3(0.1f, 0.0f, 0.0f);
        }
        if(Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            // Decrease the IPD for the binocular stereoscopic camera
            leftCamera.transform.position = leftCamera.transform.position + new Vector3(0.1f, 0.0f, 0.0f);
            rightCamera.transform.position = rightCamera.transform.position + new Vector3(-0.1f, 0.0f, 0.0f);
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            bool isMono = mono.GetComponent<Camera>().enabled;
            bool isStereo = leftCamera.GetComponent<Camera>().enabled;
            if(isStereo)
            {
                leftCamera.GetComponent<Camera>().enabled = false;
                rightCamera.GetComponent<Camera>().enabled = false;
                thirdPerson.GetComponent<Camera>().enabled = true;
            }else if(isMono)
            {
                mono.GetComponent<Camera>().enabled = false;
                thirdPerson.GetComponent<Camera>().enabled = true;
            }else
            {
                thirdPerson.GetComponent<Camera>().enabled = false;
                mono.GetComponent<Camera>().enabled = true;
            }

        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            // Toggle monocular/binocular stereoscopic cameras.
            if (!isThirdPerson)
            {
                leftCamera.GetComponent<Camera>().enabled = !leftCamera.GetComponent<Camera>().enabled;
                rightCamera.GetComponent<Camera>().enabled = !rightCamera.GetComponent<Camera>().enabled;
                mono.GetComponent<Camera>().enabled = !mono.GetComponent<Camera>().enabled;
            }
        }
    }
}
