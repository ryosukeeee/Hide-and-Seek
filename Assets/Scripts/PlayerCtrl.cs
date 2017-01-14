using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {
	public float speed;
	private Animator animator;
	//死亡判定フラグ
	public static bool IsDead = false;
	//マテリアルの変更
	public static bool materialChange = false;
	//透明化ゲージ
	public static int Gauge;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		this.tag = ("visible");
		materialChange = false;
		Gauge = 200;

	}
	
	// Update is called once per frame
	void Update () {
		
		//死亡判定が無い時
		if (IsDead == false) {
			if (Input.GetKey ("space") && Gauge >= 0) {
				this.tag = ("invisible");
				materialChange = true;
				Gauge--;
	
			} else if (Input.GetKeyUp ("space") || Gauge <200) {
				materialChange = false;
				this.tag = ("visible");
				Gauge++;
			} 


			if (Input.GetKey ("up")) {
				transform.position += transform.forward * speed;
				animator.SetBool ("Run", true);
				this.tag = ("visible");
				materialChange = false;
			} else {
				animator.SetBool ("Run", false);
			}


			if (Input.GetKey ("left")) {
				materialChange = false;
				transform.Rotate (0, -5, 0);
				this.tag = ("visible");
			} else if (Input.GetKey ("right")) {
				materialChange = false;
				transform.Rotate (0, 5, 0);
				this.tag = ("visible");
			}
		//死亡判定がある時
		} else if(IsDead == true) {
			if (Input.GetKey ("space") && Gauge >= 0) {
				this.tag = ("invisible");
				materialChange = true;
				Gauge--;


			} else if (Input.GetKeyUp ("space")|| Gauge <100) {
				materialChange = false;
				this.tag = ("visible");
				Gauge++;

			}


		}
	}
}
