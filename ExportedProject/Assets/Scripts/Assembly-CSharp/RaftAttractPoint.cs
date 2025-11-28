using UnityEngine;

public class RaftAttractPoint : MonoBehaviour, IDiscoverable<RaftAttractPoint>
{
	[SerializeField]
	private Color _gizmoColor;

	[field: SerializeField]
	public float Radius { get; private set; }

	[field: SerializeField]
	public int Priority { get; private set; }

	[field: SerializeField]
	public bool SnapAngle { get; private set; }

	public float RadiusSqr => 0f;

	public RaftScript Occupier { get; set; }

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
