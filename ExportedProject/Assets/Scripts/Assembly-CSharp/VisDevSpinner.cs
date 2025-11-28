using UnityEngine;

public class VisDevSpinner : MonoBehaviour
{
	[SerializeField]
	private Vector3 _axis;

	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _scaleMin;

	[SerializeField]
	private float _scaleMax;

	[SerializeField]
	private ParticleSystem _bokehParticles;

	[SerializeField]
	private float randomOffset;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
