using Godot;
using System;

public class Sprite : Godot.Sprite
{
	[Export] float speed;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		Vector2 move = new Vector2(0, 0);

		if (Input.IsKeyPressed((int)KeyList.W)) { move += new Vector2(0, -1); }
		if (Input.IsKeyPressed((int)KeyList.A)) { move += new Vector2(-1, 0); }
		if (Input.IsKeyPressed((int)KeyList.S)) { move += new Vector2(0, 1); }
		if (Input.IsKeyPressed((int)KeyList.D)) { move += new Vector2(1, 0); }

		Position += move.Normalized() * speed;
	}
}
