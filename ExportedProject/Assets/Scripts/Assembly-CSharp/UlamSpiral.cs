using System.Collections.Generic;
using UnityCommon;
using UnityEngine;

public class UlamSpiral : MonoBehaviour
{
	public EditorButton createSpiral;

	public EditorButton deleteSpiral;

	public GameObject cubePrefab;

	public GameObject cubePrefabWithDoor;

	public GameObject cubePrefabWithTrigger;

	private int _exitIndex;

	private int _triggerIndex;

	private Dictionary<int, GameObject> indexToPrefab;

	public int spiralLength;

	private int _currentX;

	private int _currentZ;

	private bool _isInitialized;

	private Transform _root;

	public void DeleteSpiralInEditor()
	{
	}

	private void InitializePrefabDictionary()
	{
	}

	public void GenerateUlamSpiral()
	{
	}

	private void CheckAndInstantiatePrime(ref int currentNumber, ref int primeCount)
	{
	}

	private void InstantiateCube(GameObject prefab, int currentNumber)
	{
	}

	private string GetCubeName(GameObject prefab, int currentNumber)
	{
		return null;
	}

	private void SetParent(Transform parent, Transform child)
	{
	}

	private bool IsPrime(int number)
	{
		return false;
	}

	private void Right()
	{
	}

	private void Up()
	{
	}

	private void Left()
	{
	}

	private void Down()
	{
	}
}
