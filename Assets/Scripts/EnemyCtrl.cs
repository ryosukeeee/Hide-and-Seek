using UnityEngine;
using System.Collections;

public class EnemyCtrl : MonoBehaviour {
	private Animator animator;
	private AnimatorStateInfo animState;
	private int random;
	GameObject Player;
	Animator player_animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		Player = GameObject.Find ("robot");
		player_animator = Player.GetComponent<Animator> ();
		PlayerCtrl.IsDead = false;


	}
	
	// Update is called once per frame
	void Update () {
		animState = animator.GetCurrentAnimatorStateInfo (0);
		if (animState.normalizedTime > 0.9F) {
			if (PlayerCtrl.IsDead == true) {
				//player_animator.SetBool ("Dead", true);
				animator.speed =0;
		s
			} 
			
		}
			
	}

}
