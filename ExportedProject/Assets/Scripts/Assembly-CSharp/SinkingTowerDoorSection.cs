using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SinkingTowerDoorSection : MonoBehaviour
{
	[Serializable]
	public class RaftBoardingMap
	{
		public RaftAttractPoint raftAttractPoint;

		public Transform boardingTargetA;

		public Transform boardingTargetB;
	}

	[CompilerGenerated]
	private sealed class _003CCharacterRunRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int nextDoorIndex;

		public SinkingTowerDoorSection _003C_003E4__this;

		public CharacterController characterController;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCharacterRunRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CNavToRaftRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterController supportController;

		public RaftScript raftScript;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNavToRaftRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SinkingTowerDoorSection _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Door[] _doors;

	[SerializeField]
	private CharacterController[] _bottomRowCharacters;

	[SerializeField]
	private CharacterController[] _topRowCharacters;

	[SerializeField]
	private SinkingTowerDoorSection _nextSection;

	[SerializeField]
	private RaftBoardingMap[] _raftBoardingMaps;

	[IteratorStateMachine(typeof(_003CStart_003Ed__6))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnCharacterExitedDoor0(CharacterController characterReference)
	{
	}

	private void OnCharacterExitedDoor2(CharacterController characterReference)
	{
	}

	private bool TryNavToRaft(CharacterController characterReference)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CNavToRaftRoutine_003Ed__10))]
	private IEnumerator NavToRaftRoutine(CharacterController supportController, RaftScript raftScript)
	{
		return null;
	}

	private NavFace GetClosestNav(Transform target)
	{
		return null;
	}

	private void NavTo(CharacterController character, NavFace navFace)
	{
	}

	[IteratorStateMachine(typeof(_003CCharacterRunRoutine_003Ed__13))]
	private IEnumerator CharacterRunRoutine(CharacterController characterController, int nextDoorIndex)
	{
		return null;
	}
}
