using UnityEngine;
using System.Collections;
using System;

public class RondamPoint : MonoBehaviour {

	public static System.Random ran = new System.Random(Guid.NewGuid().GetHashCode());
	public Vector2 TheWordPoint;
	public RectTransform TheWordRect;
	public Vector2 TrackPoint;
	public float R = 1f;
	public float degress = 0;
	public float angle;
	public GameObject Point;

	//public float smoothTime = 0.3F;
	//private Vector3 velocity = Vector3.zero;
	// Use this for initialization
	void Start () {
		Point = GameObject.Find ("Point");
		TheWordRect = GetComponent<RectTransform> ();
		TheWordPoint = TheWordRect.anchoredPosition;
		TrackPoint = new Vector2 (TheWordPoint.x + R * Mathf.Cos (angle), TheWordPoint.y + R * Mathf.Sin (angle));
	}
	
	// Update is called once per frame
	void Update () {
		float RandomNum = (float)ran.NextDouble()-0.5f;
		angle += RandomNum*100f;
		angle = (float)(angle % Math.PI);
		//angle = (float)Math.PI * degress/180.0f;
		TheWordPoint = TheWordRect.anchoredPosition;
		TrackPoint = new Vector2 (TheWordPoint.x + R * Mathf.Cos (angle), TheWordPoint.y + R * Mathf.Sin (angle));

		TheWordRect.position = Vector2.MoveTowards (TheWordRect.position, TrackPoint, 30f * Time.deltaTime);
		//transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (TrackPoint.x, TrackPoint.y, 0), 30f * Time.deltaTime);
		//transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(TrackPoint.x,TrackPoint.y,0), ref velocity, smoothTime);
		Point.GetComponent<RectTransform>().anchoredPosition = new Vector2 (TrackPoint.x, TrackPoint.y);
		}
}
