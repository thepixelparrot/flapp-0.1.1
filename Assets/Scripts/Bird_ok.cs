using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_ok : MonoBehaviour {
	public float upForce = 200f;
	public float rightForce = 100f;
	public float leftForce = 100f;
    private bool isDead = false;
	private Rigidbody2D rb2d;
	private bool SetComponent;

	private Animator anim;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false){
			if(Input.GetMouseButtonDown(1)){

				rb2d.velocity = Vector2.zero;
				rb2d.velocity = Vector2.right;
				rb2d.AddForce (new Vector2 (1, upForce));
				rb2d.AddForce (new Vector2(1, rightForce ));
                anim.SetTrigger("Flap");
			}
			if(Input.GetMouseButtonDown(0)){

				rb2d.velocity = Vector2.zero;
				rb2d.velocity = Vector2.left;
				rb2d.AddForce (new Vector2 (1, upForce));
				rb2d.AddForce (new Vector2(1, leftForce ));
                anim.SetTrigger("FlapL");
			}
		}
	}
    public void OnCollisionEnter2D (Collision2D coll){
		if(coll.gameObject.tag.Equals("EndBox")){
           GameController.instance.BirdWin();
			rb2d.Sleep();
          }
		else{
		    isDead = true;
		    anim.SetTrigger("Die");
		    GameController.instance.BirdDied();
            rb2d.Sleep();
        }
	}
}


