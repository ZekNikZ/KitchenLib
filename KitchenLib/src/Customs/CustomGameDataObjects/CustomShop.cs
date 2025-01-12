using KitchenData;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KitchenLib.Customs
{
    public abstract class CustomShop : CustomGameDataObject<Shop>
    {
	    // Base-Game Variables
        public virtual List<Appliance> Stock { get; protected set; } = new List<Appliance>();
        public virtual List<Decor> Decors { get; protected set; } = new List<Decor>();
        public virtual ShopType Type { get; protected set; }
        public virtual int ItemsForSaleCount { get; protected set; } = 3;
        public virtual int WallpapersForSaleCount { get; protected set; } = 6;
        public override void Convert(GameData gameData, out GameDataObject gameDataObject)
        {
            Shop result = ScriptableObject.CreateInstance<Shop>();

			Main.LogDebug($"[CustomShop.Convert] [1.1] Converting Base");

			if (BaseGameDataObjectID != -1)
                result = UnityEngine.Object.Instantiate(gameData.Get<Shop>().FirstOrDefault(a => a.ID == BaseGameDataObjectID));

            if (result.ID != ID) result.ID = ID;
            if (result.Type != Type) result.Type = Type;
            if (result.ItemsForSaleCount != ItemsForSaleCount) result.ItemsForSaleCount = ItemsForSaleCount;
            if (result.WallpapersForSaleCount != WallpapersForSaleCount) result.WallpapersForSaleCount = WallpapersForSaleCount;

            gameDataObject = result;
        }

        public override void AttachDependentProperties(GameData gameData, GameDataObject gameDataObject)
        {
            Shop result = (Shop)gameDataObject;

			Main.LogDebug($"[CustomShop.AttachDependentProperties] [1.1] Converting Base");

			if (result.Stock != Stock) result.Stock = Stock;
            if (result.Decors != Decors) result.Decors = Decors;
        }
    }
}