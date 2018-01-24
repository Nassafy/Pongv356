using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 30;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeigth)
    {
        return (ballPos.y - racketPos.y) / racketHeigth;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "RacketLeft")
        {

        }
    }
}
