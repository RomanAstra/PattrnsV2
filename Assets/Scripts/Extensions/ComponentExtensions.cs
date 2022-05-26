using UnityEngine;


namespace Extensions
{
    public static partial class ComponentExtensions
    {
        public static T GetOrAddComponent<T>(this Component child) where T : Component
        {
            var result = child.GetComponent<T>();
            if (result is null)
            {
                result = child.gameObject.AddComponent<T>();
            }

            return result;
        }
        
    }
}
