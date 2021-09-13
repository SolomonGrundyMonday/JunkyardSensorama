using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject Player = GameObject.Find("PlayerAvatar");
        AudioSource BarrelSFX = this.GetComponent<AudioSource>();

        if(Player.transform.position.y == this.transform.position.z)
        {
            BarrelSFX.Play(0);
        }
        
    }
}
