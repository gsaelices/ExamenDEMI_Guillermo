using UnityEngine;
using System.Collections;

public class ControlarJugardor2 : MonoBehaviour {
	
	public float velocidadMovimiento;

	void Start () {


	}


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.W))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.x);
		}

		if (Input.GetKeyDown (KeyCode.S))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.x);
		}


		if (Input.GetKeyDown (KeyCode.D))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKeyDown (KeyCode.A))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}



