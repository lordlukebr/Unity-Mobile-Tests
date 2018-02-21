using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ScriptsCreatedByDiamond 
{
	public class ExLoadScene_A_Idle_Logic_Load 
	{
		ExLoadScene_A_Idle_Logic exLoadScene_A_Idle_Logic;

		public bool [] boolValues = new bool[2];

		public string [] stringValues = new string[2];

		public UnityEngine.SceneManagement.LoadSceneMode loadSceneMode;

		public ExLoadScene_A_Idle_Logic_Load (ExLoadScene_A_Idle_Logic setExLoadScene_A_Idle_Logic) 
		{
			exLoadScene_A_Idle_Logic = setExLoadScene_A_Idle_Logic;

			exLoadScene_A_Idle_Logic.IAmHere ();

			boolValues [0] = false;
			boolValues [1] = false;
			stringValues [0] = "Scene_A";
			stringValues [1] = "";
			loadSceneMode = UnityEngine.SceneManagement.LoadSceneMode.Single;
		}

		public void LogicNodeUpdate ()
		{
			boolValues [0] = exLoadScene_A_Idle_Logic.exLoadScene_A_Idle_Logic_Button.boolValue;

			if (boolValues [0])
				{
					UnityEngine.SceneManagement.SceneManager.LoadScene (stringValues [0], loadSceneMode);
				}

		}

	}
}
