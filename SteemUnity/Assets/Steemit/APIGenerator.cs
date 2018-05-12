using System.Collections;
using System.Collections.Generic;
using System;
#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;
#endif

namespace Steemit
{
	[InitializeOnLoad]
	[System.Serializable]
	public class APIGenerator : ScriptableObject 
	{
		public string apiUrl
		{
			get { return _apiUrl; }
		}

		public string scriptPath
		{
			get { return string.Format("{0}/{1}", Application.dataPath, _scriptPath); }
		}

		[SerializeField]
		private string _apiUrl = "https://raw.githubusercontent.com/steemit/steem-js/master/src/api/methods.js";

		[SerializeField]
		private string _scriptPath = "Steemit/_GeneratedScript/SteemitAPI";

		private void Reset()
		{
			_apiUrl = "https://raw.githubusercontent.com/steemit/steem-js/master/src/api/methods.js";
		}
	}
}