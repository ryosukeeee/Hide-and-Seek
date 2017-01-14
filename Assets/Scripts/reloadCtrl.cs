using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reloadCtrl : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "visible") {
			SceneManager.LoadScene ("Tutrial");
			PlayerCtrl.IsDead = false;
			TextController.reloadJudge = true;
		}
	}
}
