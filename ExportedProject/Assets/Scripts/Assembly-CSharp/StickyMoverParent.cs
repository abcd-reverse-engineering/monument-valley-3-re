using System.Collections.Generic;
using UnityEngine;

public class StickyMoverParent : MonoBehaviour
{
	[SerializeField]
	private Mover _parentMover;

	[SerializeField]
	private float _stickDistance;

	[SerializeField]
	private Transform[] _stickyPoints;

	[SerializeField]
	private StickyChild[] _stickyChildren;

	private List<StickyChild> _stuckChildren;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRotatorStateChanged(MoverRotator.State state)
	{
	}
}
