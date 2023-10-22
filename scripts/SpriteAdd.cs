using Godot;
using System;

public class SpriteAdd : Node2D
{
	PackedScene spriteScene;

	public override void _Ready() {
		spriteScene = GD.Load<PackedScene>("res://scenes/spriteScene.tscn");
	}

	public override void _UnhandledInput(InputEvent @event) {
		if (@event is InputEventMouseButton mouseClick && mouseClick.Pressed) {
			Sprite instance = (Sprite)spriteScene.Instance();
			instance.Position = mouseClick.Position;
			AddChild(instance);
			GD.Print(GetChildCount());
		}
	}
}
