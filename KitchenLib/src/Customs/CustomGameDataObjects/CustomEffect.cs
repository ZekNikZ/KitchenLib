using KitchenData;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KitchenLib.Customs
{
    public abstract class CustomEffect : CustomGameDataObject<Effect>
    {
	    // Base-Game Variables
        public virtual List<IEffectProperty> Properties { get; protected set; } = new List<IEffectProperty>();
        public virtual IEffectRange EffectRange { get; protected set; }
        public virtual IEffectCondition EffectCondition { get; protected set; }
        public virtual IEffectType EffectType { get; protected set; }
        public virtual EffectRepresentation EffectInformation { get; protected set; }
		
        public override void Convert(GameData gameData, out GameDataObject gameDataObject)
        {
            Effect result = ScriptableObject.CreateInstance<Effect>();

			Main.LogDebug($"[CustomEffect.Convert] [1.1] Converting Base");

			if (BaseGameDataObjectID != -1)
                result = UnityEngine.Object.Instantiate(gameData.Get<Effect>().FirstOrDefault(a => a.ID == BaseGameDataObjectID));

            if (result.ID != ID) result.ID = ID;
            if (result.Properties != Properties) result.Properties = Properties;
            if (result.EffectRange != EffectRange) result.EffectRange = EffectRange;
            if (result.EffectCondition != EffectCondition) result.EffectCondition = EffectCondition;
            if (result.EffectType != EffectType) result.EffectType = EffectType;

            gameDataObject = result;
        }

        public override void AttachDependentProperties(GameData gameData, GameDataObject gameDataObject)
        {
            Effect result = (Effect)gameDataObject;

			Main.LogDebug($"[CustomEffect.AttachDependentProperties] [1.1] Converting Base");

			if (result.EffectInformation != EffectInformation) result.EffectInformation = EffectInformation;
        }
    }
}