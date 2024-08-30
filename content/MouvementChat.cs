using Godot;
using System;

public partial class MouvementChat : PathFollow2D
{
	[Export]
	private float Vitesse = 0.01f;

	[Export]
	private PackedScene VilainBoulet;

	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("Chat_Avance"))
		{
			ProgressRatio += Vitesse * (float)delta;
		}else if(Input.IsActionPressed("Chat_Recule"))
		{
			ProgressRatio -= Vitesse * (float)delta;
		}

		if (Input.IsActionJustPressed("Chat_Tire"))
		{
			BalleVilain balleVilain = VilainBoulet.Instantiate<BalleVilain>();
			balleVilain.Position = this.Position;
			this.GetTree().CurrentScene.AddChild(balleVilain);
		}
	}
}
