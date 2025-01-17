﻿using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacilityManagement
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = false;

        [Description("Make infinite ammo for weapon.")]
        public List<ItemType> InfiniteAmmo { get; set; } = new()
        {
            ItemType.ParticleDisruptor,
        };

        [Description("Make infinite ammo for weapon.")]
        public float EnergyMicroHid { get; set; } = 1f;
        [Description("Make infinite ammo for weapon.")]
        public float EnergyRadio { get; set; } = 1f;

        [Description("Time for generator to be Activated after being enable (-1 disable the config)")]
        public float GeneratorDuration { get; set; } = -1;

        [Description("Sets the health of breakable windows.")]
        public Dictionary<GlassType, float> WindowHealth { get; set; } = new()
        {
            {GlassType.Scp079Trigger, 100},
        };


        [Description("Sets the health of breakable Door (-1 will make it Undestructible).")]
        public Dictionary<DoorType, float> DoorHealth { get; set; } = new()
        {
            {DoorType.PrisonDoor, 1},
        };


        [Description("Sets the ignored damage of breakable Door (0 will make it Destructible for everything and 17 undestructible).")]
        public Dictionary<DoorType, DoorDamageType> DoorDamageTypeIgnored { get; set; } = new()
        {
            {DoorType.HID, DoorDamageType.Weapon | DoorDamageType.Grenade},
        };

        [Description("Sets the time for Lift to teleport")]
        public Dictionary<ElevatorType, float> LiftMoveDuration { get; set; } = new();

        [Description(@"Custom intercom content. If there's no specific content, then the default client content is used.
        # Check GitHub ReadMe for more info (https://github.com/louis1706/FacilityManagement/blob/main/readme.md)")]
        public Dictionary<Intercom.State, string> CustomText { get; set; } = new() 
        {
            {Intercom.State.Muted, "Issou you are muted"},
        };

        [Description("If all items and ragdolls in the facility should be removed after detonation.")]
        public bool WarheadCleanup { get; set; } = true;

        [Description("How many sacrifices it takes to lure 106. Values below 1 set the recontainer to always active.")]
        public int Scp106LureAmount { get; set; } = 1;
        
        [Description("Probability of succes for sacrifice work before enough player was enter in the recontainer")]
        public float Scp106ChanceOfSuccess { get; set; } = 100;

        [Description("Amount of time before another sacrifice can be made.")]
        public int Scp106LureReload { get; set; } = 0;

        [Description("Teams that can enter the femur breaker.")]
        public List<Team> Scp106LureTeam { get; set; } = new()
        {
            Team.MTF,
            Team.CHI,
            Team.RSC,
            Team.CDP,
        };
        public Dictionary<RoleType, AhpProccessBuild> RoleTypeHumeShield { get; set; } = new()
        {
            { RoleType.Scp049, 
                new AhpProccessBuild{
                    Amount = 60,
                    Regen = 1.5f,
                    Efficacy = 1,
                    Sustain = 5,
                } 
            },
        };

    }
}
