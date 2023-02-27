﻿{{otherlang2
|zh-cn = Dota_2_Workshop_Tools:zh-cn/Scripting:zh-cn/Abilities_Data_Driven_Example:zh-cn
}}
{{Dota 2Tools topicons}}
Included here are some examples using the data driven ability system.

== AOE Damage Over Time ==
Here is an ability that waits for the owner to die. On death, a thinker is created with an acid pool visual effect and an aura modifier which reduces armor and applies a damage over time effect.

<source lang="text">
//=================================================================================================================
// Creature: Acid Spray
//=================================================================================================================
"creature_acid_spray"
{
    // General
    //-------------------------------------------------------------------------------------------------------------
    "BaseClass"              "ability_datadriven"
    "AbilityBehavior"        "DOTA_ABILITY_BEHAVIOR_AOE | DOTA_ABILITY_BEHAVIOR_PASSIVE"
    "AbilityUnitDamageType"  "DAMAGE_TYPE_PHYSICAL"
    "AbilityTextureName"     "alchemist_acid_spray"
    // Casting
    //-------------------------------------------------------------------------------------------------------------
    "AbilityCastPoint"  "0.2"
    "AbilityCastRange"  "900"
    "OnOwnerDied"
    {
        "CreateThinker"
        {
            "ModifierName" "creature_acid_spray_thinker"
            "Target" "CASTER"
        }
    }
    "Modifiers"
    {
        "creature_acid_spray_thinker"
        {
            "Aura" "create_acid_spray_armor_reduction_aura"
            "Aura_Radius" "%radius"
            "Aura_Teams" "DOTA_UNIT_TARGET_TEAM_ENEMY"
            "Aura_Types" "DOTA_UNIT_TARGET_HERO | DOTA_UNIT_TARGET_CREEP | DOTA_UNIT_TARGET_MECHANICAL"
            "Aura_Flags" "DOTA_UNIT_TARGET_FLAG_MAGIC_IMMUNE_ENEMIES"
            "Duration" "%duration"
            "OnCreated"
            {
                "AttachEffect"
                {
                    "EffectName" "particles/units/heroes/hero_alchemist/alchemist_acid_spray.vpcf"
                    "EffectAttachType" "follow_origin"
                    "Target" "TARGET"
                    "ControlPoints"
                    {
                        "00" "0 0 0"
                        "01" "%radius 1 1"
                    }
                }
            }
        }
        "create_acid_spray_armor_reduction_aura"
        {
            "IsDebuff" "1"
            "IsPurgable" "0"
            "EffectName" "particles/units/heroes/hero_alchemist/alchemist_acid_spray_debuff.vpcf"                
            "ThinkInterval" "%tick_rate"
            "OnIntervalThink"
            {
                "Damage"
                {
                    "Type"   "DAMAGE_TYPE_PHYSICAL"
                    "Damage" "%damage"
                    "Target" "TARGET"
                }
            }
            "Properties"
            {
                "MODIFIER_PROPERTY_PHYSICAL_ARMOR_BONUS" "%armor_reduction"
            }
        }
    }
    // Special    
    //-------------------------------------------------------------------------------------------------------------
    "AbilitySpecial"
    {
        "01"
        {
            "var_type"                "FIELD_INTEGER"
            "radius"                "250"
        }
        "02"
        {
            "var_type"                "FIELD_FLOAT"
            "duration"                "16.0"
        }
        "03"
        {
            "var_type"                "FIELD_INTEGER"
            "damage"                "118 128 138 158"
        }
        "04"
        {
            "var_type"                "FIELD_INTEGER"
            "armor_reduction"                "-3 -4 -5 -6"
        }
        "05"
        {
            "var_type"                "FIELD_FLOAT"
            "tick_rate"                "1.0"
        }
    }
}
</source>

== Orb Attack Example  ==
Causes an area of effect stun and damage similar to Sven's Storm Hammer ability.

<source lang="text">
"orb_ability_example"
{
    "BaseClass"                 "ability_datadriven"
    "AbilityBehavior"           "DOTA_ABILITY_BEHAVIOR_UNIT_TARGET | DOTA_ABILITY_BEHAVIOR_AUTOCAST| DOTA_ABILITY_BEHAVIOR_ATTACK"
    "AbilityUnitTargetTeam"     "DOTA_UNIT_TARGET_TEAM_ENEMY"
    "AbilityUnitTargetType"     "DOTA_UNIT_TARGET_ALL"
    "AbilityCastPoint"          "0.0"
    "AbilityCastRange"          "900"
    "AbilityCooldown"           "0"
    "AbilityManaCost"           "10"
    "AbilitySpecial"
    {
        "01"
        {
            "var_type"          "FIELD_INTEGER"
            "RangeDamage"       "75"
        }
    }

    "Modifiers"
    {
        "TestOrb_Modifier"
        {
            "Passive"     "1"
            "IsHidden"    "1"
            "Orb"
            {
                "Priority"          "DOTA_ORB_PRIORITY_ABILITY"
                "ProjectileName"    "particles/units/heroes/hero_sven/sven_spell_storm_bolt.vpcf"
                "CastAttack"        "1"
            }
            "OnOrbFire"
            {
                "SpendMana"
                {
                    "Mana"    "%AbilityManaCost"
                }
            }
            "OnOrbImpact"
            {
                "FireEffect"
                {
                    "EffectName"            "particles/units/heroes/hero_sven/sven_spell_warcry.vpcf"
                    "EffectAttachType"      "attach_hitloc"
                    "Target"                "TARGET"
                }
                "Damage"
                {
                    "Type"          "DAMAGE_TYPE_PURE"
                    "Damage"        "%RangeDamage"
                    "Target"
                    {
                        "Center"    "TARGET"
                        "Teams"     "DOTA_UNIT_TARGET_TEAM_ENEMY"
                        "Type"      "DOTA_UNIT_TARGET_ALL"
                        "Radius"    "275"
                    }
                }
                "Stun"
                {
                    "Duration"      "2"
                    "Target"
                    {
                        "Center"    "TARGET"
                        "Teams"     "DOTA_UNIT_TARGET_TEAM_ENEMY"
                        "Type"      "DOTA_UNIT_TARGET_ALL"
                        "Radius"    "275"
                    }
                }
            }
        }
    }
}
</source>

