using UnityEngine;
using UnityEngine.AddressableAssets;

namespace OneM.InitializationSystem
{
    /// <summary>
    /// Instantiates the "Dependencies" Prefab (via Addressables) into 
    /// the <b>DontDestroyOnLoad Scene</b> when the game enters in Play mode.
    /// </summary>
    /// <remarks>
    /// It's important to name a Prefab using <see cref="PREFAB_NAME"/> value 
    /// and set it as addressable using the same name.
    /// </remarks>
    public static class DependencyInstantiater
    {
        /// <summary>
        /// Event fired when all dependencies are instantiated.
        /// </summary>
        public static event System.Action OnInstantiated;

        public static readonly string PREFAB_NAME = "Dependencies";

        /// <summary>
        /// Called when you enter PLAY MODE, by the system.
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static async void Instantiate()
        {
            var instance = await Addressables.InstantiateAsync(PREFAB_NAME).Task;
            instance.name = PREFAB_NAME;

            Object.DontDestroyOnLoad(instance);

            OnInstantiated?.Invoke();
        }
    }
}