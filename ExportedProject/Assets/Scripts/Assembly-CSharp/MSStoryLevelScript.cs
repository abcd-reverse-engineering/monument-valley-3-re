using GameLogic;
using UnityEngine;

public class MSStoryLevelScript : MonoBehaviour
{
	[SerializeField]
	private Mover _mainMover;

	[SerializeField]
	private EaseDriver _mainDriver;

	[Action(null)]
	public void StartEndRotation(float duration, float normalRotation)
	{
	}
}
