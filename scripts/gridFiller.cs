using Godot;
using System;
using System.Drawing;

public class gridFiller : GridContainer {
	public override void _Ready() {
		Vector2 cellSize = RectSize / Columns;

		PackedScene gridItem = GD.Load<PackedScene>("res://scenes/gridBlock.tscn");
		ColorRect instance = (ColorRect)gridItem.Instance();
		instance.RectMinSize = cellSize;
		AddChild(instance);
	}
}
