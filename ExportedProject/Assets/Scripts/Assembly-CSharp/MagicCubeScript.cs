using UnityEngine;

public class MagicCubeScript : MonoBehaviour
{
	private enum MovementState
	{
		None = 0,
		Top = 1,
		Right = 2,
		Front = 3
	}

	[SerializeField]
	private Transform[] _cubes;

	[SerializeField]
	private Mover _topMover;

	[SerializeField]
	private Mover _rightMover;

	[SerializeField]
	private Mover _frontMover;

	private MovementState _currentMovementState;

	private void Start()
	{
	}

	private void RotatorStateChanged(MoverRotator.State state)
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
