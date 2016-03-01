using UnityEngine;
using System.Collections;

public class DestoryCoin : MonoBehaviour {

    //public Rigidbody coin;

    public AudioSource coinAudio;

	// Use this for initialization
	void Start () {
        coinAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        

        //OnTriggerEnter(coin.GetComponent<Collider>());
	}

    public void OnCollisionEnter(Collision collision)
    {
        //If the one colliding have the tag prey it
        //will get destroyed

        if (collision.gameObject.tag == "Coin")
        {
            coinAudio.Play();
            Destroy(collision.gameObject);
        }
    }
}
