using UnityEngine;
using UnityEngine.Serialization;

public class DoorOpener : MonoBehaviour
{
	[FormerlySerializedAs("trigger")]
	public TriggerButtonOles triggerButton;

	public string doorObjectName;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FindTriggerAndSubscribe()
	{
	}

	public void OpenDoorOnTrigger()
	{
	}
}
