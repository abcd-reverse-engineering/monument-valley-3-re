using GameLogic;
using UnityEngine;

public class RegenSculptWithController : MonoBehaviour
{
	[SerializeField]
	private GameObject _selectorRotatorGroup;

	[SerializeField]
	private GameObject _mySelectorRotator;

	[SerializeField]
	private Material _highlightMaterial;

	[SerializeField]
	private float ControllerMoveDuration;

	private Material _defaultMaterial;

	[Action(null)]
	public void EnableControllerAndHightlightMesh()
	{
	}

	[Action(null)]
	public void DisableControllerAndRomoveHighlight()
	{
	}

	private void EnableSelectorRotator()
	{
	}

	private void ChangeMaterial(bool isHighlighted)
	{
	}
}
