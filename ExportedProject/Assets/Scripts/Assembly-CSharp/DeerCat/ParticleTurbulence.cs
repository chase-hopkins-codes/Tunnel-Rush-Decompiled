using UnityEngine;

namespace DeerCat
{
	[ExecuteInEditMode]
	public class ParticleTurbulence : MonoBehaviour
	{
		public float frequency;

		public float amplitude;

		public float evolutionSpeed;

		private ParticleSystem system;

		private ParticleSystem.Particle[] particles;

		private void Start()
		{
		}

		private void Update()
		{
		}

		protected virtual void UpdateParticles(ParticleSystem.Particle[] particles, int particleCount)
		{
		}
	}
}
