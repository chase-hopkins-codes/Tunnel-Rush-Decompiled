using UnityEngine;

public class OnlyIncludeOnPlatform : MonoBehaviour
{
	public enum Platform
	{
		Android = 0,
		Perpetuum = 1,
		IOS = 2,
		Web = 3
	}

	public bool include;

	public Platform platform;

	public GameObject prefabToInstantiate;

	private void Start()
	{
	}
}
