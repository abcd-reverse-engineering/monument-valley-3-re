using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveInOnePosOles : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveObjectRoutineWithinTime_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoveInOnePosOles _003C_003E4__this;

		public float totalMoveTime;

		private Vector3 _003CtargetPosition_003E5__2;

		private float _003CmoveStartTime_003E5__3;

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
		public _003CMoveObjectRoutineWithinTime_003Ed__8(int _003C_003E1__state)
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

	private Vector3 _pos;

	public TriggerDoorOles door;

	private bool _isComplete;

	private float _delay;

	private void OnEnable()
	{
	}

	private void FindTriggerAndSubscribe()
	{
	}

	private void OnDisable()
	{
	}

	private void MoveCubeToPos()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveObjectRoutineWithinTime_003Ed__8))]
	private IEnumerator MoveObjectRoutineWithinTime(float totalMoveTime)
	{
		return null;
	}
}
