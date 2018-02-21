using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ScriptsCreatedByDiamond 
{
	public class ExAnimationCurves_Idle_SimpleAnimationNodes_AnimateVector4 
	{
		ExAnimationCurves_Idle_SimpleAnimationNodes exAnimationCurves_Idle_SimpleAnimationNodes;

		public bool doIT = false;

		public float [] floatValues = new float[3];

		AnimationCurve animationCurve_;
		public bool [] boolValues = new bool[2];

		public Vector4 vector4Value;

		public Vector4 [] vector4Values = new Vector4[2];

		public ExAnimationCurves_Idle_SimpleAnimationNodes_AnimateVector4 (ExAnimationCurves_Idle_SimpleAnimationNodes setExAnimationCurves_Idle_SimpleAnimationNodes) 
		{
			exAnimationCurves_Idle_SimpleAnimationNodes = setExAnimationCurves_Idle_SimpleAnimationNodes;

			exAnimationCurves_Idle_SimpleAnimationNodes.IAmHere ();

			floatValues [0] = 1f;
			floatValues [1] = 1f;
			floatValues [2] = 1f;

			boolValues [0] = false;
			animationCurve_ = new AnimationCurve (
				new Keyframe []
				{
					new Keyframe (0f, 0f, 0f, 0f),
					new Keyframe (1f, 1f, 0f, 0f)
				});

			vector4Values [0] = new Vector4 (0f, 0f, 0f, 0f);
			vector4Values [1] = new Vector4 (0f, 0f, 0f, 0f);

			vector4Value = new Vector4 (0f, 0f, 0f, 0f);
		}

		public void LogicNodeUpdate ()
		{
			ComputeVector4 ();
		}

		IEnumerator RunAnimationCurve_vector4 ()
		{
			if ( ! boolValues [0])
			{
				boolValues [0] = true;
		
				float t = 0f;
		
				float rate = 1f / floatValues [2];
		
				while (t < 1f)
				{
					t += Time.deltaTime * rate;
		
					vector4Value = Vector4.Lerp (vector4Values [0], vector4Values [1], animationCurve_.Evaluate (t));
		
					yield return 0;
				}
		
				boolValues [0] = false;
			}
			yield return 0;
		}
		void ComputeVector4 ()
		{
			if ( ! doIT)
			{
				return;
			}

			exAnimationCurves_Idle_SimpleAnimationNodes.exAnimationCurves_Idle.exAnimationCurves.StartCoroutine (RunAnimationCurve_vector4 ());

		}
	}
}
