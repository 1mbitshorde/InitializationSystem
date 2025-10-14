using UnityEngine;
using UnityEngine.Events;

namespace OneM.InitializationSystem
{
    /// <summary>
    /// Executes the <see cref="OnInstantiated"/> event when all Projects dependencies are instantiated.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class DependencyInstantiateHandler : MonoBehaviour
    {
        [Tooltip("Event executed when all Projects dependencies are instantiated.")]
        public UnityEvent OnInstantiated;

        private void OnEnable() => DependencyInstantiater.OnInstantiated += HandleDependencyInstantiated;
        private void OnDisable() => DependencyInstantiater.OnInstantiated -= HandleDependencyInstantiated;

        private void HandleDependencyInstantiated() => OnInstantiated?.Invoke();
    }
}