using UnityEngine;

public class MagicCubeMultistableScript : MonoBehaviour
{
	private enum MovementState
	{
		None = 0,
		Top = 1,
		Right = 2,
		Front = 3
	}

	[SerializeField]
	private int _cubesPerSlice;

	[SerializeField]
	private Transform[] _cubes;

	[SerializeField]
	private Transform[] _internalCubes;

	[SerializeField]
	private Mover _topMover;

	[SerializeField]
	private Mover _rightMover;

	[SerializeField]
	private Mover _frontMover;

	[SerializeField]
	private Mover _topInternalMover;

	[SerializeField]
	private Mover _rightInternalMover;

	[SerializeField]
	private Mover _frontInternalMover;

	[SerializeField]
	private CharacterController _playerCharacter;

	private MovementState _currentMovementState;

	private void Start()
	{
	}

	private void RotatorStateChanged(MoverRotator.State state)
	{
	}

	private void RefreshNav()
	{
	}

	private void ReparentFrontMostCubes()
	{
	}

	private void ReparentRightMostCubes()
	{
	}

	private void ReparentTopMostCubes()
	{
	}
}
