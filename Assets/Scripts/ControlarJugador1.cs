using UnityEngine;
using System.Collections;

public class ControlarJugador1 : MonoBehaviour {


	public float velocidadMovimiento;

	void Start () {


	}


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.x);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.x);
		}


		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocidadMovimiento, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}

