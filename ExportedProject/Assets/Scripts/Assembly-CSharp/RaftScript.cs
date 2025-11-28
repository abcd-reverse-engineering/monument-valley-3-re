using GameLogic;
using UnityEngine;

public class RaftScript : MonoBehaviour
{
	private RaftAttractPoint _currentAttractPoint;

	public NavFace navFace;

	public CharacterController rider;

	[BooleanMethod]
	public bool HasRider()
	{
		return false;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OccupyAttractPoint(RaftAttractPoint attractPoint)
	{
	}

	private void VacateAttractPoint()
	{
	}
}
