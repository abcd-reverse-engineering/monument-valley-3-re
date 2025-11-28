using UnityEngine;

[ExecuteInEditMode]
public class MultiStableLerpGear : MonoBehaviour
{
	[SerializeField]
	private Mover _mover;

	[SerializeField]
	private MeshRenderer _geoChunk;

	private MaterialPropertyBlock _propBlock;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
