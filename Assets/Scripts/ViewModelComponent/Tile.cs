﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public const float stepHeight = 0.25f;

	public Point pos;
	public int height;

	public Vector3 center {
		get {
			return new Vector3(pos.x, height * stepHeight, pos.y);
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Specific Methods
	void Match ()
	{
		transform.localPosition = new Vector3( pos.x, height * stepHeight / 2f, pos.y );
		transform.localScale = new Vector3(1, height * stepHeight, 1);
	}

	public void Grow ()
	{
		height++;
		Match();
	}

	public void Shrink ()
	{
		height--;
		Match ();
	}

	//Load a certain type of tile
	public void Load (Point p, int h)
	{
		pos = p;
		height = h;
		Match();
	}

	public void Load (Vector3 v)
	{
		Load (new Point((int)v.x, (int)v.z), (int)v.y);
	}
}
