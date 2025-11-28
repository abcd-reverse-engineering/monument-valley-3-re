using UnityCommon;
using UnityEngine;

public class VoxelSphere : MonoBehaviour
{
	public EditorButton createSphere;

	public EditorButton deleteSphere;

	[SerializeField]
	private int _radius;

	private int cx;

	private int cy;

	private int cz;

	private int gridSize;

	[SerializeField]
	private GameObject _voxelPrefab;

	[SerializeField]
	private Transform _sphereParent;

	[SerializeField]
	private Transform _oneHalf;

	[SerializeField]
	private Transform _secondHalf;

	private Transform[] oneHalfLayers;

	private Transform[] secondHalfLayers;

	private bool _isInitialized;

	private void Start()
	{
	}

	public void DeleteVoxelSphere()
	{
	}

	public void GenerateVoxelSphere()
	{
	}

	private void InitializeParameters()
	{
	}

	private void CreateLayerParents()
	{
	}

	private void CreateSphere()
	{
	}
}
