using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaterStateManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeValue_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterStateManager _003C_003E4__this;

		public float startValue;

		public float delta;

		public Action<float> updateStartValue;

		public float endValue;

		public Action<float> updateProperty;

		private float _003Ct_003E5__2;

		private float _003CcurrentValue_003E5__3;

		private float _003CtargetValue_003E5__4;

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
		public _003CChangeValue_003Ed__21(int _003C_003E1__state)
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

	private WaterSurfaceManager waterSurfaceManager;

	private WaterLevelManager waterLevelManager;

	[Range(0f, 2f)]
	[Header("Wave Steepness")]
	public float _globalWaveSteepnessAtStart;

	[Range(0f, 2f)]
	public float _globalWaveSteepnessAtEnd;

	private float _globalWaveSteepnessDelta;

	[Header("Wave Scale")]
	[Range(0f, 2f)]
	public float _globalWaveScaleAtStart;

	[Range(0f, 2f)]
	public float _globalWaveScaleAtEnd;

	private float _globalWaveScaleDelta;

	[Header("Wave Speed")]
	[Range(0f, 2f)]
	public float _globalWaveSpeedAtStart;

	[Range(0f, 2f)]
	public float _globalWaveSpeedAtEnd;

	private float _globalWaveSpeedDelta;

	private bool _isTransition;

	private bool _isAllow;

	private void OnEnable()
	{
	}

	public void AllowWaterLevelToRaise()
	{
	}

	private void Awake()
	{
	}

	private void InitialiseWaveScale(float waveSteepnessValue, float waveScaleValue, float waveSpeedValue)
	{
	}

	private void Update()
	{
	}

	public float CalculateDelta(float startValue, float endValue, float deltaCoefficient)
	{
		return 0f;
	}

	private void IncreaseWaveScale()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeValue_003Ed__21))]
	private IEnumerator ChangeValue(float startValue, float endValue, float delta, Action<float> updateStartValue, Action<float> updateProperty)
	{
		return null;
	}
}
