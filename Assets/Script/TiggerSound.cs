using UnityEngine;
using System.Collections;

public class TiggerSound : MonoBehaviour {

    public AudioSource soccerAudio;

	// Use this for initialization
	void Start () {
        soccerAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision collision)
    {
        //If the one colliding have the tag prey it
        //will get destroyed

        if (collision.gameObject.tag == "Glove")
        {
            
            soccerAudio.Play();
            
        }
    }
}
