using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTwo : MonoBehaviour
{

    public AudioSource keySound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("obtained diamondtwo");
            keySound.Play();
            Destroy(this.gameObject); //destroy diamondtwo object
        }
    }
}
