using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class KeepWithinScreen : MonoBehaviour
{
    private Renderer rend;
    private Camera cam;
    private Bounds camBounds;
    private float camWidth, camHeight;

	// Use this for initialization
	void Start ()
    {
        cam = Camera.main;
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void UpdateCamBounds ()
    {
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
        camBounds = new Bounds(cam.transform.position, new Vector3(camWidth, camHeight));
	}
}
