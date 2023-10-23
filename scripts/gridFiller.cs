using Godot;
using System;
using System.Drawing;

public class gridFiller : GridContainer {
	public override void _Ready() {
		Vector2 cellSize = RectSize / Columns;

		PackedScene gridBlock = GD.Load<PackedScene>("res://scenes/gridBlock.tscn");
		PackedScene puzzleBlock = GD.Load<PackedScene>("res://scenes/puzzleBlock.tscn");

		for (int x = 0; x < Columns; x++) {
			for (int y = 0; y < Columns; y++) {
				ColorRect instance;

				if (y % 2 == 0) { instance = (ColorRect)gridBlock.Instance(); }
				else { instance = (ColorRect)puzzleBlock.Instance(); }

				instance.RectMinSize = cellSize;
				AddChild(instance);
			}
		}
	}
}
