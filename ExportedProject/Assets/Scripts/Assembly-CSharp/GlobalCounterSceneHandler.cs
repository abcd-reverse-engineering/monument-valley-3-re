using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCounterSceneHandler : MonoBehaviour, ITestable
{
	[SerializeField]
	private GlobalCounter _globalCounter;

	[SerializeField]
	private TMP_Text counterText;

	[SerializeField]
	private Button increaseButton;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateCounterText(int value)
	{
	}

	public void OnButtonPressed()
	{
	}

	public void RunUnitTest()
	{
	}
}
