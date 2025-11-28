using UnityEngine;

[ExecuteInEditMode]
public class CustomGearDriverTransitionManager : MonoBehaviour, IDiscoverable<GearDriver>
{
	[ValidateObject(typeof(Mover))]
	public Mover moverInput;

	public float gearedMultiplier;

	public float angleOffset;

	[Tooltip("Whether the gearing is active or not")]
	public bool isActive;

	public float rotationThreshold;

	public CustomShapeTransitioner shapeTransitioner;

	public void Reset()
	{
	}

	public virtual void Start()
	{
	}

	public void Update()
	{
	}
}
