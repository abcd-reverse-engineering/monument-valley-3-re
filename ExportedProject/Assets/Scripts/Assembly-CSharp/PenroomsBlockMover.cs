using System.Collections.Generic;
using UnityEngine;

public class PenroomsBlockMover : MonoBehaviour
{
	[SerializeField]
	private CharacterController _character;

	[SerializeField]
	private CharacterController _totemCharacter;

	[SerializeField]
	private List<Transform> _blockTransforms;

	[SerializeField]
	private float _moveDistance;

	private NavFace _currentNavFace;

	private Dictionary<Transform, Vector3> _originalPositions;

	private int _currentBlockIndex;

	private BaseCharacterLocomotion _baseCharacterLocomotion;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool IsBlockIndexInRange(int index)
	{
		return false;
	}
}
