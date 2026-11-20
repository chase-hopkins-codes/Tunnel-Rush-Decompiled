using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class LevelSection : MonoBehaviour
	{
		[StructLayout((LayoutKind)0, Size = 8)]
		private struct BlockItem
		{
			public int blockIdx;

			public bool keepGems;

			public BlockItem(int idx, bool gems)
			{
				blockIdx = 0;
				keepGems = false;
			}
		}

		public float sectionLength;

		public bool randomiseRotation;

		public Texture2D overrrideTunnelTexture;

		public LevelBlock firstBlock;

		public LevelBlock lastBlock;

		public LevelBlock[] blocks;

		private Transform activeBlocks;

		private Transform blockPool;

		private List<int> selectedBlocks;

		private const int maxBlockTypesPerSection = 4;

		private List<BlockItem> blockList;

		private int blockCount;

		private int numGemSets;

		private string defaultTunnelTextureName;

		private Color obstacleColor;

		public Color ObstacleColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int NumGemSets
		{
			get
			{
				return 0;
			}
		}

		public void SetObstacleColor(Color col, Texture2D tunnelTex)
		{
		}

		public void Initialise()
		{
		}

		private void InitBlock(LevelBlock blockPrefab)
		{
		}

		public void Reset()
		{
		}

		public float PickAllBlocks()
		{
			return 0f;
		}

		public void StartSection()
		{
		}

		public LevelBlock GenerateBlock(float zPos, out bool keepGems)
		{
			keepGems = default(bool);
			return null;
		}

		public bool IsSectionCompleted()
		{
			return false;
		}
	}
}
