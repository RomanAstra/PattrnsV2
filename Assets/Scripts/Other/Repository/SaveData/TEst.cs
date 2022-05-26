using UnityEngine;

namespace Geekbrains
{
    internal sealed class TEst
    {
        public TEst(Transform player)
        {
            //////////
            JsonData<Transform> save = new JsonData<Transform>();
            save.Save(player, "Data");
            //////////
            SaveDataRepository save2 = new SaveDataRepository();
            save.Save(player, "Data");
            //////////
        }
    }
}
