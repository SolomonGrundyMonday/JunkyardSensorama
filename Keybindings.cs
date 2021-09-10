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
            // Do stuff here to toggle between first-person and third-person view once the cameras have been set up.
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            // Toggle monocular/binocular stereoscopic cameras.
            leftCamera.GetComponent<Camera>().enabled = !leftCamera.GetComponent<Camera>().enabled;
            rightCamera.GetComponent<Camera>().enabled = !rightCamera.GetComponent<Camera>().enabled;
            mono.GetComponent<Camera>().enabled = !mono.GetComponent<Camera>().enabled;
        }
    }
}
