using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class LevelBlock : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private float length;

		public bool IsFinalBlock { get; set; }

		public float BlockLength
		{
			get
			{
				return 0f;
			}
		}

		public bool ContainsGems()
		{
			return false;
		}

		public void CalcBounds()
		{
		}
	}
}
