using System;
using UnityEngine;

namespace TryParse
{
    public sealed class Example
    {
        public int DoSomething(string input)
        {
            int ret;
            Exception exception = DoSomethingImpl(input, out ret);
            if (exception != null)
            {
                // Note that you'll lose stack trace accuracy here
                throw exception;
            }
            return ret;
        }

        public bool TrySomething(string input, out int ret)
        {
            Exception exception = DoSomethingImpl(input, out ret);
            return exception == null;
        }

        private Exception DoSomethingImpl(string input, out int ret)
        {
            ret = 0;
            if (input != "bad")
            {
                ret = 5;
                return null;
            }
            else
            {
                return new ArgumentException("Some details");
            }
        }
    }

    internal class MyClass : MonoBehaviour
    {
        private void NameMethod()
        {
            var component = gameObject.GetComponent<Rigidbody>();
            component.AddForce(Vector3.zero * 999.0f);
            
            if (gameObject.TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbody.AddForce(Vector3.zero * 999.0f);
            }

            if (int.TryParse("10", out int y))
            {
                Debug.Log(y);
            }
        }
    }
}
