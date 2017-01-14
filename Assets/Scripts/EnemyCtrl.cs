using UnityEngine;
using System.Collections;

public class EnemyCtrl : MonoBehaviour {
	private Animator animator;
	private AnimatorStateInfo animState;
	private int random;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		PlayerCtrl.IsDead = false;


	}
	
	// Update is called once per frame
	void Update () {
		animState = animator.GetCurrentAnimatorStateInfo (0);
		if (animState.normalizedTime > 0.9F) {
			if (PlayerCtrl.IsDead == true) {
				animator.speed =0;
			} else if(PlayerCtrl.IsDead == false) {
				random = Random.Range (0, 3);
				animator.speed =1;
				animator.SetInteger ("motion_ctrl", random);
			}
			
		}
	
	}
}
