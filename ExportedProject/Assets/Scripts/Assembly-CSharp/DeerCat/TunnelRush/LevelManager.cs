using System.Collections.Generic;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class LevelManager : MonoBehaviour
	{
		public float tunnelLength;

		public float bendFreq;

		public float bendAmp;

		public int repeatFromLevel;

		public float gemSpacing;

		public Color[] levelColors;

		public Texture2D[] levelTextures;

		public GameObject gemCollectParticles;

		public GameObject gemRingsParticles;

		public AudioClip reachedGemTargetSfx;

		private LevelSection[] allSections;

		private LevelSection[] levelSections;

		private LevelSection menuSection;

		private LevelParent[] levels;

		private List<LevelBlock> activeBlocks;

		private int currentSectionIdx;

		private float currentZ;

		private float zOffset;

		private Vector3 cameraOffset;

		private bool enableGeneration;

		private int blocksBetweenGems;

		private int blocksTillNextGem;

		private PlayerControl player;

		private static LevelManager instance;

		public float TotalDistance
		{
			get
			{
				return 0f;
			}
		}

		public float BendAmplitude
		{
			get
			{
				return 0f;
			}
		}

		public float TunnelLength
		{
			get
			{
				return 0f;
			}
		}

		public Vector3 CameraOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public float CurrentLevelLength { get; private set; }

		public float CurrentLevelSplitDistance { get; private set; }

		public bool EnableGeneration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Reset()
		{
		}

		public void RemoveObstacles(float dist)
		{
		}

		public void StartGame()
		{
		}

		public Vector3 CalcOffset(float zPos)
		{
			return default(Vector3);
		}

		private void Update()
		{
		}
	}
}
