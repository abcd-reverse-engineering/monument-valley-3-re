using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameLogic;
using UnityEngine;

public class WaterLevelManager : Trigger
{
	public delegate void GameEvent();

	[CompilerGenerated]
	private sealed class _003CChangePosition_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterLevelManager _003C_003E4__this;

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
		public _003CChangePosition_003Ed__36(int _003C_003E1__state)
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

	private Vector3 _moveDistance;

	[SerializeField]
	private float _waterPosDelta;

	[SerializeField]
	private float _startWaterLevelPos;

	[SerializeField]
	private float _targetWaterLevelPos;

	private bool _shouldMove;

	private bool _isTransition;

	private bool _isAllowRaise;

	private bool _isAllowLower;

	[SerializeField]
	private float _transitionDuration;

	private float _transitionStartTime;

	private float _t;

	private float _difference;

	private float _transitionDeltaCoefficient;

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

	public float TransitionDeltaCoefficient => 0f;

	public event GameEvent OnWaterLevelRaised
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GameEvent OnWaterLevelLowered
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Action(null)]
	public void RaiseWaterLevel()
	{
	}

	[Action(null)]
	public void LowerWaterLevel()
	{
	}

	protected override void Start()
	{
	}

	protected new void Update()
	{
	}

	private float CalculateTransitionDeltaCoefficient()
	{
		return 0f;
	}

	public void CalculateAndLogTransitionDeltaCoefficient()
	{
	}

	private void SetInitialWaterPosition(float yPos)
	{
	}

	private void Raise()
	{
	}

	private void Lower()
	{
	}

	private void DebugRaiseWater()
	{
	}

	private void Move(Vector3 direction)
	{
	}

	[IteratorStateMachine(typeof(_003CChangePosition_003Ed__36))]
	private IEnumerator ChangePosition(Vector3 direction)
	{
		return null;
	}
}
