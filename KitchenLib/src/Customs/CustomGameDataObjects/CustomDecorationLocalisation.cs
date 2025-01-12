﻿using KitchenData;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

namespace KitchenLib.Customs
{
	public abstract class CustomDecorationLocalisation : CustomLocalisationSet<DecorationLocalisation, DecorationBonusInfo>
	{
		// Base-Game Variables
		public virtual LocalisationObject<DecorationBonusInfo> Info { get; protected set; }

		public virtual Dictionary<DecorationBonus, string> Text { get; protected set; } = new SerializedDictionary<DecorationBonus, string>();

		public virtual Dictionary<DecorationType, string> Icons { get; protected set; } = new SerializedDictionary<DecorationType, string>();

		public override void Convert(GameData gameData, out GameDataObject gameDataObject)
		{
			DecorationLocalisation result = ScriptableObject.CreateInstance<DecorationLocalisation>();

			Main.LogDebug($"[CustomDecorationLocalisation.Convert] [1.1] Converting Base");

			if (BaseGameDataObjectID != -1)
				result = UnityEngine.Object.Instantiate(gameData.Get<DecorationLocalisation>().FirstOrDefault(a => a.ID == BaseGameDataObjectID));

			if (result.ID != ID) result.ID = ID;
			if (result.Info != Info) result.Info = Info;
			if (result.Text != Text) result.Text = Text;
			if (result.Icons != Icons) result.Icons = Icons;
			
			gameDataObject = result;
		}
	}
}
