using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    public void PlayParticles()
    {
        _particleSystem.Play();
    }

    private void OnValidate()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }
}
