using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ScriptsCreatedByDiamond 
{
	public class ExMoveAndColor : MonoBehaviour 
	{
		[HideInInspector] 
		public IExMoveAndColor currentState; 

		[HideInInspector] 
		public ExMoveAndColor_Idle idle; 

		[HideInInspector]
		public GameObject attachedToGameObject;

		[HideInInspector]
		public GameObject gameObjectsFoundBytrigger = null;

		[HideInInspector]
		public int gameObjectsFoundBytriggerIndex = -1;

		
		void Awake () 
		{ 
			ProjectVariables.Init ();

			attachedToGameObject = gameObject;
			idle = new ExMoveAndColor_Idle (this);
		} 

		void Start () 
		{ 
			currentState = idle; 

		} 

		void Update () 
		{ 
			currentState.StateUpdate (); 
		} 

		void LateUpdate ()
		{
			FreeameObjectsFoundBytriggerIndex ();
		}

		void FreeameObjectsFoundBytriggerIndex ()
		{
			if (gameObjectsFoundBytrigger == null)
			{
				gameObjectsFoundBytriggerIndex = -1;
			}
		}

	}
}
