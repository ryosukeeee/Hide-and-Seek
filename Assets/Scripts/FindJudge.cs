using UnityEngine;
using System.Collections;

public class FindJudge : MonoBehaviour {
	public GameObject UI;
	GameObject Player;
	Animator animator;
	void Start () {
		Player = GameObject.Find ("robot");
		animator = Player.GetComponent<Animator> ();


	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "visible") {
			Debug.Log ("finded");

			UI.SetActive (true);
			PlayerCtrl.IsDead = true;
			animator.SetBool ("Dead", true);
			


		}
	}
}
