using UnityEngine;


namespace Visitor.ExampleHit
{
    public readonly struct InfoCollision
    {
        private readonly Vector3 _dir;
        private readonly float _damage;
        private readonly Vector3 _point;
        private readonly Vector3 _normal;
        private readonly Transform _objCollision;

        public InfoCollision(float damage, Vector3 point, Vector3 normal, Transform objCollision, Vector3 dir = default)
        {
            _damage = damage;
            _point = point;
            _normal = normal;
            _dir = dir;
            _objCollision = objCollision;
        }

        public Vector3 Dir => _dir;

        public float Damage => _damage;

        public Transform ObjCollision => _objCollision;

        public Vector3 Point => _point;

        public Vector3 Normal => _normal;
    }
}
