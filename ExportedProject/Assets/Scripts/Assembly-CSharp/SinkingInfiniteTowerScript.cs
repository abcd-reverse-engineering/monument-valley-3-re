using System.Collections.Generic;
using GameLogic;
using UnityEngine;

public class SinkingInfiniteTowerScript : MonoBehaviour
{
	[SerializeField]
	private float _sinkSpeed;

	private Vector3 _sinkDirection;

	private Vector3 _teleportSectionVector;

	private float _teleportThreshold;

	private Queue<Transform> _sectionsQueue;

	private Vector3 _startPosition;

	private bool _stopTeleportingSections;

	[Action(null)]
	public void StopTeleportingSections()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
