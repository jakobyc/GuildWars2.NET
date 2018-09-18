using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("vendor_value")]
        public int VendorValue { get; set; }

        [JsonProperty("default_skin")]
        public string DefaultSkin { get; set; }

        [JsonProperty("game_types")]
        public string[] GameTypes { get; set; }

        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("restrictions")]
        public object[] Restrictions { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("details")]
        public Details ItemDetails { get; set; }

        public class Details
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("damage_type")]
            public string DamageType { get; set; }

            [JsonProperty("min_power")]
            public int MinPower { get; set; }

            [JsonProperty("max_power")]
            public int MaxPower { get; set; }

            [JsonProperty("defense")]
            public int Defense { get; set; }

            [JsonProperty("infusion_slots")]
            public InfusionSlot[] InfusionSlots { get; set; }

            [JsonProperty("infix_upgrade")]
            public InfixUpgrade InfixUpgrade { get; set; }

            [JsonProperty("suffix_item_id")]
            public long SuffixItemId { get; set; }

            [JsonProperty("secondary_suffix_item_id")]
            public string SecondarySuffixItemId { get; set; }

            [JsonProperty("stat_choices")]
            public string[] StatChoices { get; set; }

            [JsonProperty("flags")]
            public string[] Flags { get; set; }

            // Salvage kits:
            [JsonProperty("charges")]
            public int Charges { get; set; }

            // Upgrade Components:
            [JsonProperty("suffix")]
            public string Suffix { get; set; }

            [JsonProperty("infusion_upgrade_flags")]
            public string[] InfusionUpgradeFlags { get; set; }
            [JsonProperty("bonuses")]
            public string[] Bonuses { get; set; }

            // Miniatures:
            [JsonProperty("minipet_id")]
            public string MinipetId { get; set; }

            // Consumables:
            [JsonProperty("description")]
            public string Description { get; set; }
            /// <summary>
            /// Duration in milliseconds
            /// </summary>
            [JsonProperty("duration_ms")]
            public string Duration { get; set; }
            [JsonProperty("unlock_type")]
            public string UnlockType { get; set; }
            [JsonProperty("color_id")]
            public string ColorId { get; set; }
            [JsonProperty("recipe_id")]
            public string RecipeId { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("skins")]
            public string[] SkinIds { get; set; }

            [JsonProperty("apply_count")]
            public int ApplyCount { get; set; }

            // Bags:
            [JsonProperty("size")]
            public string BagSize { get; set; }
            [JsonProperty("no_sell_or_sort")]
            public bool IsInvisibleOrSafe { get; set; }

            // Armor:
            [JsonProperty("weight_class")]
            public string WeightClass { get; set; }
        }

        public class InfixUpgrade
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("attributes")]
            public UpgradeAttribute[] Attributes { get; set; }

            [JsonProperty("buff")]
            public UpgradeBuff Buff { get; set; }
        }

        public class UpgradeAttribute
        {
            [JsonProperty("attribute")]
            public string Attribute { get; set; }

            [JsonProperty("modifier")]
            public int Modifier { get; set; }
        }

        public class UpgradeBuff
        {
            [JsonProperty("skill_id")]
            public string SkillId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        public class InfusionSlot
        {
            [JsonProperty("flags")]
            public string[] Flags { get; set; }

            [JsonProperty("item_id")]
            public string ItemId { get; set; }
        }
    }
}
