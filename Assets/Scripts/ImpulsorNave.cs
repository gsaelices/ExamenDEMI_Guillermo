using UnityEngine;
using System.Collections;

public class ImpulsorNave : MonoBehaviour {

	public float velocidadMovimiento;

	void Start () {


	}


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.x);
		}
			
	}
}


