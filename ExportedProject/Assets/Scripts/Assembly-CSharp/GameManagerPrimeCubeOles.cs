using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManagerPrimeCubeOles : MonoBehaviour
{
	public delegate void Action();

	[CompilerGenerated]
	private sealed class _003CDestroyDoorWithParticlesFX_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GameManagerPrimeCubeOles _003C_003E4__this;

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
		public _003CDestroyDoorWithParticlesFX_003Ed__24(int _003C_003E1__state)
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

	public static bool isTriggered;

	public string doorObjectNameParent;

	public string doorObjectName;

	public string triggerObjectNameParent;

	public string triggerObjectName;

	public string playerName;

	public static GameObject doorObject;

	public static GameObject doorObjectParent;

	public static GameObject triggerObject;

	public static GameObject player;

	public TriggerDoorOles door;

	public CharacterInVolumeSensorWithFindOles volume;

	[SerializeField]
	private ParticleSystem explosionFx;

	public static event Action OnObjectsFind
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

	public static event Action OnPlayerDestroy
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

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void CreateObjectDictionary()
	{
	}

	private void DestroyPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyDoorWithParticlesFX_003Ed__24))]
	private IEnumerator DestroyDoorWithParticlesFX(float delay)
	{
		return null;
	}
}
