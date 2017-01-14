using UnityEngine;
using System.Collections;

public class RunbaCtrl : MonoBehaviour {
	private bool turn;
	private int turn_cnt;
	private bool direction;


	// Use this for initialization
	void Start () {
		turn = false;
		turn_cnt = 0;
		direction = true;
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Bound")) {
			turn = true;
			Debug.Log (direction);

		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (turn_cnt);
		if(turn == false){
			if (direction == true) {
				transform.position += new Vector3 (-1, 0, 0);
			} else {
				transform.position += new Vector3 (1, 0, 0);
				
			}
			
		}else if (turn == true &&( turn_cnt%180 !=0 || turn_cnt ==0)) {
			transform.Rotate (0, 1, 0);
			turn_cnt++;

		} else if (turn == true && turn_cnt%180 ==0) {
			direction = false;
			if (turn_cnt == 360) {
				turn_cnt = 0;
				direction = true;
			}
			turn_cnt++;
			turn = false;
		}
	
	}
}
