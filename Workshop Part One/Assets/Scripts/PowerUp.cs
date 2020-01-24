using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    SimpleCharacterControl PlayScript;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayScript = Player.GetComponent<SimpleCharacterControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag.Equals("PowerUp"))
        {
            other.transform.gameObject.SetActive(false);
            PlayScript.canJump = true;
        }
    }
}
