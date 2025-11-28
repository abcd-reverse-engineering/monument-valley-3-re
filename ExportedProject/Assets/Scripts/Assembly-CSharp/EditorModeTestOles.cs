using System.Collections.Generic;
using UnityCommon;
using UnityEngine;

public class EditorModeTestOles : MonoBehaviour
{
	public EditorButton createCube;

	public EditorButton destroyCube;

	[SerializeField]
	private GameObject prefab;

	private GameObject instance;

	private List<GameObject> instances;

	public void InstantiateCube()
	{
	}

	public void DeleteCube()
	{
	}
}
