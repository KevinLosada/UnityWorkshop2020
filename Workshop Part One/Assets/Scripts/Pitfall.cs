using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitfall : MonoBehaviour
{
    public GameObject spawn;
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        powerUp.transform.gameObject.SetActive(true);
        other.transform.position = spawn.transform.position;
        other.transform.rotation = spawn.transform.rotation;
    }
}
