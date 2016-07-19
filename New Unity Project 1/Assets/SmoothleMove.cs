using UnityEngine;
using System.Collections;

public class SmoothleMove : MonoBehaviour {
	//public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	public TouchEvent TE;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Move (Vector3 target)
	{
		Vector3 targetPosition = target;
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}
}
