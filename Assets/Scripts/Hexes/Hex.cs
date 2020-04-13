using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex {

	public readonly int Q; // Column
	public readonly int R; //Row
	public readonly int S;

	readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;

	//Q+R+S = 0
	//S = -(Q+R)
	public Hex(int q, int r)
	{
		this.Q = q;
		this.R = r;
		this.S = -(q + r);
	}

	public Vector3 Position()
	{
		float radius = 1.45f;
		float height = radius * 2;
		float width = WIDTH_MULTIPLIER * height;

		float horiz = width;
		float vert = height * 0.80f;

		return new Vector3(
		horiz * (this.Q + this.R/2f - this.R / 2),
		0,
		vert * this.R

		);
	}
}