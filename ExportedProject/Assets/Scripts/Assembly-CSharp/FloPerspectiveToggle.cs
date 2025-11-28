using UnityEngine;

public class FloPerspectiveToggle : MonoBehaviour
{
	private Camera _camera;

	public Matrix4x4 matrix_a;

	public Matrix4x4 matrix_b;

	[Range(0f, 1f)]
	public float interpolation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private static Matrix4x4 InterpolateMatrix4x4(Matrix4x4 a, Matrix4x4 b, float t)
	{
		return default(Matrix4x4);
	}

	[ContextMenu("Set Matrix A from Camera")]
	private void SetMatrixAFromCamera()
	{
	}

	[ContextMenu("Set Matrix B from Camera")]
	private void SetMatrixBFromCamera()
	{
	}
}