== System's Aura Example  ==
A Normally Aura Example

<source lang="text">
 "TestSysAura"
 {
  "BaseClass" "ability_datadriven"
  "AbilityBehavior" "DOTA_ABILITY_BEHAVIOR_AURA | DOTA_ABILITY_BEHAVIOR_PASSIVE"
  "AbilityUnitTargetTeam" "DOTA_UNIT_TARGET_TEAM_ENEMY"
  "AbilityUnitTargetType" "DOTA_UNIT_TARGET_ALL"
  "AbilityTextureName" "alchemist_acid_spray"
  "MaxLevel" "1"

  "AbilityCastPoint"    "0.0"
  "AbilityCastRange"    "500"
  "AbilityCooldown"    "0"
  "AbilityManaCost"    "0"

  "AbilitySpecial"
  {
   "01"
   {
    "var_type" "FIELD_INTEGER"
    "Range" "500"
   }
  }

  "Modifiers"
  {
   "TestSysAura_Modifier"
   {
    "Passive" "1"
    "IsHidden" "1"
    "Aura" "TestSysAura_FixAttackPercent"
    "Aura_Radius" "%Range"
    "Aura_Teams" "DOTA_UNIT_TARGET_TEAM_ENEMY"
    "Aura_Types" "DOTA_UNIT_TARGET_ALL"
   }

   "TestSysAura_FixAttackPercent"
   {
    "IsDebuff" "1"
    "IsPurgable" "0"
    "Properties"
    {
     "MODIFIER_PROPERTY_DAMAGEOUTGOING_PERCENTAGE" "-50"
    }
   }
  }
 }
</source>

== 一个自定义的光环实例(A CustomAura Example) ==

The effect of this aura is the same as the example above, but we can use this to find the aura's owner and effects from Lua, allowing us to manipulate the data to do other things. (Someone pls confirm that the translation is correct) 这个光环的效果和上面那个光环的效果一样。
但是通过这个我们可以在lua中得到光环的拥有者和作用单位。于是可以在lua里面对这些实体进行各种额外的操作。


<source lang="text">
//In Lua, we can get this entity
// AuraOwner -> EntIndexToHScript(keys.caster_entindex)
// AuraEffectUnit -> keys.target
 "TestCustomAura"
 {
  "BaseClass" "ability_datadriven"
  "AbilityBehavior" "DOTA_ABILITY_BEHAVIOR_AURA | DOTA_ABILITY_BEHAVIOR_PASSIVE"
  "AbilityUnitTargetTeam" "DOTA_UNIT_TARGET_TEAM_ENEMY"
  "AbilityUnitTargetType" "DOTA_UNIT_TARGET_ALL"
  "AbilityTextureName" "alchemist_acid_spray"
  "MaxLevel" "1"

  "AbilityCastPoint"    "0.0"
  "AbilityCastRange"    "500"
  "AbilityCooldown"    "0"
  "AbilityManaCost"    "0"

  "AbilitySpecial"
  {
   "01"
   {
    "var_type" "FIELD_INTEGER"
    "Range" "500"
   }
  }

  "Modifiers"
  {
   "TestCustomAura_Modifier"
   {
    "Passive" "1"
    "IsHidden" "1"

    "ThinkInterval"  "0.5"
    "OnIntervalThink"
    {
     "ApplyModifier"
     {
      "ModifierName" "TestCustomAura_FixAttackPercentIcon"
      "Target"
      {
       "Teams"  "DOTA_UNIT_TARGET_TEAM_ENEMY"
       "Types"  "DOTA_UNIT_TARGET_ALL"
       "Center" "CASTER"
       "Radius" "%Range"
      }
     }
     "ApplyModifier"
     {
      "ModifierName" "TestCustomAura_FixAttackPercentTimer"
      "Target"
      {
       "Teams"  "DOTA_UNIT_TARGET_TEAM_ENEMY"
       "Types"  "DOTA_UNIT_TARGET_ALL"
       "Center" "CASTER"
       "Radius" "%Range"
      }
     }
    }
   }

   "TestCustomAura_FixAttackPercentIcon"
   {
    "IsDebuff" "1"
    "IsPurgable" "0"
    "TextureName" "alchemist_acid_spray"
    "Properties"
    {
     "MODIFIER_PROPERTY_DAMAGEOUTGOING_PERCENTAGE" "-50"
    }

   }

   "TestCustomAura_FixAttackPercentTimer"
   {
    "IsDebuff" "1"
    "IsPurgable" "0"
    "IsHidden" "1"
    "Duration" "0.6"
    "OnDestroy"
    {
     "RemoveModifier"
     {
      "ModifierName" "TestCustomAura_FixAttackPercentIcon"
      "Target" "TARGET"
     }
    }
   }
  }
 }
</source>

{{shortpagetitle}}
[[Category:Dota 2 Workshop Tools]]
