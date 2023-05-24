using Cysharp.Threading.Tasks;
using UniGame.Context.Runtime.Extension;
using UniGame.ViewSystem.Runtime;
using UniModules.GameFlow.Runtime.Core;
using UnityEngine;

namespace Runtime.ViewTesting
{
    using Views;

    public class ViewsScenario : MonoBehaviour
    {
        public UniGraph graph;
    
        // Start is called before the first frame update
        private void Start()
        {
            ExecuteAsync().Forget();
        }

        private async UniTask ExecuteAsync()
        {
            var context = graph.GraphContext;

            var viewSystem = await context.ReceiveFirstAsync<IGameViewSystem>();
        
            Debug.Log("View System Initialized");

            await viewSystem.OpenWindow<DemoEcsWindow1>();
        }
    }
}
