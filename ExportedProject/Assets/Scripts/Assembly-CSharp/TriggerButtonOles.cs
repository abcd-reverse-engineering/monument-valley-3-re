using System.Runtime.CompilerServices;

public class TriggerButtonOles : TriggerWithEventOles
{
	public delegate void TriggerActionDelegate();

	public event TriggerActionDelegate OnButtonTrigger
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
