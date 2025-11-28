using UnityEngine;

public class RotateBasedOnLocalRotationMVTwo : MonoBehaviour
{
	[Tooltip("Object that will be used as local frame for when the triggerButton object changes orientation")]
	public Transform rootObject;

	[Tooltip("Object whose rotation respect to root object is used to triggerButton the rotation of root object")]
	public Transform triggerObject;

	[Tooltip("Orientation for root object when triggerButton object up direction (respect to root object orientation) points in X direction")]
	public Transform xOrientation;

	[Tooltip("Orientation for root object when triggerButton object up direction (respect to root object orientation) points in Y direction")]
	public Transform yOrientation;

	[Tooltip("Orientation for root object when triggerButton object up direction (respect to root object orientation) points in Z direction")]
	public Transform zOrientation;

	[Tooltip("Makes the orientation change faster of slower")]
	public float speedScale;

	private void Update()
	{
	}
}
