using ModelReplacement;
using UnityEngine;

namespace ModelReplacement
{
    public class MRMAMEHINATA : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Mamehinata";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}