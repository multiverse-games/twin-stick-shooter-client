using Godot;

public class IPInputBox : LineEdit
{
	public override void _Ready()
	{
		Connect("text_changed", this, nameof(_TextChanged));
	}

	private void _TextChanged(string newText)
	{
		if (newText.Contains(":"))
		{
			string[] newTextSplit = newText.Split(":");

			Client.ip = newTextSplit[0];
			Client.port = newTextSplit[1];
		}
		else
		{
			Client.ip = newText;
			Client.port = "24465";
		}
	}
}
