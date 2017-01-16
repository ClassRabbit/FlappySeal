using UnityEngine;
using System.Collections;

public class ClearTrigger : MonoBehaviour {

	GameObject gameController;

	void Start()
	{
		gameController = GameObject.FindWithTag("GameController");
	}

	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("exit!");
		gameController.SendMessage("IncreaseScore");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("OnCollision");
	}
}
