using UnityEngine;
using System.Collections;

public class FindJudge : MonoBehaviour {
	public GameObject UI;
	GameObject Player;
	Animator animator;
	void Start () {
		Player = GameObject.Find ("robot");
		animator = Player.GetComponent<Animator> ();
		PlayerCtrl.IsDead = false;


	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "visible") {
			Debug.Log ("finded");



			animator.SetBool ("Dead", true);
			PlayerCtrl.IsDead = true;
			UI.SetActive (true);
			


		}
	}
}
