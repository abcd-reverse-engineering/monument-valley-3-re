using UnityEngine;

public class StickyChild : MonoBehaviour
{
	private Transform _originalMoverParent;

	[field: SerializeField]
	public Mover Mover { get; private set; }

	private void Awake()
	{
	}

	public void ResetMoverParenting()
	{
	}
}
