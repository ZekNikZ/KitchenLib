using KitchenData;
using System.Collections.Generic;

namespace KitchenLib.Customs
{
    public abstract class CustomUnlockCard : CustomUnlock
    {
		public virtual List<UnlockEffect> Effects { get { return new List<UnlockEffect>(); } }
        public override void Convert(GameData gameData, out GameDataObject gameDataObject)
        {
            UnlockCard result = new UnlockCard();
            UnlockCard empty = new UnlockCard();
            
            if (empty.ID != ID) result.ID = ID;
            if (empty.Effects != Effects) result.Effects = Effects;

			if (empty.ExpReward != ExpReward) result.ExpReward = ExpReward;
			if (empty.IsUnlockable != IsUnlockable) result.IsUnlockable = IsUnlockable;
			if (empty.UnlockGroup != UnlockGroup) result.UnlockGroup = UnlockGroup;
			if (empty.CardType != CardType) result.CardType = CardType;
			if (empty.MinimumFranchiseTier != MinimumFranchiseTier) result.MinimumFranchiseTier = MinimumFranchiseTier;
			if (empty.IsSpecificFranchiseTier != IsSpecificFranchiseTier) result.IsSpecificFranchiseTier = IsSpecificFranchiseTier;
			if (empty.CustomerMultiplier != CustomerMultiplier) result.CustomerMultiplier = CustomerMultiplier;
			if (empty.SelectionBias != SelectionBias) result.SelectionBias = SelectionBias;
			if (empty.Requires != Requires) result.Requires = Requires;
			if (empty.BlockedBy != BlockedBy) result.BlockedBy = BlockedBy;

            gameDataObject = result;
        }
    }
}