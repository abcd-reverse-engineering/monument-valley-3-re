using UnityCommon;
using UnityEngine;

public class DuplicateAndFlip : MonoBehaviour
{
	[SerializeField]
	private GameObject _original;

	[SerializeField]
	[Tooltip("Set a specific material for the duplicated object. Leave empty if not needed.")]
	private Material _material;

	[Tooltip("Set a parent for the duplicated object. Leave empty if not needed.")]
	[SerializeField]
	private Transform _parentTransform;

	[SerializeField]
	private EditorButton _refresh;

	[SerializeField]
	[HideInInspector]
	private GameObject _copy;

	public void Refresh()
	{
	}

	private string GetRelativeScenePath(Transform transform, Transform ancestor)
	{
		return null;
	}
}
