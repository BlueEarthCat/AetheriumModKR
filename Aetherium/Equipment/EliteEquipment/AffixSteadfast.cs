﻿using BepInEx.Configuration;
using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Aetherium.Equipment.EliteEquipment
{
    public class AffixSteadfast : EliteEquipmentBase<AffixSteadfast>
    {
        public override string EliteEquipmentName => "Essence of Steel";

        public override string EliteAffixToken => "AFFIX_STEADFAST";

        public override string EliteEquipmentPickupDesc => "Become an aspect of poise.";

        public override string EliteEquipmentFullDescription => "";

        public override string EliteEquipmentLore => "";

        public override string EliteModifier => "Steadfast";

        public override GameObject EliteEquipmentModel => new GameObject();

        public override Sprite EliteEquipmentIcon => null;

        public override Sprite EliteBuffIcon => null;

        public override void Init(ConfigFile config)
        {
            CreateBuff();
        }

        private void CreateBuff()
        {
            throw new NotImplementedException();
        }

        public override ItemDisplayRuleDict CreateItemDisplayRules()
        {
            return new ItemDisplayRuleDict();
        }

        public override void Hooks()
        {
            R2API.RecalculateStatsAPI.GetStatCoefficients += BlockMovementSpeedDown;
        }

        private void BlockMovementSpeedDown(CharacterBody sender, RecalculateStatsAPI.StatHookEventArgs args)
        {
            if(sender.)
            if(args.moveSpeedMultAdd < 1)
            {
                var movespeedDiff = 1 - args.moveSpeedMultAdd;
                args.moveSpeedMultAdd += movespeedDiff;
            }
            if(args.moveSpeedReductionMultAdd > 0)
            {
                args.moveSpeedReductionMultAdd = 0;
            }
        }

        protected override bool ActivateEquipment(EquipmentSlot slot)
        {
            return false;
        }
    }
}
