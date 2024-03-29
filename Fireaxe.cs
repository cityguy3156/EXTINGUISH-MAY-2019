using UnityEngine;
using System.Collections;

public class Fireaxe : MonoBehaviour {

	//ANIMATOR
	Animator anim;

	GameObject enemy;

//	GameObject camera;
//
//	public float zoomSpeed;
//	public float targetOrtho;
//
//	public float targetY;
//
//	public float smoothSpeed;
//	public float minOrtho;
//	public float maxOrtho;

	//SOUNDS
	public AudioClip punch1;
	public AudioClip punch2;
	public AudioClip punch3;

	DealDamage playerScript;

	public float damage = 1f;



	GameObject[] boundaries;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		boundaries = GameObject.FindGameObjectsWithTag ("Boundary");

//		targetOrtho = Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update () {
	
		// NOT Attacking
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Idle")) {
			anim.SetBool ("Attacking", false);
		}
			
		//Light Attack
		if (Input.GetKeyDown (KeyCode.X)) {
			anim.SetBool ("Attacking", true);
			anim.Play ("X");
			damage = 1f;
		}
		//Heavy Attack
		if (Input.GetKeyDown (KeyCode.Y)) {
			anim.SetBool ("Attacking", true);
			anim.Play ("Y");
			damage = 8f;
		}
		//}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("X")) {
			if (Input.GetKeyDown (KeyCode.X)) {
				anim.Play ("XX");
				damage = 3f;
			}
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("XX")) {
			if (Input.GetKeyDown (KeyCode.X)) {
				anim.Play ("XXX");
				damage = 5f;				
			}
		}


//		if (anim.GetBool ("Attacking") == true) {
//			ZoomIn ();
//		}
//		if (anim.GetBool ("Attacking") == false) {
//			ZoomOut ();
//		}
//		foreach (GameObject boundary in boundaries)
//		{
//			// ZOOM INTO PLAYER
//			float distance = Mathf.Abs(Vector2.Distance(transform.position,boundary.transform.position) );
//			if (distance < 5f && anim.GetBool("Attacking") == true) {
//				targetOrtho -= zoomSpeed;
//				targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
//			} else {
//				targetOrtho += zoomSpeed;
//				targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
//
//				Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
//			}
//		}


//		GameObject thePlayer = GameObject.Find("Fireaxe");
//		playerScript.AXE_damage = damage;
	}
}
