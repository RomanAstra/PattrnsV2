using UnityEngine;
using UnityEngine.SceneManagement;

namespace Asteroids.Singleton.Test
{
    internal sealed class Starter : MonoBehaviour
    {
        private IText _text;
        private void Start()
        {
            _text = new TextExample();
            SceneManager.LoadScene(0, LoadSceneMode.Additive);
            SceneManager.sceneLoaded += SceneManagerOnsceneLoaded;
        }

        private void SceneManagerOnsceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            if (arg0.buildIndex == 0)
            {
                var findObjectOfType = FindObjectOfType<First>();
                findObjectOfType.DependencyInjection(_text);
            }
            else
            {
                var findObjectOfType = FindObjectOfType<Second>();
                findObjectOfType.DependencyInjection(_text);
            }
                
        }
    }
}
