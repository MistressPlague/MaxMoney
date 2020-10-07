using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MaxMoney
{
    public class MaxMoneyByPlague : MelonMod
    {
        public override void OnGUI()
        {
            if (GUI.Button(new Rect(10, 35, 150, 25), "Max Money: " + FileBasedPrefs.GetInt("PlayersMoney")))
            {
                FileBasedPrefs.SetInt("PlayersMoney", 999999);

                FileBasedPrefs.ManualySave();
            }
        }
    }
}
