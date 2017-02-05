using UnityEngine;
using System.Collections;

public class FindJudgePhisics : MonoBehaviour {
	public GameObject UI;
	GameObject Player;
	Animator animator;
	void Start () {
		Player = GameObject.Find ("robot");
		animator = Player.GetComponent<Animator> ();
		PlayerCtrl.IsDead = false;

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "visible"|| other.tag=="invisible") {
			Debug.Log ("finded");

			UI.SetActive (true);
			PlayerCtrl.IsDead = true;
			animator.SetBool ("Dead", true);
		}
	}
}
