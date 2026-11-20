using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{
	[Serializable]
	public class ConfigData
	{
		public float abSplit;

		public int localAdFreq;

		public int localAdIdx;

		public string localAdLinkPath;

		public int sendInfo;

		public int autoAdFreq;

		public int interstAdFreq;

		public int adTimer;

		public bool useLevels;

		public bool singleSectionOnly;
	}

	public bool generate;

	private ConfigData config;

	private static ConfigManager instance;

	public static ConfigData Config
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private string MungeString(string str)
	{
		return null;
	}

	private string UnMungeString(string str)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator LoadConfig()
	{
		return null;
	}
}
