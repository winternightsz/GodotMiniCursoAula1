using Godot;
using System;

public partial class Sprite2d : Sprite2D
{
	// Chamado quando o Node entra na cena pela primeira vez.
	public override void _Ready()
	{
		Position = new Vector2(100, 100);
	}

	// Chamado cada frame. 'delta' é o tempo aproximado de um frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("cimaW")){
			Position += new Vector2(0, -1);
		}
		if (Input.IsActionPressed("baixoS")){
			Position += new Vector2(0, 1);
		}
		if (Input.IsActionPressed("esquerdaA")){
			Position += new Vector2(-1, 0);
		}
		if (Input.IsActionPressed("direitaD")){
			Position += new Vector2(1, 0);
		}
	}
}
