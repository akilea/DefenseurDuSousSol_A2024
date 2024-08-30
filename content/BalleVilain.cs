using Godot;
using System;

public partial class BalleVilain : RigidBody2D
{
	[Export]
	private Vector2 Vitesse = new Vector2(100.0f, 0.0f);

	public override void _Ready()
	{
		LinearVelocity = Vitesse;
	}
}
