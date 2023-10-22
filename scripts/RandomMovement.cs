using Godot;
using System;

public class RandomMovement : Sprite
{
	float speed = 5;

	public override void _Process(float delta) {
		uint randomNumber = GD.Randi() % 4;

		if (randomNumber == 0) { Position += new Vector2(-speed, 0); }
		if (randomNumber == 1) { Position += new Vector2(speed, 0); }
		if (randomNumber == 2) { Position += new Vector2(0, -speed); }
		if (randomNumber == 3) { Position += new Vector2(0, speed); }
	}
}
