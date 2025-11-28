using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomShapeTransitioner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangePosition_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomShapeTransitioner _003C_003E4__this;

		public int index;

		private Vector3 _003CinitialPosition_003E5__2;

		private Vector3 _003CtargetPosition_003E5__3;

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
		public _003CChangePosition_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CChangeRotation_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomShapeTransitioner _003C_003E4__this;

		public int index;

		private Quaternion _003CinitialRotation_003E5__2;

		private Quaternion _003CtargetRotation_003E5__3;

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
		public _003CChangeRotation_003Ed__23(int _003C_003E1__state)
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
	private GameObject chunk;

	[SerializeField]
	private GameObject staticChunk;

	private Vector3 _startRotation;

	private Vector3 _pose1Rotation;

	private Vector3 _pose2Rotation;

	private Vector3 _pose3Rotation;

	private Vector3 _startStartPos;

	private Vector3 _pose1Pos;

	private Vector3 _pose2Pos;

	private Vector3 _pose3Pos;

	private Vector3[] _rotations;

	private Vector3[] _staticPositions;

	private int _currentIndex;

	private bool _isTransition;

	private float _transitionDuration;

	private float _transitionStartTime;

	private float _t;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ChangeRotationAndPosition()
	{
	}

	public void GoToNextPose()
	{
	}

	public void GoToPreviousPose()
	{
	}

	[IteratorStateMachine(typeof(_003CChangePosition_003Ed__22))]
	private IEnumerator ChangePosition(int index)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChangeRotation_003Ed__23))]
	private IEnumerator ChangeRotation(int index)
	{
		return null;
	}
}
