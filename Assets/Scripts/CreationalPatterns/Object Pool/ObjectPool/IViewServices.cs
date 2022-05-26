using UnityEngine;

namespace ObjectPool
{
    public interface IViewServices
    {
        T Instantiate<T>(GameObject prefab);
        void Destroy(GameObject value);
    }
}
