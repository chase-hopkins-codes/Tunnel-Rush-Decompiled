using System.Collections.Generic;
using UnityEngine;

namespace DeerCat.TunnelRush
{
	public class ChallengeManager : MonoBehaviour
	{
		public class Opponent
		{
			public string name;

			public float predestinedDeathDistance;

			public float finalDistance;

			public bool isDead;
		}

		public int numOpponents;

		private static ChallengeManager instance;

		private int numOpponentsRemaining;

		private List<Opponent> opponents;

		public static ChallengeManager Instance
		{
			get
			{
				return null;
			}
		}

		public List<Opponent> Opponents
		{
			get
			{
				return null;
			}
		}

		public int LiveOpponentCount
		{
			get
			{
				return 0;
			}
		}

		private string GenerateName()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnStartGame()
		{
		}

		private void OnOpponentCrashed(int opponentIdx)
		{
		}

		private void Update()
		{
		}
	}
}
