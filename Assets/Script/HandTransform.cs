using UnityEngine;
using System.Collections;

public class HandTransform : MonoBehaviour {
    public Transform leftHandOverlay;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = leftHandOverlay.position;
    }
}
