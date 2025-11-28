using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public class PhysicsWheelHandler : MonoBehaviour
{
	[SerializeField]
	private Transform _playerTransform;

	[SerializeField]
	private float _acceleration;

	[SerializeField]
	private float _stoppingThreshold;

	[SerializeField]
	private float _friction;

	private float3 _rotationAxis;

	private float3 _wheelTop;

	private float _currentRotationSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Vector3 GetToPlayerVector()
	{
		return default(Vector3);
	}

	private static void UpdateRotationSpeed(in float3 toPlayer, in float3 wheelTop, in float3 rotationAxis, ref float currentRotationSpeed, float acceleration, float friction, float stoppingThreshold)
	{
	}

	private static float MoveTowards(float current, float target, float maxDelta)
	{
		return 0f;
	}

	private static float GetAngleToPlayer(float3 toPlayer, float3 wheelTop)
	{
		return 0f;
	}

	private static float CalculateRotationAmount(float angle)
	{
		return 0f;
	}

	private static float DetermineRotationDirection(float3 toPlayer, float3 wheelTop, float3 rotationAxis)
	{
		return 0f;
	}
}
