using System.Runtime.CompilerServices;

public class TriggerDoorOles : TriggerWithEventOles
{
	public delegate void TriggerActionDelegate();

	public event TriggerActionDelegate OnDoorTrigger
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void TriggerEvent()
	{
	}
}
