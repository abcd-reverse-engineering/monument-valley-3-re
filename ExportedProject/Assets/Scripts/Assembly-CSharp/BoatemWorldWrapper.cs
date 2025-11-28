using System.Collections.Generic;
using GameLogic;
using UnityEngine;

public class BoatemWorldWrapper : MonoBehaviour
{
	public Vector2 bounds;

	public Color debugColour;

	public SailingBoatMoverPhysical boat;

	[Header("World-wrapping impostor setup")]
	public bool setUpImpostorsAtStart;

	public List<GameObject> gameObjectsToDuplicateAtStart;

	private List<GameObject> instantiatedImpostors;

	private Rigidbody _boatRigidbody;

	private void Start()
	{
	}

	[Action(null)]
	public void CreateWorldWrappingImpostors()
	{
	}

	private void DuplicateObject(GameObject original)
	{
	}

	private void FixedUpdate()
	{
	}

	private void TeleportBoat(Vector3 newPosition)
	{
	}

	[Action(null)]
	public void UpdateWrappingBounds(Vector2 newBounds)
	{
	}

	private Vector3? GetPositionWithinBounds(Vector3 currentPosition)
	{
		return null;
	}

	private bool IsPositionWithinBounds(Vector3 position)
	{
		return false;
	}

	private bool IsValueWithinRange(float value, float min, float max)
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
