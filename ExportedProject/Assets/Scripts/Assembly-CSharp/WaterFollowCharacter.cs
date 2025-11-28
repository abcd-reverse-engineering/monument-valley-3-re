using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameLogic;
using UnityEngine;

public class WaterFollowCharacter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangePosition_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterFollowCharacter _003C_003E4__this;

		public Vector3 direction;

		private Vector3 _003CnewPosition_003E5__2;

		private Vector3 _003CinitialPosition_003E5__3;

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
		public _003CChangePosition_003Ed__21(int _003C_003E1__state)
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
	private Transform[] _followTargets;

	[SerializeField]
	private float _startWaterLevelPos;

	[SerializeField]
	private float _targetWaterLevelPos;

	private Vector3 _moveDistance;

	[SerializeField]
	private float _delta;

	private float _waterPosDelta;

	[SerializeField]
	private float _transitionDuration;

	private float _transitionStartTime;

	private float _t;

	private float _difference;

	private bool _isTransition;

	private bool _isAllowRaise;

	private bool _shouldMove;

	public float TransitionDuration
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	[Action(null)]
	public void Raise(bool isEnabled)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void MoveUp()
	{
	}

	private void Move(Vector3 direction)
	{
	}

	[IteratorStateMachine(typeof(_003CChangePosition_003Ed__21))]
	private IEnumerator ChangePosition(Vector3 direction)
	{
		return null;
	}
}
