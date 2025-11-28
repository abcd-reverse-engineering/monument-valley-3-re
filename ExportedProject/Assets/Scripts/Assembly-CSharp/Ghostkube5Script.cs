using UnityEngine;

public class Ghostkube5Script : MonoBehaviour
{
	[SerializeField]
	private Mover _yMover;

	[SerializeField]
	private Mover _zMover;

	[SerializeField]
	private GearDriver[] _gearsToInvertAtY180;

	[SerializeField]
	private float _zUnlockYAngle;

	private float[] _originalGearedMultipliers;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
