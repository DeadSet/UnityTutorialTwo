using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	public GameController gameController; //assign gamecontroller script in inspector
	public int missPenalty; 

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Asteroid") {
			gameController.AddScore (missPenalty);
		}
		Destroy(other.gameObject);

		
	}

	

}
