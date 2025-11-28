using GameLogic;
using UnityEngine;

public class MoverIsolator : MonoBehaviour
{
	[SerializeField]
	private Mover _mover;

	[SerializeField]
	private CharacterLocomotionController _characterLocomotionController;

	private Vector3 _moverStartPosition;

	private Quaternion _moverStartRotation;

	private NavFace _charactersLastNavFace;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	[Action(null)]
	public void SetMoverToIsolate(Mover mover)
	{
	}
}
