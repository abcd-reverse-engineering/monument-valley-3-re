using UnityEngine;

public class JetsplashManager : MonoBehaviour
{
	[SerializeField]
	private LayerMask _layerMask;

	[SerializeField]
	private Animator _waterImpactAnimator;

	[SerializeField]
	private ParticleSystem _geoImpactParticleSystem;

	[SerializeField]
	private ProgressMeshGenerator _jetGenerator;

	private void Update()
	{
	}

	private void SetWaterImpactState(bool value)
	{
	}

	private void SetGeoImpactParticles(bool value)
	{
	}
}
