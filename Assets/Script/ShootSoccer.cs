using UnityEngine;
using System.Collections;

public class ShootSoccer : MonoBehaviour {

    public Rigidbody soccer;
    public Rigidbody coin;

    private float nextSoccerTime = 0.0f;
    private float nextCoinTime = 10f;
    private float soccerSpawnRate = 1.5f;
    private float CoinSpawnRate = 15f;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (nextSoccerTime < Time.time)
        {
            Rigidbody newSoccer = Instantiate(soccer, new Vector3(Random.Range(-8.5f, 8.5f), 6f, 3.7f), transform.rotation) as Rigidbody;
            newSoccer.velocity = transform.TransformDirection(new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-10f, -15f), 0));
            nextSoccerTime = Time.time + soccerSpawnRate;
        }

        if(nextCoinTime < Time.time)
        {
            Rigidbody newCoin = Instantiate(coin, new Vector3(Random.Range(-8.5f, 8.5f), 6f, 3.7f), transform.rotation) as Rigidbody;
            newCoin.velocity = transform.TransformDirection(new Vector3(0, 0, 0));
            nextCoinTime = Time.time + CoinSpawnRate;
        }
    }
}
