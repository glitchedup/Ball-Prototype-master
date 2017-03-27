﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
    public GameObject gameOver;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        

    }
	
	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("HorizontalA");
		float moveVertical = Input.GetAxis ("VerticalA");
        transform.Translate(0, 0, 0.1f * Time.deltaTime);
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("killer"))
		{
			Debug.Log("game over A");
            gameOver.SetActive(true);
            Time.timeScale = 0;

		}
	}
}