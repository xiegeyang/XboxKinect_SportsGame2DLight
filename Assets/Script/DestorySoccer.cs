using UnityEngine;
using System.Collections;

public class DestorySoccer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        //float y = 0;
        //y   =     y+30f;
        //transform.rotation = new Quaternion(0, 0, y, 0);

        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
	}
}
