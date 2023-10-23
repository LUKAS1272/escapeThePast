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

				instance = (ColorRect)gridBlock.Instance();
				instance.RectMinSize = cellSize;
				AddChild(instance);
				Label instanceLabel = (Label)instance.GetChild(0).GetChild(0);
				
				DynamicFont preset = (DynamicFont)instanceLabel.Get("custom_fonts/font");
				preset.Size = (int)(instanceLabel.RectSize.x / instanceLabel.Text.Length * 0.65);
			}
		}
	}
}
