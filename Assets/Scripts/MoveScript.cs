using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void OnTriggerStay(Collider obj) {

		if (Input.GetKey ("up") && Input.GetKey("return")) {
			obj.transform.position += transform.forward*PlayerCtrl.speed;
		}else if(Input.GetKey("down")&& Input.GetKey("return")){
			obj.transform.position += transform.forward/1000;

		}
	}
}
