using UnityEngine;

[ExecuteInEditMode]
public class MultiStableVoxelGear : MonoBehaviour
{
	private enum InputType
	{
		Translate = 0,
		Rotate = 1
	}

	private enum HideType
	{
		AfterRotation = 0,
		BeforeRotation = 1,
		None = 2
	}

	[SerializeField]
	private Mover _inputMover;

	[SerializeField]
	private MultiStableVoxel[] _outputVoxels;

	[SerializeField]
	private AnimationCurve _outputCurve;

	[SerializeField]
	private InputType _inputType;

	[SerializeField]
	private bool _flipInput;

	[SerializeField]
	private HideType _hide;

	private void Start()
	{
	}

	private void SetOutputGears()
	{
	}

	private void Update()
	{
	}

	private void UpdateDisplacement()
	{
	}

	private float GetMoverDisplacement(Mover mover)
	{
		return 0f;
	}

	private float GetMoverRotation(Mover mover)
	{
		return 0f;
	}
}
