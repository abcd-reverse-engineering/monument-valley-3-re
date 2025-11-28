using GameLogic;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
public class MultiStableVoxel : GearDriver
{
	[SerializeField]
	private MeshRenderer[] _meshes;

	[SerializeField]
	public bool _flipDirection;

	[SerializeField]
	private bool _startMultiStable;

	[SerializeField]
	private float _moveInDepthWhileRotating;

	[FormerlySerializedAs("_EnableWhenHidden")]
	[SerializeField]
	private GameObject[] _enableWhenHidden;

	[SerializeField]
	private Mover _moverOutput;

	[SerializeField]
	private bool _preview;

	[Range(0f, 60f)]
	[SerializeField]
	private float _previewValue;

	private MaterialPropertyBlock _propBlock;

	private MoverCharacterDetector _characterDetector;

	private bool _isMovedInDepth;

	private void OnValidate()
	{
	}

	private void UpdateMultiStableProperties()
	{
	}

	public void SetVoxelRotation(float angle)
	{
	}

	private void MoveInDepth(float depth)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public bool CharacterOnVoxel()
	{
		return false;
	}

	[Action(null)]
	public void FlipRotation(bool flip)
	{
	}
}
