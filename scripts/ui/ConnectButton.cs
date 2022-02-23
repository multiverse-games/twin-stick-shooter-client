using Godot;

public class ConnectButton : Button
{
	public override void _Ready()
	{
		Connect("pressed", this, nameof(_OnPress));
	}

	private void _OnPress()
	{
		Client.StartClient();
	}
}
