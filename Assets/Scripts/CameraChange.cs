using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {
	public Camera FirstCam;
	public Camera SecondCam;

	// Use this for initialization
	void Start () {
		FirstCam.enabled = true;
		SecondCam.enabled = false;
	
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider other){
		if (other.gameObject.CompareTag ("Wall")) {
			FirstCam.enabled = false;
			SecondCam.enabled = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Wall")) {
			FirstCam.enabled = true;
			SecondCam.enabled = false;
		}
		
	}
}
