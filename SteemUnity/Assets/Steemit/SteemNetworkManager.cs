using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Steemit
{
	public class Steem : MonoBehaviour
	{
		private static Steem _instance;

		public static Steem instance
		{
			get
			{
				if (_instance == null)
				{
					GameObject go = new GameObject();
					go.name = "[Steem API]";
					_instance = go.AddComponent<Steem>();
					DontDestroyOnLoad(go);
				}
				return _instance;
			}
		}

		public void Request(System.Action<bool> inCallback, string inMethod, string[] inParams)
		{
			
		}
	}
}
