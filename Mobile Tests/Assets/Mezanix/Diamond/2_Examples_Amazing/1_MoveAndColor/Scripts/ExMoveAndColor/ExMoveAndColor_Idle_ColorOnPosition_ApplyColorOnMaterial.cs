using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ScriptsCreatedByDiamond 
{
	public class ExMoveAndColor_Idle_ColorOnPosition_ApplyColorOnMaterial 
	{
		ExMoveAndColor_Idle_ColorOnPosition exMoveAndColor_Idle_ColorOnPosition;

		public bool doIT = false;

		ScriptsCreatedByDiamond.IdentifiedObjects identifiedObjects = null;

		public Material materialValue;


		public Material[] materialValues = new Material[2];

		public Color[] colorValues = new Color[2];

		public ExMoveAndColor_Idle_ColorOnPosition_ApplyColorOnMaterial (ExMoveAndColor_Idle_ColorOnPosition setExMoveAndColor_Idle_ColorOnPosition) 
		{
			exMoveAndColor_Idle_ColorOnPosition = setExMoveAndColor_Idle_ColorOnPosition;

			exMoveAndColor_Idle_ColorOnPosition.IAmHere ();

			identifiedObjects = GameObject.Find (ScriptsCreatedByDiamond.IdentifiedObjectsActions.gameObjectHolderName).GetComponent<ScriptsCreatedByDiamond.IdentifiedObjects>();

			if (identifiedObjects != null)
			{
				materialValues [0] = (Material)identifiedObjects.GetIdentifiedObject ("8_4_2017_9_09_41_AM_6827.materialValues_0");
			}

			colorValues [0] = new Color (1f, 1f, 1f, 1f);
			colorValues [1] = new Color (1f, 1f, 1f, 1f);

		}

		public void LogicNodeUpdate ()
		{
			colorValues [0] = exMoveAndColor_Idle_ColorOnPosition.exMoveAndColor_Idle_ColorOnPosition_Vector4ToColor.colorValue;

			doIT = true;

			ComputeMaterial ();
		}

		void ComputeMaterial ()
		{
			if ( ! doIT)
			{
				return;
			}

			if (materialValues [0] != null)
			{
				materialValues [0].color = colorValues [0];

				materialValue = materialValues [0];
			}

		}
	}
}
