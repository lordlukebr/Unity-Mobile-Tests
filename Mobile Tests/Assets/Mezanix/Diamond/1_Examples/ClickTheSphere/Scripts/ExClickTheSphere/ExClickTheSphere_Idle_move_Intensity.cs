using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ScriptsCreatedByDiamond 
{
	public class ExClickTheSphere_Idle_move_Intensity 
	{
		ExClickTheSphere_Idle_move exClickTheSphere_Idle_move;

		public bool doIT = false;

		public Vector3 vector3Value = new Vector3 ();

		public Vector3 [] vector3Values = new Vector3[2];

		public float [] floatValues = new float[3];

		public ExClickTheSphere_Idle_move_Intensity (ExClickTheSphere_Idle_move setExClickTheSphere_Idle_move) 
		{
			exClickTheSphere_Idle_move = setExClickTheSphere_Idle_move;

			exClickTheSphere_Idle_move.IAmHere ();

			vector3Values [0] = new Vector3 (0f, 0f, 0f);
			vector3Values [1] = new Vector3 (0f, 0f, 0f);

			floatValues [0] = 3f;
			floatValues [1] = 1f;
			floatValues [2] = 1f;

		}

		public void LogicNodeUpdate ()
		{
			vector3Values [0] = exClickTheSphere_Idle_move.exClickTheSphere_Idle_move_AddVector_1.vector3Value;

			doIT = exClickTheSphere_Idle_move.exClickTheSphere_Idle_move_Start.boolValue;

			ComputeVector3 ();
		}

		void ComputeVector3 ()
		{
			if ( ! doIT)
			{
				return;
			}

			vector3Value = vector3Values [0] * floatValues [0];

		}
	}
}
