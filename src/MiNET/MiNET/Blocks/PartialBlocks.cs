﻿#region LICENSE

// The contents of this file are subject to the Common Public Attribution
// License Version 1.0. (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
// https://github.com/NiclasOlofsson/MiNET/blob/master/LICENSE.
// The License is based on the Mozilla Public License Version 1.1, but Sections 14
// and 15 have been added to cover use of software over a computer network and
// provide for limited attribution for the Original Developer. In addition, Exhibit A has
// been modified to be consistent with Exhibit B.
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// The Original Code is MiNET.
// 
// The Original Developer is the Initial Developer.  The Initial Developer of
// the Original Code is Niclas Olofsson.
// 
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2020 Niclas Olofsson.
// All Rights Reserved.

#endregion

using System;
using System.Collections.Generic;
using MiNET.Utils;
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantDefaultMemberInitializer
// ReSharper disable UseObjectOrCollectionInitializer
// ReSharper disable RemoveRedundantBraces
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable 1522

namespace MiNET.Blocks
{

    public partial class AcaciaButton  // 395 typeof=AcaciaButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_button";
            record.Id = 395;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaDoor  // 196 typeof=AcaciaDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_door";
            record.Id = 196;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaFence : Block // 85 typeof=Fence
    {
        
        public AcaciaFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class AcaciaFenceGate  // 187 typeof=AcaciaFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_fence_gate";
            record.Id = 187;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public AcaciaHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class AcaciaLog : LogBase // 162 typeof=Log2
	{
        public AcaciaLog() : base(162)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_log";
            record.Id = 162;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class AcaciaPressurePlate : Block // 405 typeof=AcaciaPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public AcaciaPressurePlate() : base(405)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_pressure_plate";
            record.Id = 405;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class AcaciaStairs  // 163 typeof=AcaciaStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_stairs";
            record.Id = 163;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaStandingSign  // 445 typeof=AcaciaStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_standing_sign";
            record.Id = 445;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class AcaciaTrapdoor  // 400 typeof=AcaciaTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_trapdoor";
            record.Id = 400;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class AcaciaWallSign  // 446 typeof=AcaciaWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:acacia_wall_sign";
            record.Id = 446;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ActivatorRail  // 126 typeof=ActivatorRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:activator_rail";
            record.Id = 126;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class Air  // 0 typeof=Air
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:air";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Allow : Block // 0 typeof=Air
    {
        
        public Allow() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:allow";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class AmethystBlock : Block // 0 typeof=Air
    {
        
        public AmethystBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:amethyst_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class AmethystCluster : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public AmethystCluster() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:amethyst_cluster";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class AncientDebris : Block // 0 typeof=Air
    {
        
        public AncientDebris() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ancient_debris";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class AndesiteStairs  // 426 typeof=AndesiteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:andesite_stairs";
            record.Id = 426;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Anvil  // 145 typeof=Anvil
    {
        [StateEnum("undamaged","slightly_damaged","very_damaged","broken")]
        public  string Damage { get; set; } = "undamaged";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "damage":
                        Damage = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:anvil";
            record.Id = 145;
            record.States.Add(new BlockStateString {Name = "damage", Value = Damage});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class Azalea : Block // 0 typeof=Air
    {
        
        public Azalea() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:azalea";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class AzaleaLeaves : Block // 0 typeof=Air
    {
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;
        
        public AzaleaLeaves() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:azalea_leaves";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class AzaleaLeavesFlowered : Block // 0 typeof=Air
    {
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;
        
        public AzaleaLeavesFlowered() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:azalea_leaves_flowered";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class Bamboo : Block // 418 typeof=Bamboo
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("small_leaves","large_leaves","no_leaves")]
        public  string BambooLeafSize { get; set; } = "";
        [StateEnum("thin","thick")]
        public  string BambooStalkThickness { get; set; } = "";
        
        public Bamboo() : base(418)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "bamboo_leaf_size":
                        BambooLeafSize = s.Value;
                        break;
                    case BlockStateString s when s.Name == "bamboo_stalk_thickness":
                        BambooStalkThickness = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo";
            record.Id = 418;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "bamboo_leaf_size", Value = BambooLeafSize});
            record.States.Add(new BlockStateString {Name = "bamboo_stalk_thickness", Value = BambooStalkThickness});
            return record;
        } // method
    } // class

    public partial class BambooBlock : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public BambooBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_block";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class BambooButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public BambooButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BambooDoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public BambooDoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_door";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class BambooDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public BambooDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class BambooFence : Block // 0 typeof=Air
    {
        
        public BambooFence() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_fence";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class BambooFenceGate : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public BambooFenceGate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_fence_gate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class BambooHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public BambooHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class BambooMosaic : Block // 0 typeof=Air
    {
        
        public BambooMosaic() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_mosaic";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class BambooMosaicDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public BambooMosaicDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_mosaic_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class BambooMosaicSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public BambooMosaicSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_mosaic_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class BambooMosaicStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public BambooMosaicStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_mosaic_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BambooPlanks : Block // 0 typeof=Air
    {
        
        public BambooPlanks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_planks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class BambooPressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public BambooPressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class BambooSapling : Block // 419 typeof=BambooSapling
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string SaplingType { get; set; } = "";
        
        public BambooSapling() : base(419)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "sapling_type":
                        SaplingType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_sapling";
            record.Id = 419;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "sapling_type", Value = SaplingType});
            return record;
        } // method
    } // class

    public partial class BambooSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public BambooSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class BambooStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public BambooStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BambooStandingSign : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        
        public BambooStandingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_standing_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class BambooTrapdoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        
        public BambooTrapdoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_trapdoor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class BambooWallSign : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public BambooWallSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bamboo_wall_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Barrel : Block // 458 typeof=Barrel
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public Barrel() : base(458)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:barrel";
            record.Id = 458;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class Barrier : Block // 416 typeof=Barrier
    {
        
        public Barrier() : base(416)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:barrier";
            record.Id = 416;
            return record;
        } // method
    } // class

    public partial class Basalt : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public Basalt() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:basalt";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class Beacon  // 138 typeof=Beacon
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beacon";
            record.Id = 138;
            return record;
        } // method
    } // class

    public partial class Bed  // 26 typeof=Bed
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool HeadPieceBit { get; set; } = false;
        [StateBit] public  bool OccupiedBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "head_piece_bit":
                        HeadPieceBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "occupied_bit":
                        OccupiedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bed";
            record.Id = 26;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "head_piece_bit", Value = Convert.ToByte(HeadPieceBit)});
            record.States.Add(new BlockStateByte {Name = "occupied_bit", Value = Convert.ToByte(OccupiedBit)});
            return record;
        } // method
    } // class

    public partial class Bedrock  // 7 typeof=Bedrock
    {
        [StateBit] public  bool InfiniburnBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "infiniburn_bit":
                        InfiniburnBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bedrock";
            record.Id = 7;
            record.States.Add(new BlockStateByte {Name = "infiniburn_bit", Value = Convert.ToByte(InfiniburnBit)});
            return record;
        } // method
    } // class

    public partial class BeeNest : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 5)] public  int HoneyLevel { get; set; } = 0;
        
        public BeeNest() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "honey_level":
                        HoneyLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bee_nest";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "honey_level", Value = HoneyLevel});
            return record;
        } // method
    } // class

    public partial class Beehive : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 5)] public  int HoneyLevel { get; set; } = 0;
        
        public Beehive() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "honey_level":
                        HoneyLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beehive";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "honey_level", Value = HoneyLevel});
            return record;
        } // method
    } // class

    public partial class Beetroot  // 244 typeof=Beetroot
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:beetroot";
            record.Id = 244;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class Bell : Block // 461 typeof=Bell
    {
        [StateEnum("standing","hanging","side","multiple")]
        public  string Attachment { get; set; } = "standing";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool ToggleBit { get; set; } = false;
        
        public Bell() : base(461)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "attachment":
                        Attachment = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "toggle_bit":
                        ToggleBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bell";
            record.Id = 461;
            record.States.Add(new BlockStateString {Name = "attachment", Value = Attachment});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "toggle_bit", Value = Convert.ToByte(ToggleBit)});
            return record;
        } // method
    } // class

    public partial class BigDripleaf : Block // 0 typeof=Air
    {
        [StateBit] public  bool BigDripleafHead { get; set; } = false;
        [StateEnum("none","unstable","partial_tilt","full_tilt")]
        public  string BigDripleafTilt { get; set; } = "none";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public BigDripleaf() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "big_dripleaf_head":
                        BigDripleafHead = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "big_dripleaf_tilt":
                        BigDripleafTilt = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:big_dripleaf";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "big_dripleaf_head", Value = Convert.ToByte(BigDripleafHead)});
            record.States.Add(new BlockStateString {Name = "big_dripleaf_tilt", Value = BigDripleafTilt});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class BirchButton  // 396 typeof=BirchButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_button";
            record.Id = 396;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BirchDoor  // 194 typeof=BirchDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_door";
            record.Id = 194;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class BirchFence : Block // 85 typeof=Fence
    {
        
        public BirchFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class BirchFenceGate  // 184 typeof=BirchFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_fence_gate";
            record.Id = 184;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class BirchHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public BirchHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class BirchLog : LogBase // 17 typeof=Log
	{
        public BirchLog() : base(17)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_log";
            record.Id = 17;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class BirchPressurePlate : Block // 406 typeof=BirchPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public BirchPressurePlate() : base(406)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_pressure_plate";
            record.Id = 406;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class BirchStairs  // 135 typeof=BirchStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_stairs";
            record.Id = 135;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BirchStandingSign  // 441 typeof=BirchStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_standing_sign";
            record.Id = 441;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class BirchTrapdoor  // 401 typeof=BirchTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_trapdoor";
            record.Id = 401;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class BirchWallSign  // 442 typeof=BirchWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:birch_wall_sign";
            record.Id = 442;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlackCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BlackCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:black_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BlackCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BlackCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:black_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BlackGlazedTerracotta  // 235 typeof=BlackGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:black_glazed_terracotta";
            record.Id = 235;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlackWool : Block // 35 typeof=Wool
    {
        
        public BlackWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:black_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class Blackstone : Block // 0 typeof=Air
    {
        
        public Blackstone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blackstone";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class BlackstoneSlab // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blackstone_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class BlackstoneStairs // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blackstone_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BlackstoneWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public BlackstoneWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blackstone_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class BlastFurnace  // 451 typeof=BlastFurnace
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blast_furnace";
            record.Id = 451;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlueCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BlueCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BlueCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BlueCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BlueGlazedTerracotta  // 231 typeof=BlueGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_glazed_terracotta";
            record.Id = 231;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BlueIce : Block // 266 typeof=BlueIce
    {
        
        public BlueIce() : base(266)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_ice";
            record.Id = 266;
            return record;
        } // method
    } // class

    public partial class BlueWool : Block // 35 typeof=Wool
    {
        
        public BlueWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:blue_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class BoneBlock : Block // 216 typeof=BoneBlock
    {
        [StateRange(0, 3)] public  int Deprecated { get; set; } = 0;
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";
        
        public BoneBlock() : base(216)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "deprecated":
                        Deprecated = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bone_block";
            record.Id = 216;
            record.States.Add(new BlockStateInt {Name = "deprecated", Value = Deprecated});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class Bookshelf  // 47 typeof=Bookshelf
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bookshelf";
            record.Id = 47;
            return record;
        } // method
    } // class

    public partial class BorderBlock : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public BorderBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:border_block";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class BrewingStand  // 117 typeof=BrewingStand
    {
        [StateBit] public  bool BrewingStandSlotABit { get; set; } = false;
        [StateBit] public  bool BrewingStandSlotBBit { get; set; } = false;
        [StateBit] public  bool BrewingStandSlotCBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "brewing_stand_slot_a_bit":
                        BrewingStandSlotABit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "brewing_stand_slot_b_bit":
                        BrewingStandSlotBBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "brewing_stand_slot_c_bit":
                        BrewingStandSlotCBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brewing_stand";
            record.Id = 117;
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_a_bit", Value = Convert.ToByte(BrewingStandSlotABit)});
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_b_bit", Value = Convert.ToByte(BrewingStandSlotBBit)});
            record.States.Add(new BlockStateByte {Name = "brewing_stand_slot_c_bit", Value = Convert.ToByte(BrewingStandSlotCBit)});
            return record;
        } // method
    } // class

    public partial class BrickBlock  // 45 typeof=BrickBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brick_block";
            record.Id = 45;
            return record;
        } // method
    } // class

    public partial class BrickStairs  // 108 typeof=BrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brick_stairs";
            record.Id = 108;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class BrownCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BrownCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BrownCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public BrownCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class BrownGlazedTerracotta  // 232 typeof=BrownGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_glazed_terracotta";
            record.Id = 232;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class BrownMushroom  // 39 typeof=BrownMushroom
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_mushroom";
            record.Id = 39;
            return record;
        } // method
    } // class

    public partial class BrownMushroomBlock  // 99 typeof=BrownMushroomBlock
    {
        [StateRange(0, 15)] public  int HugeMushroomBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "huge_mushroom_bits":
                        HugeMushroomBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_mushroom_block";
            record.Id = 99;
            record.States.Add(new BlockStateInt {Name = "huge_mushroom_bits", Value = HugeMushroomBits});
            return record;
        } // method
    } // class

    public partial class BrownWool : Block // 35 typeof=Wool
    {
        
        public BrownWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:brown_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class BubbleColumn : Block // 415 typeof=BubbleColumn
    {
        [StateBit] public  bool DragDown { get; set; } = false;
        
        public BubbleColumn() : base(415)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "drag_down":
                        DragDown = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:bubble_column";
            record.Id = 415;
            record.States.Add(new BlockStateByte {Name = "drag_down", Value = Convert.ToByte(DragDown)});
            return record;
        } // method
    } // class

    public partial class BuddingAmethyst : Block // 0 typeof=Air
    {
        
        public BuddingAmethyst() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:budding_amethyst";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Cactus  // 81 typeof=Cactus
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cactus";
            record.Id = 81;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class Cake  // 92 typeof=Cake
    {
        [StateRange(0, 6)] public  int BiteCounter { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "bite_counter":
                        BiteCounter = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cake";
            record.Id = 92;
            record.States.Add(new BlockStateInt {Name = "bite_counter", Value = BiteCounter});
            return record;
        } // method
    } // class

    public partial class Calcite : Block // 0 typeof=Air
    {
        
        public Calcite() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:calcite";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CalibratedSculkSensor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool PoweredBit { get; set; } = false;
        
        public CalibratedSculkSensor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:calibrated_sculk_sensor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Camera : Block // 0 typeof=Air
    {
        
        public Camera() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:camera";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Campfire : Block // 464 typeof=Campfire
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool Extinguished { get; set; } = false;
        
        public Campfire() : base(464)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "extinguished":
                        Extinguished = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:campfire";
            record.Id = 464;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "extinguished", Value = Convert.ToByte(Extinguished)});
            return record;
        } // method
    } // class

    public partial class Candle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public Candle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class CandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public CandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class Carpet  // 171 typeof=Carpet
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:carpet";
            record.Id = 171;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class Carrots  // 141 typeof=Carrots
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:carrots";
            record.Id = 141;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class CartographyTable : Block // 455 typeof=CartographyTable
    {
        
        public CartographyTable() : base(455)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cartography_table";
            record.Id = 455;
            return record;
        } // method
    } // class

    public partial class CarvedPumpkin : Block // 410 typeof=CarvedPumpkin
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public CarvedPumpkin() : base(410)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:carved_pumpkin";
            record.Id = 410;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class Cauldron  // 118 typeof=Cauldron
    {
        [StateEnum("water","powder_snow","lava")]
        public  string CauldronLiquid { get; set; } = "water";
        [StateRange(0, 6)] public  int FillLevel { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "cauldron_liquid":
                        CauldronLiquid = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "fill_level":
                        FillLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cauldron";
            record.Id = 118;
            record.States.Add(new BlockStateString {Name = "cauldron_liquid", Value = CauldronLiquid});
            record.States.Add(new BlockStateInt {Name = "fill_level", Value = FillLevel});
            return record;
        } // method
    } // class

    public partial class CaveVines : Block // 0 typeof=Air
    {
        [StateRange(0, 25)] public  int GrowingPlantAge { get; set; } = 0;
        
        public CaveVines() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growing_plant_age":
                        GrowingPlantAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cave_vines";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "growing_plant_age", Value = GrowingPlantAge});
            return record;
        } // method
    } // class

    public partial class CaveVinesBodyWithBerries : Block // 0 typeof=Air
    {
        [StateRange(0, 25)] public  int GrowingPlantAge { get; set; } = 0;
        
        public CaveVinesBodyWithBerries() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growing_plant_age":
                        GrowingPlantAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cave_vines_body_with_berries";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "growing_plant_age", Value = GrowingPlantAge});
            return record;
        } // method
    } // class

    public partial class CaveVinesHeadWithBerries : Block // 0 typeof=Air
    {
        [StateRange(0, 25)] public  int GrowingPlantAge { get; set; } = 0;
        
        public CaveVinesHeadWithBerries() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growing_plant_age":
                        GrowingPlantAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cave_vines_head_with_berries";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "growing_plant_age", Value = GrowingPlantAge});
            return record;
        } // method
    } // class

    public partial class Chain : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public Chain() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chain";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class ChainCommandBlock : Block // 189 typeof=ChainCommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public ChainCommandBlock() : base(189)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chain_command_block";
            record.Id = 189;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ChemicalHeat : Block // 192 typeof=ChemicalHeat
    {
        
        public ChemicalHeat() : base(192)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chemical_heat";
            record.Id = 192;
            return record;
        } // method
    } // class

    public partial class ChemistryTable : Block // 238 typeof=ChemistryTable
    {
        [StateEnum("compound_creator","material_reducer","element_constructor","lab_table")]
        public  string ChemistryTableType { get; set; } = "compound_creator";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public ChemistryTable() : base(238)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chemistry_table_type":
                        ChemistryTableType = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chemistry_table";
            record.Id = 238;
            record.States.Add(new BlockStateString {Name = "chemistry_table_type", Value = ChemistryTableType});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class CherryButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public CherryButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class CherryDoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public CherryDoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_door";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class CherryDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public CherryDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CherryFence : Block // 0 typeof=Air
    {
        
        public CherryFence() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_fence";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CherryFenceGate : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public CherryFenceGate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_fence_gate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class CherryHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public CherryHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class CherryLeaves : Block // 0 typeof=Air
    {
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;
        
        public CherryLeaves() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_leaves";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class CherryLog : LogBase // 0 typeof=Air
	{
        public CherryLog() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_log";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class CherryPlanks : Block // 0 typeof=Air
    {
        
        public CherryPlanks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_planks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CherryPressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public CherryPressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class CherrySapling : Block // 0 typeof=Air
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        
        public CherrySapling() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_sapling";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            return record;
        } // method
    } // class

    public partial class CherrySlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public CherrySlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CherryStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public CherryStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class CherryStandingSign : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        
        public CherryStandingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_standing_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class CherryTrapdoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        
        public CherryTrapdoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_trapdoor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class CherryWallSign : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public CherryWallSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_wall_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class CherryWood : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        [StateBit] public  bool StrippedBit { get; set; } = false;
        
        public CherryWood() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "stripped_bit":
                        StrippedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cherry_wood";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            record.States.Add(new BlockStateByte {Name = "stripped_bit", Value = Convert.ToByte(StrippedBit)});
            return record;
        } // method
    } // class

    public partial class Chest  // 54 typeof=Chest
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chest";
            record.Id = 54;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ChiseledBookshelf : Block // 0 typeof=Air
    {
        [StateRange(0, 63)] public  int BooksStored { get; set; } = 0;
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public ChiseledBookshelf() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "books_stored":
                        BooksStored = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chiseled_bookshelf";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "books_stored", Value = BooksStored});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class ChiseledDeepslate : Block // 0 typeof=Air
    {
        
        public ChiseledDeepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chiseled_deepslate";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ChiseledNetherBricks : Block // 0 typeof=Air
    {
        
        public ChiseledNetherBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chiseled_nether_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ChiseledPolishedBlackstone : Block // 0 typeof=Air
    {
        
        public ChiseledPolishedBlackstone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chiseled_polished_blackstone";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ChorusFlower  // 200 typeof=ChorusFlower
    {
        [StateRange(0, 5)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chorus_flower";
            record.Id = 200;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class ChorusPlant  // 240 typeof=ChorusPlant
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:chorus_plant";
            record.Id = 240;
            return record;
        } // method
    } // class

    public partial class Clay  // 82 typeof=Clay
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:clay";
            record.Id = 82;
            return record;
        } // method
    } // class

    public partial class ClientRequestPlaceholderBlock : Block // 0 typeof=Air
    {
        
        public ClientRequestPlaceholderBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:client_request_placeholder_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CoalBlock  // 173 typeof=CoalBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coal_block";
            record.Id = 173;
            return record;
        } // method
    } // class

    public partial class CoalOre  // 16 typeof=CoalOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coal_ore";
            record.Id = 16;
            return record;
        } // method
    } // class

    public partial class CobbledDeepslate : Block // 0 typeof=Air
    {
        
        public CobbledDeepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobbled_deepslate";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CobbledDeepslateDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public CobbledDeepslateDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobbled_deepslate_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CobbledDeepslateSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public CobbledDeepslateSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobbled_deepslate_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CobbledDeepslateStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public CobbledDeepslateStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobbled_deepslate_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class CobbledDeepslateWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public CobbledDeepslateWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobbled_deepslate_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class Cobblestone  // 4 typeof=Cobblestone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobblestone";
            record.Id = 4;
            return record;
        } // method
    } // class

    public partial class CobblestoneWall // 0 typeof=Air
    {
        [StateEnum("cobblestone","mossy_cobblestone","granite","diorite","andesite","sandstone","brick","stone_brick","mossy_stone_brick","nether_brick","end_brick","prismarine","red_sandstone","red_nether_brick")]
        public  string WallBlockType { get; set; } = "cobblestone";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = true;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_block_type":
                        WallBlockType = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cobblestone_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_block_type", Value = WallBlockType});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class Cocoa  // 127 typeof=Cocoa
    {
        [StateRange(0, 2)] public  int Age { get; set; } = 0;
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cocoa";
            record.Id = 127;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class ColoredTorchBp : Block // 204 typeof=ColoredTorchBp
    {
        [StateBit] public  bool ColorBit { get; set; } = false;
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public ColoredTorchBp() : base(204)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "color_bit":
                        ColorBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:colored_torch_bp";
            record.Id = 204;
            record.States.Add(new BlockStateByte {Name = "color_bit", Value = Convert.ToByte(ColorBit)});
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class ColoredTorchRg : Block // 202 typeof=ColoredTorchRg
    {
        [StateBit] public  bool ColorBit { get; set; } = false;
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public ColoredTorchRg() : base(202)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "color_bit":
                        ColorBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:colored_torch_rg";
            record.Id = 202;
            record.States.Add(new BlockStateByte {Name = "color_bit", Value = Convert.ToByte(ColorBit)});
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class CommandBlock : Block // 137 typeof=CommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public CommandBlock() : base(137)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:command_block";
            record.Id = 137;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Composter : Block // 468 typeof=Composter
    {
        [StateRange(0, 8)] public  int ComposterFillLevel { get; set; } = 0;
        
        public Composter() : base(468)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "composter_fill_level":
                        ComposterFillLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:composter";
            record.Id = 468;
            record.States.Add(new BlockStateInt {Name = "composter_fill_level", Value = ComposterFillLevel});
            return record;
        } // method
    } // class

    public partial class Concrete  // 236 typeof=Concrete
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:concrete";
            record.Id = 236;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class ConcretePowder // 237 typeof=ConcretePowder
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:concrete_powder";
            record.Id = 237;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class Conduit : Block // 412 typeof=Conduit
    {
        
        public Conduit() : base(412)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:conduit";
            record.Id = 412;
            return record;
        } // method
    } // class

    public partial class CopperBlock : Block // 0 typeof=Air
    {
        
        public CopperBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:copper_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CopperOre : Block // 0 typeof=Air
    {
        
        public CopperOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:copper_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Coral : Block // 0 typeof=Air
    {
        [StateEnum("blue","pink","purple","red","yellow")]
        public  string CoralColor { get; set; } = "blue";
        [StateBit] public  bool DeadBit { get; set; } = true;
        
        public Coral() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralBlock : Block // 387 typeof=CoralBlock
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralBlock() : base(387)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_block";
            record.Id = 387;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFan : Block // 388 typeof=CoralFan
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateRange(0, 1)] public  int CoralFanDirection { get; set; } = 0;
        
        public CoralFan() : base(388)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "coral_fan_direction":
                        CoralFanDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan";
            record.Id = 388;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateInt {Name = "coral_fan_direction", Value = CoralFanDirection});
            return record;
        } // method
    } // class

    public partial class CoralFanDead : Block // 389 typeof=CoralFanDead
    {
        [StateEnum("pink","purple","red","yellow","blue")]
        public  string CoralColor { get; set; } = "";
        [StateRange(0, 1)] public  int CoralFanDirection { get; set; } = 0;
        
        public CoralFanDead() : base(389)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "coral_color":
                        CoralColor = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "coral_fan_direction":
                        CoralFanDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_dead";
            record.Id = 389;
            record.States.Add(new BlockStateString {Name = "coral_color", Value = CoralColor});
            record.States.Add(new BlockStateInt {Name = "coral_fan_direction", Value = CoralFanDirection});
            return record;
        } // method
    } // class

    public partial class CoralFanHang : Block // 390 typeof=CoralFanHang
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang() : base(390)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang";
            record.Id = 390;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFanHang2 : Block // 391 typeof=CoralFanHang2
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang2() : base(391)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang2";
            record.Id = 391;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CoralFanHang3 : Block // 392 typeof=CoralFanHang3
    {
        [StateRange(0, 3)] public  int CoralDirection { get; set; } = 0;
        [StateBit] public  bool CoralHangTypeBit { get; set; } = false;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public CoralFanHang3() : base(392)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "coral_direction":
                        CoralDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "coral_hang_type_bit":
                        CoralHangTypeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:coral_fan_hang3";
            record.Id = 392;
            record.States.Add(new BlockStateInt {Name = "coral_direction", Value = CoralDirection});
            record.States.Add(new BlockStateByte {Name = "coral_hang_type_bit", Value = Convert.ToByte(CoralHangTypeBit)});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class CrackedDeepslateBricks : Block // 0 typeof=Air
    {
        
        public CrackedDeepslateBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cracked_deepslate_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrackedDeepslateTiles : Block // 0 typeof=Air
    {
        
        public CrackedDeepslateTiles() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cracked_deepslate_tiles";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrackedNetherBricks : Block // 0 typeof=Air
    {
        
        public CrackedNetherBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cracked_nether_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrackedPolishedBlackstoneBricks : Block // 0 typeof=Air
    {
        
        public CrackedPolishedBlackstoneBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cracked_polished_blackstone_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CraftingTable  // 58 typeof=CraftingTable
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crafting_table";
            record.Id = 58;
            return record;
        } // method
    } // class

    public partial class CrimsonButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public CrimsonButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class CrimsonDoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public CrimsonDoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_door";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class CrimsonDoubleSlab // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CrimsonFence : Block // 0 typeof=Air
    {
        
        public CrimsonFence() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_fence";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrimsonFenceGate : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public CrimsonFenceGate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_fence_gate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class CrimsonFungus : Block // 0 typeof=Air
    {
        
        public CrimsonFungus() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_fungus";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrimsonHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public CrimsonHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class CrimsonHyphae : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public CrimsonHyphae() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_hyphae";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class CrimsonNylium : Block // 0 typeof=Air
    {
        
        public CrimsonNylium() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_nylium";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrimsonPlanks : Block // 0 typeof=Air
    {
        
        public CrimsonPlanks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_planks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrimsonPressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public CrimsonPressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class CrimsonRoots : Block // 0 typeof=Air
    {
        
        public CrimsonRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_roots";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CrimsonSlab // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CrimsonStairs // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class CrimsonStandingSign // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_standing_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class CrimsonStem : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public CrimsonStem() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_stem";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class CrimsonTrapdoor // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_trapdoor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class CrimsonWallSign // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crimson_wall_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class CryingObsidian : Block // 0 typeof=Air
    {
        
        public CryingObsidian() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:crying_obsidian";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CutCopper : Block // 0 typeof=Air
    {
        
        public CutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class CutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public CutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class CutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public CutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class CyanCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public CyanCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cyan_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class CyanCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public CyanCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cyan_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class CyanGlazedTerracotta  // 229 typeof=CyanGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cyan_glazed_terracotta";
            record.Id = 229;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class CyanWool : Block // 35 typeof=Wool
    {
        
        public CyanWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:cyan_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class DarkOakButton  // 397 typeof=DarkOakButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_button";
            record.Id = 397;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class DarkOakDoor  // 197 typeof=DarkOakDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_door";
            record.Id = 197;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class DarkOakFence : Block // 85 typeof=Fence
    {
        
        public DarkOakFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class DarkOakFenceGate  // 186 typeof=DarkOakFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_fence_gate";
            record.Id = 186;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class DarkOakHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public DarkOakHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class DarkOakLog : LogBase // 162 typeof=Log2
	{
        public DarkOakLog() : base(162)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_log";
            record.Id = 162;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class DarkOakPressurePlate : Block // 407 typeof=DarkOakPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public DarkOakPressurePlate() : base(407)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_pressure_plate";
            record.Id = 407;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class DarkOakStairs  // 164 typeof=DarkOakStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_stairs";
            record.Id = 164;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DarkOakTrapdoor  // 402 typeof=DarkOakTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_oak_trapdoor";
            record.Id = 402;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class DarkPrismarineStairs  // 258 typeof=DarkPrismarineStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dark_prismarine_stairs";
            record.Id = 258;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DarkoakStandingSign  // 447 typeof=DarkoakStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:darkoak_standing_sign";
            record.Id = 447;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class DarkoakWallSign  // 448 typeof=DarkoakWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:darkoak_wall_sign";
            record.Id = 448;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class DaylightDetector  // 151 typeof=DaylightDetector
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:daylight_detector";
            record.Id = 151;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class DaylightDetectorInverted  // 178 typeof=DaylightDetectorInverted
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:daylight_detector_inverted";
            record.Id = 178;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class Deadbush  // 32 typeof=Deadbush
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deadbush";
            record.Id = 32;
            return record;
        } // method
    } // class

    public partial class DecoratedPot : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public DecoratedPot() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:decorated_pot";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class Deepslate : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public Deepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class DeepslateBrickDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DeepslateBrickDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_brick_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateBrickSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DeepslateBrickSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_brick_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateBrickStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public DeepslateBrickStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_brick_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DeepslateBrickWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public DeepslateBrickWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_brick_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateBricks : Block // 0 typeof=Air
    {
        
        public DeepslateBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateCoalOre : Block // 0 typeof=Air
    {
        
        public DeepslateCoalOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_coal_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateCopperOre : Block // 0 typeof=Air
    {
        
        public DeepslateCopperOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_copper_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateDiamondOre : Block // 0 typeof=Air
    {
        
        public DeepslateDiamondOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_diamond_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateEmeraldOre : Block // 0 typeof=Air
    {
        
        public DeepslateEmeraldOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_emerald_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateGoldOre : Block // 0 typeof=Air
    {
        
        public DeepslateGoldOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_gold_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateIronOre : Block // 0 typeof=Air
    {
        
        public DeepslateIronOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_iron_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateLapisOre : Block // 0 typeof=Air
    {
        
        public DeepslateLapisOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_lapis_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateRedstoneOre : Block // 0 typeof=Air
    {
        
        public DeepslateRedstoneOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_redstone_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DeepslateTileDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DeepslateTileDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_tile_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateTileSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DeepslateTileSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_tile_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateTileStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public DeepslateTileStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_tile_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class DeepslateTileWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public DeepslateTileWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_tile_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class DeepslateTiles : Block // 0 typeof=Air
    {
        
        public DeepslateTiles() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deepslate_tiles";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Deny : Block // 0 typeof=Air
    {
        
        public Deny() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:deny";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class DetectorRail  // 28 typeof=DetectorRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:detector_rail";
            record.Id = 28;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class DiamondBlock  // 57 typeof=DiamondBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diamond_block";
            record.Id = 57;
            return record;
        } // method
    } // class

    public partial class DiamondOre  // 56 typeof=DiamondOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diamond_ore";
            record.Id = 56;
            return record;
        } // method
    } // class

    public partial class DioriteStairs  // 425 typeof=DioriteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:diorite_stairs";
            record.Id = 425;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Dirt  // 3 typeof=Dirt
    {
        [StateEnum("normal","coarse")]
        public  string DirtType { get; set; } = "normal";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "dirt_type":
                        DirtType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dirt";
            record.Id = 3;
            record.States.Add(new BlockStateString {Name = "dirt_type", Value = DirtType});
            return record;
        } // method
    } // class

    public partial class DirtWithRoots : Block // 0 typeof=Air
    {
        
        public DirtWithRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dirt_with_roots";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Dispenser  // 23 typeof=Dispenser
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool TriggeredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "triggered_bit":
                        TriggeredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dispenser";
            record.Id = 23;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "triggered_bit", Value = Convert.ToByte(TriggeredBit)});
            return record;
        } // method
    } // class

    public partial class DoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DoublePlant  // 175 typeof=DoublePlant
    {
        [StateEnum("syringa","grass","fern","rose","paeonia","sunflower")]
        public  string DoublePlantType { get; set; } = "";
        [StateBit] public  bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "double_plant_type":
                        DoublePlantType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_plant";
            record.Id = 175;
            record.States.Add(new BlockStateString {Name = "double_plant_type", Value = DoublePlantType});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class DoubleStoneBlockSlab : Block // 43 typeof=DoubleStoneSlab
    {
        [StateEnum("smooth_stone","sandstone","wood","cobblestone","brick","stone_brick","quartz","nether_brick")]
        public  string StoneSlabType { get; set; } = "smooth_stone";
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DoubleStoneBlockSlab() : base(43)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type":
                        StoneSlabType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_stone_block_slab";
            record.Id = 43;
            record.States.Add(new BlockStateString {Name = "stone_slab_type", Value = StoneSlabType});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DoubleStoneBlockSlab2 : Block // 181 typeof=DoubleStoneSlab2
    {
        [StateEnum("red_sandstone","purpur","prismarine_rough","prismarine_dark","prismarine_brick","mossy_cobblestone","smooth_sandstone","red_nether_brick")]
        public  string StoneSlabType2 { get; set; } = "red_sandstone";
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DoubleStoneBlockSlab2() : base(181)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_2":
                        StoneSlabType2 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_stone_block_slab2";
            record.Id = 181;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_2", Value = StoneSlabType2});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DoubleStoneBlockSlab3 : Block // 422 typeof=DoubleStoneSlab3
    {
        [StateEnum("end_stone_brick","smooth_red_sandstone","polished_andesite","andesite","diorite","polished_diorite","granite","polished_granite")]
        public  string StoneSlabType3 { get; set; } = "end_stone_brick";
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DoubleStoneBlockSlab3() : base(422)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_3":
                        StoneSlabType3 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_stone_block_slab3";
            record.Id = 422;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_3", Value = StoneSlabType3});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DoubleStoneBlockSlab4 : Block // 423 typeof=DoubleStoneSlab4
    {
        [StateEnum("smooth_quartz","stone","cut_sandstone","cut_red_sandstone","mossy_stone_brick")]
        public  string StoneSlabType4 { get; set; } = "";
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public DoubleStoneBlockSlab4() : base(423)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_4":
                        StoneSlabType4 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_stone_block_slab4";
            record.Id = 423;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_4", Value = StoneSlabType4});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class DoubleWoodenSlab  // 157 typeof=DoubleWoodenSlab
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string WoodType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:double_wooden_slab";
            record.Id = 157;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class DragonEgg  // 122 typeof=DragonEgg
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dragon_egg";
            record.Id = 122;
            return record;
        } // method
    } // class

    public partial class DriedKelpBlock : Block // 394 typeof=DriedKelpBlock
    {
        
        public DriedKelpBlock() : base(394)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dried_kelp_block";
            record.Id = 394;
            return record;
        } // method
    } // class

    public partial class DripstoneBlock : Block // 0 typeof=Air
    {
        
        public DripstoneBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dripstone_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Dropper  // 125 typeof=Dropper
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool TriggeredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "triggered_bit":
                        TriggeredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:dropper";
            record.Id = 125;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "triggered_bit", Value = Convert.ToByte(TriggeredBit)});
            return record;
        } // method
    } // class

    public partial class Element0 : Block // 36 typeof=Element0
    {
        
        public Element0() : base(36)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_0";
            record.Id = 36;
            return record;
        } // method
    } // class

    public partial class Element1 : Block // 267 typeof=Element1
    {
        
        public Element1() : base(267)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_1";
            record.Id = 267;
            return record;
        } // method
    } // class

    public partial class Element10 : Block // 276 typeof=Element10
    {
        
        public Element10() : base(276)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_10";
            record.Id = 276;
            return record;
        } // method
    } // class

    public partial class Element100 : Block // 366 typeof=Element100
    {
        
        public Element100() : base(366)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_100";
            record.Id = 366;
            return record;
        } // method
    } // class

    public partial class Element101 : Block // 367 typeof=Element101
    {
        
        public Element101() : base(367)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_101";
            record.Id = 367;
            return record;
        } // method
    } // class

    public partial class Element102 : Block // 368 typeof=Element102
    {
        
        public Element102() : base(368)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_102";
            record.Id = 368;
            return record;
        } // method
    } // class

    public partial class Element103 : Block // 369 typeof=Element103
    {
        
        public Element103() : base(369)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_103";
            record.Id = 369;
            return record;
        } // method
    } // class

    public partial class Element104 : Block // 370 typeof=Element104
    {
        
        public Element104() : base(370)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_104";
            record.Id = 370;
            return record;
        } // method
    } // class

    public partial class Element105 : Block // 371 typeof=Element105
    {
        
        public Element105() : base(371)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_105";
            record.Id = 371;
            return record;
        } // method
    } // class

    public partial class Element106 : Block // 372 typeof=Element106
    {
        
        public Element106() : base(372)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_106";
            record.Id = 372;
            return record;
        } // method
    } // class

    public partial class Element107 : Block // 373 typeof=Element107
    {
        
        public Element107() : base(373)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_107";
            record.Id = 373;
            return record;
        } // method
    } // class

    public partial class Element108 : Block // 374 typeof=Element108
    {
        
        public Element108() : base(374)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_108";
            record.Id = 374;
            return record;
        } // method
    } // class

    public partial class Element109 : Block // 375 typeof=Element109
    {
        
        public Element109() : base(375)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_109";
            record.Id = 375;
            return record;
        } // method
    } // class

    public partial class Element11 : Block // 277 typeof=Element11
    {
        
        public Element11() : base(277)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_11";
            record.Id = 277;
            return record;
        } // method
    } // class

    public partial class Element110 : Block // 376 typeof=Element110
    {
        
        public Element110() : base(376)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_110";
            record.Id = 376;
            return record;
        } // method
    } // class

    public partial class Element111 : Block // 377 typeof=Element111
    {
        
        public Element111() : base(377)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_111";
            record.Id = 377;
            return record;
        } // method
    } // class

    public partial class Element112 : Block // 378 typeof=Element112
    {
        
        public Element112() : base(378)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_112";
            record.Id = 378;
            return record;
        } // method
    } // class

    public partial class Element113 : Block // 379 typeof=Element113
    {
        
        public Element113() : base(379)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_113";
            record.Id = 379;
            return record;
        } // method
    } // class

    public partial class Element114 : Block // 380 typeof=Element114
    {
        
        public Element114() : base(380)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_114";
            record.Id = 380;
            return record;
        } // method
    } // class

    public partial class Element115 : Block // 381 typeof=Element115
    {
        
        public Element115() : base(381)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_115";
            record.Id = 381;
            return record;
        } // method
    } // class

    public partial class Element116 : Block // 382 typeof=Element116
    {
        
        public Element116() : base(382)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_116";
            record.Id = 382;
            return record;
        } // method
    } // class

    public partial class Element117 : Block // 383 typeof=Element117
    {
        
        public Element117() : base(383)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_117";
            record.Id = 383;
            return record;
        } // method
    } // class

    public partial class Element118 : Block // 384 typeof=Element118
    {
        
        public Element118() : base(384)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_118";
            record.Id = 384;
            return record;
        } // method
    } // class

    public partial class Element12 : Block // 278 typeof=Element12
    {
        
        public Element12() : base(278)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_12";
            record.Id = 278;
            return record;
        } // method
    } // class

    public partial class Element13 : Block // 279 typeof=Element13
    {
        
        public Element13() : base(279)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_13";
            record.Id = 279;
            return record;
        } // method
    } // class

    public partial class Element14 : Block // 280 typeof=Element14
    {
        
        public Element14() : base(280)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_14";
            record.Id = 280;
            return record;
        } // method
    } // class

    public partial class Element15 : Block // 281 typeof=Element15
    {
        
        public Element15() : base(281)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_15";
            record.Id = 281;
            return record;
        } // method
    } // class

    public partial class Element16 : Block // 282 typeof=Element16
    {
        
        public Element16() : base(282)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_16";
            record.Id = 282;
            return record;
        } // method
    } // class

    public partial class Element17 : Block // 283 typeof=Element17
    {
        
        public Element17() : base(283)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_17";
            record.Id = 283;
            return record;
        } // method
    } // class

    public partial class Element18 : Block // 284 typeof=Element18
    {
        
        public Element18() : base(284)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_18";
            record.Id = 284;
            return record;
        } // method
    } // class

    public partial class Element19 : Block // 285 typeof=Element19
    {
        
        public Element19() : base(285)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_19";
            record.Id = 285;
            return record;
        } // method
    } // class

    public partial class Element2 : Block // 268 typeof=Element2
    {
        
        public Element2() : base(268)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_2";
            record.Id = 268;
            return record;
        } // method
    } // class

    public partial class Element20 : Block // 286 typeof=Element20
    {
        
        public Element20() : base(286)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_20";
            record.Id = 286;
            return record;
        } // method
    } // class

    public partial class Element21 : Block // 287 typeof=Element21
    {
        
        public Element21() : base(287)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_21";
            record.Id = 287;
            return record;
        } // method
    } // class

    public partial class Element22 : Block // 288 typeof=Element22
    {
        
        public Element22() : base(288)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_22";
            record.Id = 288;
            return record;
        } // method
    } // class

    public partial class Element23 : Block // 289 typeof=Element23
    {
        
        public Element23() : base(289)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_23";
            record.Id = 289;
            return record;
        } // method
    } // class

    public partial class Element24 : Block // 290 typeof=Element24
    {
        
        public Element24() : base(290)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_24";
            record.Id = 290;
            return record;
        } // method
    } // class

    public partial class Element25 : Block // 291 typeof=Element25
    {
        
        public Element25() : base(291)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_25";
            record.Id = 291;
            return record;
        } // method
    } // class

    public partial class Element26 : Block // 292 typeof=Element26
    {
        
        public Element26() : base(292)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_26";
            record.Id = 292;
            return record;
        } // method
    } // class

    public partial class Element27 : Block // 293 typeof=Element27
    {
        
        public Element27() : base(293)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_27";
            record.Id = 293;
            return record;
        } // method
    } // class

    public partial class Element28 : Block // 294 typeof=Element28
    {
        
        public Element28() : base(294)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_28";
            record.Id = 294;
            return record;
        } // method
    } // class

    public partial class Element29 : Block // 295 typeof=Element29
    {
        
        public Element29() : base(295)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_29";
            record.Id = 295;
            return record;
        } // method
    } // class

    public partial class Element3 : Block // 269 typeof=Element3
    {
        
        public Element3() : base(269)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_3";
            record.Id = 269;
            return record;
        } // method
    } // class

    public partial class Element30 : Block // 296 typeof=Element30
    {
        
        public Element30() : base(296)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_30";
            record.Id = 296;
            return record;
        } // method
    } // class

    public partial class Element31 : Block // 297 typeof=Element31
    {
        
        public Element31() : base(297)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_31";
            record.Id = 297;
            return record;
        } // method
    } // class

    public partial class Element32 : Block // 298 typeof=Element32
    {
        
        public Element32() : base(298)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_32";
            record.Id = 298;
            return record;
        } // method
    } // class

    public partial class Element33 : Block // 299 typeof=Element33
    {
        
        public Element33() : base(299)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_33";
            record.Id = 299;
            return record;
        } // method
    } // class

    public partial class Element34 : Block // 300 typeof=Element34
    {
        
        public Element34() : base(300)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_34";
            record.Id = 300;
            return record;
        } // method
    } // class

    public partial class Element35 : Block // 301 typeof=Element35
    {
        
        public Element35() : base(301)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_35";
            record.Id = 301;
            return record;
        } // method
    } // class

    public partial class Element36 : Block // 302 typeof=Element36
    {
        
        public Element36() : base(302)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_36";
            record.Id = 302;
            return record;
        } // method
    } // class

    public partial class Element37 : Block // 303 typeof=Element37
    {
        
        public Element37() : base(303)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_37";
            record.Id = 303;
            return record;
        } // method
    } // class

    public partial class Element38 : Block // 304 typeof=Element38
    {
        
        public Element38() : base(304)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_38";
            record.Id = 304;
            return record;
        } // method
    } // class

    public partial class Element39 : Block // 305 typeof=Element39
    {
        
        public Element39() : base(305)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_39";
            record.Id = 305;
            return record;
        } // method
    } // class

    public partial class Element4 : Block // 270 typeof=Element4
    {
        
        public Element4() : base(270)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_4";
            record.Id = 270;
            return record;
        } // method
    } // class

    public partial class Element40 : Block // 306 typeof=Element40
    {
        
        public Element40() : base(306)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_40";
            record.Id = 306;
            return record;
        } // method
    } // class

    public partial class Element41 : Block // 307 typeof=Element41
    {
        
        public Element41() : base(307)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_41";
            record.Id = 307;
            return record;
        } // method
    } // class

    public partial class Element42 : Block // 308 typeof=Element42
    {
        
        public Element42() : base(308)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_42";
            record.Id = 308;
            return record;
        } // method
    } // class

    public partial class Element43 : Block // 309 typeof=Element43
    {
        
        public Element43() : base(309)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_43";
            record.Id = 309;
            return record;
        } // method
    } // class

    public partial class Element44 : Block // 310 typeof=Element44
    {
        
        public Element44() : base(310)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_44";
            record.Id = 310;
            return record;
        } // method
    } // class

    public partial class Element45 : Block // 311 typeof=Element45
    {
        
        public Element45() : base(311)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_45";
            record.Id = 311;
            return record;
        } // method
    } // class

    public partial class Element46 : Block // 312 typeof=Element46
    {
        
        public Element46() : base(312)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_46";
            record.Id = 312;
            return record;
        } // method
    } // class

    public partial class Element47 : Block // 313 typeof=Element47
    {
        
        public Element47() : base(313)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_47";
            record.Id = 313;
            return record;
        } // method
    } // class

    public partial class Element48 : Block // 314 typeof=Element48
    {
        
        public Element48() : base(314)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_48";
            record.Id = 314;
            return record;
        } // method
    } // class

    public partial class Element49 : Block // 315 typeof=Element49
    {
        
        public Element49() : base(315)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_49";
            record.Id = 315;
            return record;
        } // method
    } // class

    public partial class Element5 : Block // 271 typeof=Element5
    {
        
        public Element5() : base(271)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_5";
            record.Id = 271;
            return record;
        } // method
    } // class

    public partial class Element50 : Block // 316 typeof=Element50
    {
        
        public Element50() : base(316)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_50";
            record.Id = 316;
            return record;
        } // method
    } // class

    public partial class Element51 : Block // 317 typeof=Element51
    {
        
        public Element51() : base(317)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_51";
            record.Id = 317;
            return record;
        } // method
    } // class

    public partial class Element52 : Block // 318 typeof=Element52
    {
        
        public Element52() : base(318)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_52";
            record.Id = 318;
            return record;
        } // method
    } // class

    public partial class Element53 : Block // 319 typeof=Element53
    {
        
        public Element53() : base(319)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_53";
            record.Id = 319;
            return record;
        } // method
    } // class

    public partial class Element54 : Block // 320 typeof=Element54
    {
        
        public Element54() : base(320)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_54";
            record.Id = 320;
            return record;
        } // method
    } // class

    public partial class Element55 : Block // 321 typeof=Element55
    {
        
        public Element55() : base(321)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_55";
            record.Id = 321;
            return record;
        } // method
    } // class

    public partial class Element56 : Block // 322 typeof=Element56
    {
        
        public Element56() : base(322)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_56";
            record.Id = 322;
            return record;
        } // method
    } // class

    public partial class Element57 : Block // 323 typeof=Element57
    {
        
        public Element57() : base(323)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_57";
            record.Id = 323;
            return record;
        } // method
    } // class

    public partial class Element58 : Block // 324 typeof=Element58
    {
        
        public Element58() : base(324)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_58";
            record.Id = 324;
            return record;
        } // method
    } // class

    public partial class Element59 : Block // 325 typeof=Element59
    {
        
        public Element59() : base(325)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_59";
            record.Id = 325;
            return record;
        } // method
    } // class

    public partial class Element6 : Block // 272 typeof=Element6
    {
        
        public Element6() : base(272)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_6";
            record.Id = 272;
            return record;
        } // method
    } // class

    public partial class Element60 : Block // 326 typeof=Element60
    {
        
        public Element60() : base(326)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_60";
            record.Id = 326;
            return record;
        } // method
    } // class

    public partial class Element61 : Block // 327 typeof=Element61
    {
        
        public Element61() : base(327)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_61";
            record.Id = 327;
            return record;
        } // method
    } // class

    public partial class Element62 : Block // 328 typeof=Element62
    {
        
        public Element62() : base(328)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_62";
            record.Id = 328;
            return record;
        } // method
    } // class

    public partial class Element63 : Block // 329 typeof=Element63
    {
        
        public Element63() : base(329)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_63";
            record.Id = 329;
            return record;
        } // method
    } // class

    public partial class Element64 : Block // 330 typeof=Element64
    {
        
        public Element64() : base(330)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_64";
            record.Id = 330;
            return record;
        } // method
    } // class

    public partial class Element65 : Block // 331 typeof=Element65
    {
        
        public Element65() : base(331)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_65";
            record.Id = 331;
            return record;
        } // method
    } // class

    public partial class Element66 : Block // 332 typeof=Element66
    {
        
        public Element66() : base(332)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_66";
            record.Id = 332;
            return record;
        } // method
    } // class

    public partial class Element67 : Block // 333 typeof=Element67
    {
        
        public Element67() : base(333)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_67";
            record.Id = 333;
            return record;
        } // method
    } // class

    public partial class Element68 : Block // 334 typeof=Element68
    {
        
        public Element68() : base(334)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_68";
            record.Id = 334;
            return record;
        } // method
    } // class

    public partial class Element69 : Block // 335 typeof=Element69
    {
        
        public Element69() : base(335)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_69";
            record.Id = 335;
            return record;
        } // method
    } // class

    public partial class Element7 : Block // 273 typeof=Element7
    {
        
        public Element7() : base(273)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_7";
            record.Id = 273;
            return record;
        } // method
    } // class

    public partial class Element70 : Block // 336 typeof=Element70
    {
        
        public Element70() : base(336)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_70";
            record.Id = 336;
            return record;
        } // method
    } // class

    public partial class Element71 : Block // 337 typeof=Element71
    {
        
        public Element71() : base(337)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_71";
            record.Id = 337;
            return record;
        } // method
    } // class

    public partial class Element72 : Block // 338 typeof=Element72
    {
        
        public Element72() : base(338)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_72";
            record.Id = 338;
            return record;
        } // method
    } // class

    public partial class Element73 : Block // 339 typeof=Element73
    {
        
        public Element73() : base(339)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_73";
            record.Id = 339;
            return record;
        } // method
    } // class

    public partial class Element74 : Block // 340 typeof=Element74
    {
        
        public Element74() : base(340)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_74";
            record.Id = 340;
            return record;
        } // method
    } // class

    public partial class Element75 : Block // 341 typeof=Element75
    {
        
        public Element75() : base(341)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_75";
            record.Id = 341;
            return record;
        } // method
    } // class

    public partial class Element76 : Block // 342 typeof=Element76
    {
        
        public Element76() : base(342)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_76";
            record.Id = 342;
            return record;
        } // method
    } // class

    public partial class Element77 : Block // 343 typeof=Element77
    {
        
        public Element77() : base(343)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_77";
            record.Id = 343;
            return record;
        } // method
    } // class

    public partial class Element78 : Block // 344 typeof=Element78
    {
        
        public Element78() : base(344)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_78";
            record.Id = 344;
            return record;
        } // method
    } // class

    public partial class Element79 : Block // 345 typeof=Element79
    {
        
        public Element79() : base(345)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_79";
            record.Id = 345;
            return record;
        } // method
    } // class

    public partial class Element8 : Block // 274 typeof=Element8
    {
        
        public Element8() : base(274)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_8";
            record.Id = 274;
            return record;
        } // method
    } // class

    public partial class Element80 : Block // 346 typeof=Element80
    {
        
        public Element80() : base(346)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_80";
            record.Id = 346;
            return record;
        } // method
    } // class

    public partial class Element81 : Block // 347 typeof=Element81
    {
        
        public Element81() : base(347)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_81";
            record.Id = 347;
            return record;
        } // method
    } // class

    public partial class Element82 : Block // 348 typeof=Element82
    {
        
        public Element82() : base(348)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_82";
            record.Id = 348;
            return record;
        } // method
    } // class

    public partial class Element83 : Block // 349 typeof=Element83
    {
        
        public Element83() : base(349)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_83";
            record.Id = 349;
            return record;
        } // method
    } // class

    public partial class Element84 : Block // 350 typeof=Element84
    {
        
        public Element84() : base(350)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_84";
            record.Id = 350;
            return record;
        } // method
    } // class

    public partial class Element85 : Block // 351 typeof=Element85
    {
        
        public Element85() : base(351)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_85";
            record.Id = 351;
            return record;
        } // method
    } // class

    public partial class Element86 : Block // 352 typeof=Element86
    {
        
        public Element86() : base(352)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_86";
            record.Id = 352;
            return record;
        } // method
    } // class

    public partial class Element87 : Block // 353 typeof=Element87
    {
        
        public Element87() : base(353)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_87";
            record.Id = 353;
            return record;
        } // method
    } // class

    public partial class Element88 : Block // 354 typeof=Element88
    {
        
        public Element88() : base(354)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_88";
            record.Id = 354;
            return record;
        } // method
    } // class

    public partial class Element89 : Block // 355 typeof=Element89
    {
        
        public Element89() : base(355)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_89";
            record.Id = 355;
            return record;
        } // method
    } // class

    public partial class Element9 : Block // 275 typeof=Element9
    {
        
        public Element9() : base(275)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_9";
            record.Id = 275;
            return record;
        } // method
    } // class

    public partial class Element90 : Block // 356 typeof=Element90
    {
        
        public Element90() : base(356)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_90";
            record.Id = 356;
            return record;
        } // method
    } // class

    public partial class Element91 : Block // 357 typeof=Element91
    {
        
        public Element91() : base(357)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_91";
            record.Id = 357;
            return record;
        } // method
    } // class

    public partial class Element92 : Block // 358 typeof=Element92
    {
        
        public Element92() : base(358)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_92";
            record.Id = 358;
            return record;
        } // method
    } // class

    public partial class Element93 : Block // 359 typeof=Element93
    {
        
        public Element93() : base(359)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_93";
            record.Id = 359;
            return record;
        } // method
    } // class

    public partial class Element94 : Block // 360 typeof=Element94
    {
        
        public Element94() : base(360)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_94";
            record.Id = 360;
            return record;
        } // method
    } // class

    public partial class Element95 : Block // 361 typeof=Element95
    {
        
        public Element95() : base(361)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_95";
            record.Id = 361;
            return record;
        } // method
    } // class

    public partial class Element96 : Block // 362 typeof=Element96
    {
        
        public Element96() : base(362)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_96";
            record.Id = 362;
            return record;
        } // method
    } // class

    public partial class Element97 : Block // 363 typeof=Element97
    {
        
        public Element97() : base(363)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_97";
            record.Id = 363;
            return record;
        } // method
    } // class

    public partial class Element98 : Block // 364 typeof=Element98
    {
        
        public Element98() : base(364)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_98";
            record.Id = 364;
            return record;
        } // method
    } // class

    public partial class Element99 : Block // 365 typeof=Element99
    {
        
        public Element99() : base(365)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:element_99";
            record.Id = 365;
            return record;
        } // method
    } // class

    public partial class EmeraldBlock  // 133 typeof=EmeraldBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:emerald_block";
            record.Id = 133;
            return record;
        } // method
    } // class

    public partial class EmeraldOre  // 129 typeof=EmeraldOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:emerald_ore";
            record.Id = 129;
            return record;
        } // method
    } // class

    public partial class EnchantingTable  // 116 typeof=EnchantingTable
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:enchanting_table";
            record.Id = 116;
            return record;
        } // method
    } // class

    public partial class EndBrickStairs  // 433 typeof=EndBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_brick_stairs";
            record.Id = 433;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class EndBricks  // 206 typeof=EndBricks
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_bricks";
            record.Id = 206;
            return record;
        } // method
    } // class

    public partial class EndGateway  // 209 typeof=EndGateway
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_gateway";
            record.Id = 209;
            return record;
        } // method
    } // class

    public partial class EndPortal  // 119 typeof=EndPortal
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_portal";
            record.Id = 119;
            return record;
        } // method
    } // class

    public partial class EndPortalFrame  // 120 typeof=EndPortalFrame
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool EndPortalEyeBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "end_portal_eye_bit":
                        EndPortalEyeBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_portal_frame";
            record.Id = 120;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "end_portal_eye_bit", Value = Convert.ToByte(EndPortalEyeBit)});
            return record;
        } // method
    } // class

    public partial class EndRod  // 208 typeof=EndRod
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_rod";
            record.Id = 208;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class EndStone  // 121 typeof=EndStone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:end_stone";
            record.Id = 121;
            return record;
        } // method
    } // class

    public partial class EnderChest  // 130 typeof=EnderChest
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ender_chest";
            record.Id = 130;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class ExposedCopper : Block // 0 typeof=Air
    {
        
        public ExposedCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:exposed_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ExposedCutCopper : Block // 0 typeof=Air
    {
        
        public ExposedCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:exposed_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ExposedCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public ExposedCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:exposed_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class ExposedCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public ExposedCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:exposed_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class ExposedDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public ExposedDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:exposed_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class Farmland  // 60 typeof=Farmland
    {
        [StateRange(0, 7)] public  int MoisturizedAmount { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "moisturized_amount":
                        MoisturizedAmount = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:farmland";
            record.Id = 60;
            record.States.Add(new BlockStateInt {Name = "moisturized_amount", Value = MoisturizedAmount});
            return record;
        } // method
    } // class

    public partial class FenceGate  // 107 typeof=FenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fence_gate";
            record.Id = 107;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class Fire  // 51 typeof=Fire
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fire";
            record.Id = 51;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class FletchingTable : Block // 456 typeof=FletchingTable
    {
        
        public FletchingTable() : base(456)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:fletching_table";
            record.Id = 456;
            return record;
        } // method
    } // class

    public partial class FlowerPot  // 140 typeof=FlowerPot
    {
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flower_pot";
            record.Id = 140;
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class FloweringAzalea : Block // 0 typeof=Air
    {
        
        public FloweringAzalea() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flowering_azalea";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class FlowingLava  // 10 typeof=FlowingLava
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flowing_lava";
            record.Id = 10;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class FlowingWater  // 8 typeof=FlowingWater
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:flowing_water";
            record.Id = 8;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class Frame // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool ItemFrameMapBit { get; set; } = false;
        [StateBit] public  bool ItemFramePhotoBit { get; set; } = false;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "item_frame_map_bit":
                        ItemFrameMapBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "item_frame_photo_bit":
                        ItemFramePhotoBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:frame";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "item_frame_map_bit", Value = Convert.ToByte(ItemFrameMapBit)});
            record.States.Add(new BlockStateByte {Name = "item_frame_photo_bit", Value = Convert.ToByte(ItemFramePhotoBit)});
            return record;
        } // method
    } // class

    public partial class FrogSpawn : Block // 0 typeof=Air
    {
        
        public FrogSpawn() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:frog_spawn";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class FrostedIce  // 207 typeof=FrostedIce
    {
        [StateRange(0, 3)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:frosted_ice";
            record.Id = 207;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class Furnace  // 61 typeof=Furnace
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:furnace";
            record.Id = 61;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class GildedBlackstone : Block // 0 typeof=Air
    {
        
        public GildedBlackstone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gilded_blackstone";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Glass  // 20 typeof=Glass
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glass";
            record.Id = 20;
            return record;
        } // method
    } // class

    public partial class GlassPane  // 102 typeof=GlassPane
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glass_pane";
            record.Id = 102;
            return record;
        } // method
    } // class

    public partial class GlowFrame : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool ItemFrameMapBit { get; set; } = false;
        [StateBit] public  bool ItemFramePhotoBit { get; set; } = false;
        
        public GlowFrame() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "item_frame_map_bit":
                        ItemFrameMapBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "item_frame_photo_bit":
                        ItemFramePhotoBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glow_frame";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "item_frame_map_bit", Value = Convert.ToByte(ItemFrameMapBit)});
            record.States.Add(new BlockStateByte {Name = "item_frame_photo_bit", Value = Convert.ToByte(ItemFramePhotoBit)});
            return record;
        } // method
    } // class

    public partial class GlowLichen : Block // 0 typeof=Air
    {
        [StateRange(0, 63)] public  int MultiFaceDirectionBits { get; set; } = 0;
        
        public GlowLichen() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "multi_face_direction_bits":
                        MultiFaceDirectionBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glow_lichen";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "multi_face_direction_bits", Value = MultiFaceDirectionBits});
            return record;
        } // method
    } // class

    public partial class Glowingobsidian  // 246 typeof=Glowingobsidian
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glowingobsidian";
            record.Id = 246;
            return record;
        } // method
    } // class

    public partial class Glowstone  // 89 typeof=Glowstone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:glowstone";
            record.Id = 89;
            return record;
        } // method
    } // class

    public partial class GoldBlock  // 41 typeof=GoldBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gold_block";
            record.Id = 41;
            return record;
        } // method
    } // class

    public partial class GoldOre  // 14 typeof=GoldOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gold_ore";
            record.Id = 14;
            return record;
        } // method
    } // class

    public partial class GoldenRail  // 27 typeof=GoldenRail
    {
        [StateBit] public  bool RailDataBit { get; set; } = false;
        [StateRange(0, 5)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "rail_data_bit":
                        RailDataBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:golden_rail";
            record.Id = 27;
            record.States.Add(new BlockStateByte {Name = "rail_data_bit", Value = Convert.ToByte(RailDataBit)});
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class GraniteStairs  // 424 typeof=GraniteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:granite_stairs";
            record.Id = 424;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Grass  // 2 typeof=Grass
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grass";
            record.Id = 2;
            return record;
        } // method
    } // class

    public partial class GrassPath  // 198 typeof=GrassPath
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grass_path";
            record.Id = 198;
            return record;
        } // method
    } // class

    public partial class Gravel  // 13 typeof=Gravel
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gravel";
            record.Id = 13;
            return record;
        } // method
    } // class

    public partial class GrayCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public GrayCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gray_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class GrayCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public GrayCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gray_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class GrayGlazedTerracotta  // 227 typeof=GrayGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gray_glazed_terracotta";
            record.Id = 227;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class GrayWool : Block // 35 typeof=Wool
    {
        
        public GrayWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:gray_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class GreenCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public GreenCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:green_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class GreenCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public GreenCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:green_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class GreenGlazedTerracotta  // 233 typeof=GreenGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:green_glazed_terracotta";
            record.Id = 233;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class GreenWool : Block // 35 typeof=Wool
    {
        
        public GreenWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:green_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class Grindstone : Block // 450 typeof=Grindstone
    {
        [StateEnum("standing","hanging","side","multiple")]
        public  string Attachment { get; set; } = "standing";
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        
        public Grindstone() : base(450)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "attachment":
                        Attachment = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:grindstone";
            record.Id = 450;
            record.States.Add(new BlockStateString {Name = "attachment", Value = Attachment});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class HangingRoots : Block // 0 typeof=Air
    {
        
        public HangingRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hanging_roots";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class HardGlass : Block // 253 typeof=HardGlass
    {
        
        public HardGlass() : base(253)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_glass";
            record.Id = 253;
            return record;
        } // method
    } // class

    public partial class HardGlassPane : Block // 190 typeof=HardGlassPane
    {
        
        public HardGlassPane() : base(190)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_glass_pane";
            record.Id = 190;
            return record;
        } // method
    } // class

    public partial class HardStainedGlass : Block // 254 typeof=HardStainedGlass
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";
        
        public HardStainedGlass() : base(254)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_stained_glass";
            record.Id = 254;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class HardStainedGlassPane : Block // 191 typeof=HardStainedGlassPane
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";
        
        public HardStainedGlassPane() : base(191)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hard_stained_glass_pane";
            record.Id = 191;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class HardenedClay  // 172 typeof=HardenedClay
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hardened_clay";
            record.Id = 172;
            return record;
        } // method
    } // class

    public partial class HayBlock  // 170 typeof=HayBlock
    {
        [StateRange(0, 3)] public  int Deprecated { get; set; } = 0;
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "deprecated":
                        Deprecated = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hay_block";
            record.Id = 170;
            record.States.Add(new BlockStateInt {Name = "deprecated", Value = Deprecated});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class HeavyWeightedPressurePlate  // 148 typeof=HeavyWeightedPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:heavy_weighted_pressure_plate";
            record.Id = 148;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class HoneyBlock : Block // 0 typeof=Air
    {
        
        public HoneyBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:honey_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class HoneycombBlock : Block // 0 typeof=Air
    {
        
        public HoneycombBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:honeycomb_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Hopper  // 154 typeof=Hopper
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool ToggleBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "toggle_bit":
                        ToggleBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:hopper";
            record.Id = 154;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "toggle_bit", Value = Convert.ToByte(ToggleBit)});
            return record;
        } // method
    } // class

    public partial class Ice  // 79 typeof=Ice
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ice";
            record.Id = 79;
            return record;
        } // method
    } // class

    public partial class InfestedDeepslate : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public InfestedDeepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:infested_deepslate";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class InfoUpdate : Block // 248 typeof=InfoUpdate
    {
        
        public InfoUpdate() : base(248)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:info_update";
            record.Id = 248;
            return record;
        } // method
    } // class

    public partial class InfoUpdate2 : Block // 249 typeof=InfoUpdate2
    {
        
        public InfoUpdate2() : base(249)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:info_update2";
            record.Id = 249;
            return record;
        } // method
    } // class

    public partial class InvisibleBedrock // 95 typeof=InvisibleBedrock
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:invisible_bedrock";
            record.Id = 95;
            return record;
        } // method
    } // class

    public partial class IronBars  // 101 typeof=IronBars
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_bars";
            record.Id = 101;
            return record;
        } // method
    } // class

    public partial class IronBlock  // 42 typeof=IronBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_block";
            record.Id = 42;
            return record;
        } // method
    } // class

    public partial class IronDoor  // 71 typeof=IronDoor
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_door";
            record.Id = 71;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class IronOre  // 15 typeof=IronOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_ore";
            record.Id = 15;
            return record;
        } // method
    } // class

    public partial class IronTrapdoor  // 167 typeof=IronTrapdoor
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:iron_trapdoor";
            record.Id = 167;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class Jigsaw : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 3)] public  int Rotation { get; set; } = 1;
        
        public Jigsaw() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "rotation":
                        Rotation = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jigsaw";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "rotation", Value = Rotation});
            return record;
        } // method
    } // class

    public partial class Jukebox  // 84 typeof=Jukebox
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jukebox";
            record.Id = 84;
            return record;
        } // method
    } // class

    public partial class JungleButton  // 398 typeof=JungleButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_button";
            record.Id = 398;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class JungleDoor  // 195 typeof=JungleDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_door";
            record.Id = 195;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class JungleFence : Block // 85 typeof=Fence
    {
        
        public JungleFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class JungleFenceGate  // 185 typeof=JungleFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_fence_gate";
            record.Id = 185;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class JungleHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public JungleHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class JungleLog : LogBase // 17 typeof=Log
	{
        public JungleLog() : base(17)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_log";
            record.Id = 17;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class JunglePressurePlate : Block // 408 typeof=JunglePressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public JunglePressurePlate() : base(408)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_pressure_plate";
            record.Id = 408;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class JungleStairs  // 136 typeof=JungleStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_stairs";
            record.Id = 136;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class JungleStandingSign  // 443 typeof=JungleStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_standing_sign";
            record.Id = 443;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class JungleTrapdoor  // 403 typeof=JungleTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_trapdoor";
            record.Id = 403;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class JungleWallSign  // 444 typeof=JungleWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:jungle_wall_sign";
            record.Id = 444;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Kelp : Block // 393 typeof=Kelp
    {
        [StateRange(0, 25)] public  int KelpAge { get; set; } = 0;
        
        public Kelp() : base(393)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "kelp_age":
                        KelpAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:kelp";
            record.Id = 393;
            record.States.Add(new BlockStateInt {Name = "kelp_age", Value = KelpAge});
            return record;
        } // method
    } // class

    public partial class Ladder  // 65 typeof=Ladder
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ladder";
            record.Id = 65;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Lantern : Block // 463 typeof=Lantern
    {
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public Lantern() : base(463)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lantern";
            record.Id = 463;
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class LapisBlock  // 22 typeof=LapisBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lapis_block";
            record.Id = 22;
            return record;
        } // method
    } // class

    public partial class LapisOre  // 21 typeof=LapisOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lapis_ore";
            record.Id = 21;
            return record;
        } // method
    } // class

    public partial class LargeAmethystBud : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public LargeAmethystBud() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:large_amethyst_bud";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Lava  // 11 typeof=Lava
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lava";
            record.Id = 11;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class LavaCauldron : Block // 465 typeof=LavaCauldron
    {
        [StateEnum("water","powder_snow","lava")]
        public  string CauldronLiquid { get; set; } = "water";
        [StateRange(0, 6)] public  int FillLevel { get; set; } = 0;
        
        public LavaCauldron() : base(465)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "cauldron_liquid":
                        CauldronLiquid = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "fill_level":
                        FillLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lava_cauldron";
            record.Id = 465;
            record.States.Add(new BlockStateString {Name = "cauldron_liquid", Value = CauldronLiquid});
            record.States.Add(new BlockStateInt {Name = "fill_level", Value = FillLevel});
            return record;
        } // method
    } // class

    public partial class Leaves  // 18 typeof=Leaves
    {
        [StateEnum("oak","spruce","birch","jungle")]
        public  string OldLeafType { get; set; } = "oak";
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "old_leaf_type":
                        OldLeafType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:leaves";
            record.Id = 18;
            record.States.Add(new BlockStateString {Name = "old_leaf_type", Value = OldLeafType});
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class Leaves2  // 161 typeof=Leaves2
    {
        [StateEnum("dark_oak","acacia")]
        public  string NewLeafType { get; set; } = "";
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "new_leaf_type":
                        NewLeafType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:leaves2";
            record.Id = 161;
            record.States.Add(new BlockStateString {Name = "new_leaf_type", Value = NewLeafType});
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class Lectern : Block // 449 typeof=Lectern
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool PoweredBit { get; set; } = false;
        
        public Lectern() : base(449)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lectern";
            record.Id = 449;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Lever  // 69 typeof=Lever
    {
        [StateEnum("down_east_west","east","west","south","north","up_north_south","up_east_west","down_north_south")]
        public  string LeverDirection { get; set; } = "down_east_west";
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "lever_direction":
                        LeverDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lever";
            record.Id = 69;
            record.States.Add(new BlockStateString {Name = "lever_direction", Value = LeverDirection});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class LightBlock : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int BlockLightLevel { get; set; } = 0;
        
        public LightBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "block_light_level":
                        BlockLightLevel = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_block";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "block_light_level", Value = BlockLightLevel});
            return record;
        } // method
    } // class

    public partial class LightBlueCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LightBlueCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_blue_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LightBlueCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LightBlueCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_blue_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LightBlueGlazedTerracotta  // 223 typeof=LightBlueGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_blue_glazed_terracotta";
            record.Id = 223;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LightBlueWool : Block // 35 typeof=Wool
    {
        
        public LightBlueWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_blue_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class LightGrayCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LightGrayCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_gray_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LightGrayCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LightGrayCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_gray_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LightGrayWool : Block // 35 typeof=Wool
    {
        
        public LightGrayWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_gray_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class LightWeightedPressurePlate  // 147 typeof=LightWeightedPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:light_weighted_pressure_plate";
            record.Id = 147;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class LightningRod : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public LightningRod() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lightning_rod";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LimeCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LimeCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lime_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LimeCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public LimeCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lime_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class LimeGlazedTerracotta  // 225 typeof=LimeGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lime_glazed_terracotta";
            record.Id = 225;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LimeWool : Block // 35 typeof=Wool
    {
        
        public LimeWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lime_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class LitBlastFurnace  // 469 typeof=LitBlastFurnace
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_blast_furnace";
            record.Id = 469;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LitDeepslateRedstoneOre : Block // 0 typeof=Air
    {
        
        public LitDeepslateRedstoneOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_deepslate_redstone_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class LitFurnace  // 62 typeof=LitFurnace
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_furnace";
            record.Id = 62;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class LitPumpkin  // 91 typeof=LitPumpkin
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_pumpkin";
            record.Id = 91;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class LitRedstoneLamp  // 124 typeof=LitRedstoneLamp
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_redstone_lamp";
            record.Id = 124;
            return record;
        } // method
    } // class

    public partial class LitRedstoneOre  // 74 typeof=LitRedstoneOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_redstone_ore";
            record.Id = 74;
            return record;
        } // method
    } // class

    public partial class LitSmoker : Block // 454 typeof=LitSmoker
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public LitSmoker() : base(454)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lit_smoker";
            record.Id = 454;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Lodestone : Block // 0 typeof=Air
    {
        
        public Lodestone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:lodestone";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Loom  // 459 typeof=Loom
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:loom";
            record.Id = 459;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class MagentaCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public MagentaCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magenta_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class MagentaCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public MagentaCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magenta_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class MagentaGlazedTerracotta  // 222 typeof=MagentaGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magenta_glazed_terracotta";
            record.Id = 222;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class MagentaWool : Block // 35 typeof=Wool
    {
        
        public MagentaWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magenta_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class Magma : Block // 213 typeof=Magma
    {
        
        public Magma() : base(213)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:magma";
            record.Id = 213;
            return record;
        } // method
    } // class

    public partial class MangroveButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public MangroveButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class MangroveDoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public MangroveDoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_door";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class MangroveDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public MangroveDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class MangroveFence : Block // 0 typeof=Air
    {
        
        public MangroveFence() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_fence";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MangroveFenceGate : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public MangroveFenceGate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_fence_gate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class MangroveHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public MangroveHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class MangroveLeaves : Block // 0 typeof=Air
    {
        [StateBit] public  bool PersistentBit { get; set; } = false;
        [StateBit] public  bool UpdateBit { get; set; } = false;
        
        public MangroveLeaves() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "persistent_bit":
                        PersistentBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "update_bit":
                        UpdateBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_leaves";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "persistent_bit", Value = Convert.ToByte(PersistentBit)});
            record.States.Add(new BlockStateByte {Name = "update_bit", Value = Convert.ToByte(UpdateBit)});
            return record;
        } // method
    } // class

    public partial class MangroveLog : LogBase // 0 typeof=Air
	{
        public MangroveLog() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_log";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class MangrovePlanks : Block // 0 typeof=Air
    {
        
        public MangrovePlanks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_planks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MangrovePressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public MangrovePressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class MangrovePropagule : Block // 0 typeof=Air
    {
        [StateBit] public  bool Hanging { get; set; } = false;
        [StateRange(0, 4)] public  int PropaguleStage { get; set; } = 0;
        
        public MangrovePropagule() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "propagule_stage":
                        PropaguleStage = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_propagule";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            record.States.Add(new BlockStateInt {Name = "propagule_stage", Value = PropaguleStage});
            return record;
        } // method
    } // class

    public partial class MangroveRoots : Block // 0 typeof=Air
    {
        
        public MangroveRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_roots";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MangroveSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public MangroveSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class MangroveStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public MangroveStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MangroveStandingSign : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        
        public MangroveStandingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_standing_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class MangroveTrapdoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        
        public MangroveTrapdoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_trapdoor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class MangroveWallSign : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public MangroveWallSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_wall_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class MangroveWood : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        [StateBit] public  bool StrippedBit { get; set; } = false;
        
        public MangroveWood() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "stripped_bit":
                        StrippedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mangrove_wood";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            record.States.Add(new BlockStateByte {Name = "stripped_bit", Value = Convert.ToByte(StrippedBit)});
            return record;
        } // method
    } // class

    public partial class MediumAmethystBud : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public MediumAmethystBud() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:medium_amethyst_bud";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class MelonBlock  // 103 typeof=MelonBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:melon_block";
            record.Id = 103;
            return record;
        } // method
    } // class

    public partial class MelonStem  // 105 typeof=MelonStem
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:melon_stem";
            record.Id = 105;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class MobSpawner  // 52 typeof=MobSpawner
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mob_spawner";
            record.Id = 52;
            return record;
        } // method
    } // class

    public partial class MonsterEgg  // 97 typeof=MonsterEgg
    {
        [StateEnum("cobblestone","stone_brick","mossy_stone_brick","cracked_stone_brick","chiseled_stone_brick","stone")]
        public  string MonsterEggStoneType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "monster_egg_stone_type":
                        MonsterEggStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:monster_egg";
            record.Id = 97;
            record.States.Add(new BlockStateString {Name = "monster_egg_stone_type", Value = MonsterEggStoneType});
            return record;
        } // method
    } // class

    public partial class MossBlock : Block // 0 typeof=Air
    {
        
        public MossBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:moss_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MossCarpet : Block // 0 typeof=Air
    {
        
        public MossCarpet() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:moss_carpet";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MossyCobblestone  // 48 typeof=MossyCobblestone
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_cobblestone";
            record.Id = 48;
            return record;
        } // method
    } // class

    public partial class MossyCobblestoneStairs  // 434 typeof=MossyCobblestoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_cobblestone_stairs";
            record.Id = 434;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MossyStoneBrickStairs  // 430 typeof=MossyStoneBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mossy_stone_brick_stairs";
            record.Id = 430;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MovingBlock : Block // 250 typeof=MovingBlock
    {
        
        public MovingBlock() : base(250)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:moving_block";
            record.Id = 250;
            return record;
        } // method
    } // class

    public partial class Mud : Block // 0 typeof=Air
    {
        
        public Mud() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MudBrickDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public MudBrickDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud_brick_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class MudBrickSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public MudBrickSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud_brick_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class MudBrickStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public MudBrickStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud_brick_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class MudBrickWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public MudBrickWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud_brick_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class MudBricks : Block // 0 typeof=Air
    {
        
        public MudBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mud_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class MuddyMangroveRoots : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public MuddyMangroveRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:muddy_mangrove_roots";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class Mycelium  // 110 typeof=Mycelium
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:mycelium";
            record.Id = 110;
            return record;
        } // method
    } // class

    public partial class NetherBrick  // 112 typeof=NetherBrick
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick";
            record.Id = 112;
            return record;
        } // method
    } // class

    public partial class NetherBrickFence  // 113 typeof=NetherBrickFence
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick_fence";
            record.Id = 113;
            return record;
        } // method
    } // class

    public partial class NetherBrickStairs  // 114 typeof=NetherBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_brick_stairs";
            record.Id = 114;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class NetherGoldOre : Block // 0 typeof=Air
    {
        
        public NetherGoldOre() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_gold_ore";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class NetherSprouts : Block // 0 typeof=Air
    {
        
        public NetherSprouts() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_sprouts";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class NetherWart  // 115 typeof=NetherWart
    {
        [StateRange(0, 3)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_wart";
            record.Id = 115;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class NetherWartBlock : Block // 214 typeof=NetherWartBlock
    {
        
        public NetherWartBlock() : base(214)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:nether_wart_block";
            record.Id = 214;
            return record;
        } // method
    } // class

    public partial class NetheriteBlock : Block // 0 typeof=Air
    {
        
        public NetheriteBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:netherite_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Netherrack  // 87 typeof=Netherrack
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:netherrack";
            record.Id = 87;
            return record;
        } // method
    } // class

    public partial class Netherreactor  // 247 typeof=Netherreactor
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:netherreactor";
            record.Id = 247;
            return record;
        } // method
    } // class

    public partial class NormalStoneStairs  // 435 typeof=NormalStoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:normal_stone_stairs";
            record.Id = 435;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Noteblock  // 25 typeof=Noteblock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:noteblock";
            record.Id = 25;
            return record;
        } // method
    } // class

    public partial class OakFence : Block // 85 typeof=Fence
    {
        
        public OakFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oak_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class OakHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public OakHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oak_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class OakLog : LogBase // 17 typeof=Log
	{
        public OakLog() : base(17)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oak_log";
            record.Id = 17;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class OakStairs  // 53 typeof=OakStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oak_stairs";
            record.Id = 53;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Observer  // 251 typeof=Observer
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateBit] public  bool PoweredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:observer";
            record.Id = 251;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Obsidian  // 49 typeof=Obsidian
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:obsidian";
            record.Id = 49;
            return record;
        } // method
    } // class

    public partial class OchreFroglight : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public OchreFroglight() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:ochre_froglight";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class OrangeCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public OrangeCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:orange_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class OrangeCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public OrangeCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:orange_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class OrangeGlazedTerracotta  // 221 typeof=OrangeGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:orange_glazed_terracotta";
            record.Id = 221;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class OrangeWool : Block // 35 typeof=Wool
    {
        
        public OrangeWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:orange_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class OxidizedCopper : Block // 0 typeof=Air
    {
        
        public OxidizedCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oxidized_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class OxidizedCutCopper : Block // 0 typeof=Air
    {
        
        public OxidizedCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oxidized_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class OxidizedCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public OxidizedCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oxidized_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class OxidizedCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public OxidizedCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oxidized_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class OxidizedDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public OxidizedDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:oxidized_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PackedIce  // 174 typeof=PackedIce
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:packed_ice";
            record.Id = 174;
            return record;
        } // method
    } // class

    public partial class PackedMud : Block // 0 typeof=Air
    {
        
        public PackedMud() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:packed_mud";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class PearlescentFroglight : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public PearlescentFroglight() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pearlescent_froglight";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class PinkCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public PinkCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class PinkCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public PinkCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class PinkGlazedTerracotta  // 226 typeof=PinkGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_glazed_terracotta";
            record.Id = 226;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PinkPetals : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;
        
        public PinkPetals() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_petals";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class PinkWool : Block // 35 typeof=Wool
    {
        
        public PinkWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pink_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class Piston  // 33 typeof=Piston
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:piston";
            record.Id = 33;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PistonArmCollision // 34 typeof=PistonArmCollision
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:piston_arm_collision";
            record.Id = 34;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Planks  // 5 typeof=Planks
    {
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string WoodType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:planks";
            record.Id = 5;
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class Podzol  // 243 typeof=Podzol
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:podzol";
            record.Id = 243;
            return record;
        } // method
    } // class

    public partial class PointedDripstone : Block // 0 typeof=Air
    {
        [StateEnum("tip","frustum","middle","base","merge")]
        public  string DripstoneThickness { get; set; } = "tip";
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public PointedDripstone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "dripstone_thickness":
                        DripstoneThickness = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pointed_dripstone";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "dripstone_thickness", Value = DripstoneThickness});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class PolishedAndesiteStairs  // 429 typeof=PolishedAndesiteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_andesite_stairs";
            record.Id = 429;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedBasalt : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public PolishedBasalt() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_basalt";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstone : Block // 0 typeof=Air
    {
        
        public PolishedBlackstone() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneBrickDoubleSlab // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_brick_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneBrickSlab // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_brick_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneBrickStairs // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_brick_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneBrickWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public PolishedBlackstoneBrickWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_brick_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneBricks : Block // 0 typeof=Air
    {
        
        public PolishedBlackstoneBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public PolishedBlackstoneButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneDoubleSlab // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstonePressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public PolishedBlackstonePressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneSlab // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneStairs // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedBlackstoneWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public PolishedBlackstoneWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_blackstone_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class PolishedDeepslate : Block // 0 typeof=Air
    {
        
        public PolishedDeepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_deepslate";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class PolishedDeepslateDoubleSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public PolishedDeepslateDoubleSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_deepslate_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedDeepslateSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public PolishedDeepslateSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_deepslate_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class PolishedDeepslateStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public PolishedDeepslateStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_deepslate_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedDeepslateWall : Block // 0 typeof=Air
    {
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeEast { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeNorth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeSouth { get; set; } = "none";
        [StateEnum("none","short","tall")]
        public  string WallConnectionTypeWest { get; set; } = "none";
        [StateBit] public  bool WallPostBit { get; set; } = false;
        
        public PolishedDeepslateWall() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "wall_connection_type_east":
                        WallConnectionTypeEast = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_north":
                        WallConnectionTypeNorth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_south":
                        WallConnectionTypeSouth = s.Value;
                        break;
                    case BlockStateString s when s.Name == "wall_connection_type_west":
                        WallConnectionTypeWest = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "wall_post_bit":
                        WallPostBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_deepslate_wall";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "wall_connection_type_east", Value = WallConnectionTypeEast});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_north", Value = WallConnectionTypeNorth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_south", Value = WallConnectionTypeSouth});
            record.States.Add(new BlockStateString {Name = "wall_connection_type_west", Value = WallConnectionTypeWest});
            record.States.Add(new BlockStateByte {Name = "wall_post_bit", Value = Convert.ToByte(WallPostBit)});
            return record;
        } // method
    } // class

    public partial class PolishedDioriteStairs  // 428 typeof=PolishedDioriteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_diorite_stairs";
            record.Id = 428;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PolishedGraniteStairs  // 427 typeof=PolishedGraniteStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:polished_granite_stairs";
            record.Id = 427;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Portal  // 90 typeof=Portal
    {
        [StateEnum("x","z","unknown")]
        public  string PortalAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "portal_axis":
                        PortalAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:portal";
            record.Id = 90;
            record.States.Add(new BlockStateString {Name = "portal_axis", Value = PortalAxis});
            return record;
        } // method
    } // class

    public partial class Potatoes  // 142 typeof=Potatoes
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:potatoes";
            record.Id = 142;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class PowderSnow : Block // 0 typeof=Air
    {
        
        public PowderSnow() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:powder_snow";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class PoweredComparator  // 150 typeof=PoweredComparator
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OutputLitBit { get; set; } = false;
        [StateBit] public  bool OutputSubtractBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "output_lit_bit":
                        OutputLitBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "output_subtract_bit":
                        OutputSubtractBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:powered_comparator";
            record.Id = 150;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "output_lit_bit", Value = Convert.ToByte(OutputLitBit)});
            record.States.Add(new BlockStateByte {Name = "output_subtract_bit", Value = Convert.ToByte(OutputSubtractBit)});
            return record;
        } // method
    } // class

    public partial class PoweredRepeater  // 94 typeof=PoweredRepeater
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 3)] public  int RepeaterDelay { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "repeater_delay":
                        RepeaterDelay = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:powered_repeater";
            record.Id = 94;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "repeater_delay", Value = RepeaterDelay});
            return record;
        } // method
    } // class

    public partial class Prismarine  // 168 typeof=Prismarine
    {
        [StateEnum("dark","bricks","default")]
        public  string PrismarineBlockType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "prismarine_block_type":
                        PrismarineBlockType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine";
            record.Id = 168;
            record.States.Add(new BlockStateString {Name = "prismarine_block_type", Value = PrismarineBlockType});
            return record;
        } // method
    } // class

    public partial class PrismarineBricksStairs  // 259 typeof=PrismarineBricksStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine_bricks_stairs";
            record.Id = 259;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class PrismarineStairs  // 257 typeof=PrismarineStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:prismarine_stairs";
            record.Id = 257;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Pumpkin  // 86 typeof=Pumpkin
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pumpkin";
            record.Id = 86;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            return record;
        } // method
    } // class

    public partial class PumpkinStem  // 104 typeof=PumpkinStem
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:pumpkin_stem";
            record.Id = 104;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class PurpleCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public PurpleCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purple_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class PurpleCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public PurpleCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purple_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class PurpleGlazedTerracotta  // 219 typeof=PurpleGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purple_glazed_terracotta";
            record.Id = 219;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class PurpleWool : Block // 35 typeof=Wool
    {
        
        public PurpleWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purple_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class PurpurBlock  // 201 typeof=PurpurBlock
    {
        [StateEnum("default","chiseled","lines","smooth")]
        public  string ChiselType { get; set; } = "";
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chisel_type":
                        ChiselType = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purpur_block";
            record.Id = 201;
            record.States.Add(new BlockStateString {Name = "chisel_type", Value = ChiselType});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class PurpurStairs  // 203 typeof=PurpurStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:purpur_stairs";
            record.Id = 203;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class QuartzBlock  // 155 typeof=QuartzBlock
    {
        [StateEnum("default","chiseled","lines","smooth")]
        public  string ChiselType { get; set; } = "";
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "chisel_type":
                        ChiselType = s.Value;
                        break;
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_block";
            record.Id = 155;
            record.States.Add(new BlockStateString {Name = "chisel_type", Value = ChiselType});
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class QuartzBricks : Block // 0 typeof=Air
    {
        
        public QuartzBricks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_bricks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class QuartzOre  // 153 typeof=QuartzOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_ore";
            record.Id = 153;
            return record;
        } // method
    } // class

    public partial class QuartzStairs  // 156 typeof=QuartzStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:quartz_stairs";
            record.Id = 156;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Rail  // 66 typeof=Rail
    {
        [StateRange(0, 9)] public  int RailDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "rail_direction":
                        RailDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:rail";
            record.Id = 66;
            record.States.Add(new BlockStateInt {Name = "rail_direction", Value = RailDirection});
            return record;
        } // method
    } // class

    public partial class RawCopperBlock : Block // 0 typeof=Air
    {
        
        public RawCopperBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:raw_copper_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class RawGoldBlock : Block // 0 typeof=Air
    {
        
        public RawGoldBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:raw_gold_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class RawIronBlock : Block // 0 typeof=Air
    {
        
        public RawIronBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:raw_iron_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class RedCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public RedCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class RedCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public RedCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class RedFlower  // 38 typeof=RedFlower
    {
        [StateEnum("orchid","allium","houstonia","tulip_red","tulip_orange","tulip_white","tulip_pink","oxeye","cornflower","lily_of_the_valley","poppy")]
        public  string FlowerType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "flower_type":
                        FlowerType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_flower";
            record.Id = 38;
            record.States.Add(new BlockStateString {Name = "flower_type", Value = FlowerType});
            return record;
        } // method
    } // class

    public partial class RedGlazedTerracotta  // 234 typeof=RedGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_glazed_terracotta";
            record.Id = 234;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class RedMushroom  // 40 typeof=RedMushroom
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_mushroom";
            record.Id = 40;
            return record;
        } // method
    } // class

    public partial class RedMushroomBlock  // 100 typeof=RedMushroomBlock
    {
        [StateRange(0, 15)] public  int HugeMushroomBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "huge_mushroom_bits":
                        HugeMushroomBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_mushroom_block";
            record.Id = 100;
            record.States.Add(new BlockStateInt {Name = "huge_mushroom_bits", Value = HugeMushroomBits});
            return record;
        } // method
    } // class

    public partial class RedNetherBrick : Block // 215 typeof=RedNetherBrick
    {
        
        public RedNetherBrick() : base(215)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_nether_brick";
            record.Id = 215;
            return record;
        } // method
    } // class

    public partial class RedNetherBrickStairs  // 439 typeof=RedNetherBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_nether_brick_stairs";
            record.Id = 439;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class RedSandstone  // 179 typeof=RedSandstone
    {
        [StateEnum("default","heiroglyphs","cut","smooth")]
        public  string SandStoneType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_stone_type":
                        SandStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_sandstone";
            record.Id = 179;
            record.States.Add(new BlockStateString {Name = "sand_stone_type", Value = SandStoneType});
            return record;
        } // method
    } // class

    public partial class RedSandstoneStairs  // 180 typeof=RedSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_sandstone_stairs";
            record.Id = 180;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class RedWool : Block // 35 typeof=Wool
    {
        
        public RedWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:red_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class RedstoneBlock  // 152 typeof=RedstoneBlock
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_block";
            record.Id = 152;
            return record;
        } // method
    } // class

    public partial class RedstoneLamp  // 123 typeof=RedstoneLamp
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_lamp";
            record.Id = 123;
            return record;
        } // method
    } // class

    public partial class RedstoneOre  // 73 typeof=RedstoneOre
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_ore";
            record.Id = 73;
            return record;
        } // method
    } // class

    public partial class RedstoneTorch  // 76 typeof=RedstoneTorch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public override string TorchFacingDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_torch";
            record.Id = 76;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class RedstoneWire  // 55 typeof=RedstoneWire
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:redstone_wire";
            record.Id = 55;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class Reeds  // 83 typeof=Reeds
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:reeds";
            record.Id = 83;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class ReinforcedDeepslate : Block // 0 typeof=Air
    {
        
        public ReinforcedDeepslate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:reinforced_deepslate";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class RepeatingCommandBlock : Block // 188 typeof=RepeatingCommandBlock
    {
        [StateBit] public  bool ConditionalBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public RepeatingCommandBlock() : base(188)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "conditional_bit":
                        ConditionalBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:repeating_command_block";
            record.Id = 188;
            record.States.Add(new BlockStateByte {Name = "conditional_bit", Value = Convert.ToByte(ConditionalBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Reserved6 : Block // 255 typeof=Reserved6
    {
        
        public Reserved6() : base(255)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:reserved6";
            record.Id = 255;
            return record;
        } // method
    } // class

    public partial class RespawnAnchor : Block // 0 typeof=Air
    {
        [StateRange(0, 4)] public  int RespawnAnchorCharge { get; set; } = 0;
        
        public RespawnAnchor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "respawn_anchor_charge":
                        RespawnAnchorCharge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:respawn_anchor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "respawn_anchor_charge", Value = RespawnAnchorCharge});
            return record;
        } // method
    } // class

    public partial class Sand  // 12 typeof=Sand
    {
        [StateEnum("normal","red")]
        public  string SandType { get; set; } = "normal";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_type":
                        SandType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sand";
            record.Id = 12;
            record.States.Add(new BlockStateString {Name = "sand_type", Value = SandType});
            return record;
        } // method
    } // class

    public partial class Sandstone  // 24 typeof=Sandstone
    {
        [StateEnum("default","heiroglyphs","cut","smooth")]
        public  string SandStoneType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sand_stone_type":
                        SandStoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sandstone";
            record.Id = 24;
            record.States.Add(new BlockStateString {Name = "sand_stone_type", Value = SandStoneType});
            return record;
        } // method
    } // class

    public partial class SandstoneStairs  // 128 typeof=SandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sandstone_stairs";
            record.Id = 128;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Sapling  // 6 typeof=Sapling
    {
        [StateBit] public  bool AgeBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string SaplingType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "age_bit":
                        AgeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "sapling_type":
                        SaplingType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sapling";
            record.Id = 6;
            record.States.Add(new BlockStateByte {Name = "age_bit", Value = Convert.ToByte(AgeBit)});
            record.States.Add(new BlockStateString {Name = "sapling_type", Value = SaplingType});
            return record;
        } // method
    } // class

    public partial class Scaffolding : Block // 420 typeof=Scaffolding
    {
        [StateRange(0, 7)] public  int Stability { get; set; } = 0;
        [StateBit] public  bool StabilityCheck { get; set; } = false;
        
        public Scaffolding() : base(420)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "stability":
                        Stability = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "stability_check":
                        StabilityCheck = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:scaffolding";
            record.Id = 420;
            record.States.Add(new BlockStateInt {Name = "stability", Value = Stability});
            record.States.Add(new BlockStateByte {Name = "stability_check", Value = Convert.ToByte(StabilityCheck)});
            return record;
        } // method
    } // class

    public partial class Sculk : Block // 0 typeof=Air
    {
        
        public Sculk() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sculk";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class SculkCatalyst : Block // 0 typeof=Air
    {
        [StateBit] public  bool Bloom { get; set; } = false;
        
        public SculkCatalyst() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "bloom":
                        Bloom = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sculk_catalyst";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "bloom", Value = Convert.ToByte(Bloom)});
            return record;
        } // method
    } // class

    public partial class SculkSensor : Block // 0 typeof=Air
    {
        [StateBit] public  bool PoweredBit { get; set; } = false;
        
        public SculkSensor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sculk_sensor";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class SculkShrieker : Block // 0 typeof=Air
    {
        [StateBit] public  bool Active { get; set; } = false;
        [StateBit] public  bool CanSummon { get; set; } = false;
        
        public SculkShrieker() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "active":
                        Active = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "can_summon":
                        CanSummon = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sculk_shrieker";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "active", Value = Convert.ToByte(Active)});
            record.States.Add(new BlockStateByte {Name = "can_summon", Value = Convert.ToByte(CanSummon)});
            return record;
        } // method
    } // class

    public partial class SculkVein : Block // 0 typeof=Air
    {
        [StateRange(0, 63)] public  int MultiFaceDirectionBits { get; set; } = 0;
        
        public SculkVein() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "multi_face_direction_bits":
                        MultiFaceDirectionBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sculk_vein";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "multi_face_direction_bits", Value = MultiFaceDirectionBits});
            return record;
        } // method
    } // class

    public partial class SeaLantern // 169 typeof=SeaLantern
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sea_lantern";
            record.Id = 169;
            return record;
        } // method
    } // class

    public partial class SeaPickle : Block // 411 typeof=SeaPickle
    {
        [StateRange(0, 3)] public  int ClusterCount { get; set; } = 0;
        [StateBit] public  bool DeadBit { get; set; } = false;
        
        public SeaPickle() : base(411)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "cluster_count":
                        ClusterCount = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "dead_bit":
                        DeadBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sea_pickle";
            record.Id = 411;
            record.States.Add(new BlockStateInt {Name = "cluster_count", Value = ClusterCount});
            record.States.Add(new BlockStateByte {Name = "dead_bit", Value = Convert.ToByte(DeadBit)});
            return record;
        } // method
    } // class

    public partial class Seagrass : Block // 385 typeof=Seagrass
    {
        [StateEnum("double_top","double_bot","default")]
        public  string SeaGrassType { get; set; } = "";
        
        public Seagrass() : base(385)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sea_grass_type":
                        SeaGrassType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:seagrass";
            record.Id = 385;
            record.States.Add(new BlockStateString {Name = "sea_grass_type", Value = SeaGrassType});
            return record;
        } // method
    } // class

    public partial class Shroomlight : Block // 0 typeof=Air
    {
        
        public Shroomlight() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:shroomlight";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class ShulkerBox  // 218 typeof=ShulkerBox
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:shulker_box";
            record.Id = 218;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class SilverGlazedTerracotta  // 228 typeof=SilverGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:silver_glazed_terracotta";
            record.Id = 228;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Skull  // 144 typeof=Skull
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:skull";
            record.Id = 144;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Slime  // 165 typeof=Slime
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:slime";
            record.Id = 165;
            return record;
        } // method
    } // class

    public partial class SmallAmethystBud : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public SmallAmethystBud() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:small_amethyst_bud";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class SmallDripleafBlock : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public SmallDripleafBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:small_dripleaf_block";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class SmithingTable : Block // 457 typeof=SmithingTable
    {
        
        public SmithingTable() : base(457)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smithing_table";
            record.Id = 457;
            return record;
        } // method
    } // class

    public partial class Smoker : Block // 453 typeof=Smoker
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public Smoker() : base(453)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smoker";
            record.Id = 453;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class SmoothBasalt : Block // 0 typeof=Air
    {
        
        public SmoothBasalt() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_basalt";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class SmoothQuartzStairs  // 440 typeof=SmoothQuartzStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_quartz_stairs";
            record.Id = 440;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothRedSandstoneStairs  // 431 typeof=SmoothRedSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_red_sandstone_stairs";
            record.Id = 431;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothSandstoneStairs  // 432 typeof=SmoothSandstoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_sandstone_stairs";
            record.Id = 432;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SmoothStone : Block // 438 typeof=SmoothStone
    {
        
        public SmoothStone() : base(438)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:smooth_stone";
            record.Id = 438;
            return record;
        } // method
    } // class

    public partial class Snow  // 80 typeof=Snow
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:snow";
            record.Id = 80;
            return record;
        } // method
    } // class

    public partial class SnowLayer  // 78 typeof=SnowLayer
    {
        [StateBit] public  bool CoveredBit { get; set; } = false;
        [StateRange(0, 7)] public  int Height { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "covered_bit":
                        CoveredBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "height":
                        Height = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:snow_layer";
            record.Id = 78;
            record.States.Add(new BlockStateByte {Name = "covered_bit", Value = Convert.ToByte(CoveredBit)});
            record.States.Add(new BlockStateInt {Name = "height", Value = Height});
            return record;
        } // method
    } // class

    public partial class SoulCampfire : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool Extinguished { get; set; } = false;
        
        public SoulCampfire() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "extinguished":
                        Extinguished = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_campfire";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "extinguished", Value = Convert.ToByte(Extinguished)});
            return record;
        } // method
    } // class

    public partial class SoulFire : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int Age { get; set; } = 0;
        
        public SoulFire() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "age":
                        Age = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_fire";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "age", Value = Age});
            return record;
        } // method
    } // class

    public partial class SoulLantern : Block // 0 typeof=Air
    {
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public SoulLantern() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_lantern";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class SoulSand  // 88 typeof=SoulSand
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_sand";
            record.Id = 88;
            return record;
        } // method
    } // class

    public partial class SoulSoil : Block // 0 typeof=Air
    {
        
        public SoulSoil() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_soil";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class SoulTorch : Block // 0 typeof=Air
    {
        [StateEnum("unknown","west","east","north","south","top")]
        public  string TorchFacingDirection { get; set; } = "unknown";
        
        public SoulTorch() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:soul_torch";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class Sponge  // 19 typeof=Sponge
    {
        [StateEnum("dry","wet")]
        public  string SpongeType { get; set; } = "dry";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "sponge_type":
                        SpongeType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sponge";
            record.Id = 19;
            record.States.Add(new BlockStateString {Name = "sponge_type", Value = SpongeType});
            return record;
        } // method
    } // class

    public partial class SporeBlossom : Block // 0 typeof=Air
    {
        
        public SporeBlossom() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spore_blossom";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class SpruceButton  // 399 typeof=SpruceButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_button";
            record.Id = 399;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class SpruceDoor  // 193 typeof=SpruceDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_door";
            record.Id = 193;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class SpruceFence : Block // 85 typeof=Fence
    {
        
        public SpruceFence() : base(85)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_fence";
            record.Id = 85;
            return record;
        } // method
    } // class

    public partial class SpruceFenceGate  // 183 typeof=SpruceFenceGate
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_fence_gate";
            record.Id = 183;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class SpruceHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public SpruceHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class SpruceLog : LogBase // 17 typeof=Log
	{
        public SpruceLog() : base(17)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_log";
            record.Id = 17;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class SprucePressurePlate : Block // 409 typeof=SprucePressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public SprucePressurePlate() : base(409)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_pressure_plate";
            record.Id = 409;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class SpruceStairs  // 134 typeof=SpruceStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_stairs";
            record.Id = 134;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class SpruceStandingSign  // 436 typeof=SpruceStandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_standing_sign";
            record.Id = 436;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class SpruceTrapdoor  // 404 typeof=SpruceTrapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_trapdoor";
            record.Id = 404;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class SpruceWallSign  // 437 typeof=SpruceWallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:spruce_wall_sign";
            record.Id = 437;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StainedGlass  // 241 typeof=StainedGlass
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stained_glass";
            record.Id = 241;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class StainedGlassPane  // 160 typeof=StainedGlassPane
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stained_glass_pane";
            record.Id = 160;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class StainedHardenedClay  // 159 typeof=StainedHardenedClay
    {
        [StateEnum("white","orange","magenta","light_blue","yellow","lime","pink","gray","silver","cyan","purple","blue","brown","green","red","black")]
        public  string Color { get; set; } = "white";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "color":
                        Color = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stained_hardened_clay";
            record.Id = 159;
            record.States.Add(new BlockStateString {Name = "color", Value = Color});
            return record;
        } // method
    } // class

    public partial class StandingBanner  // 176 typeof=StandingBanner
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:standing_banner";
            record.Id = 176;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class StandingSign  // 63 typeof=StandingSign
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:standing_sign";
            record.Id = 63;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class StickyPiston  // 29 typeof=StickyPiston
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sticky_piston";
            record.Id = 29;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StickyPistonArmCollision : Block // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public StickyPistonArmCollision() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sticky_piston_arm_collision";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class Stone  // 1 typeof=Stone
    {
        [StateEnum("granite","granite_smooth","diorite","diorite_smooth","andesite","andesite_smooth","stone")]
        public  string StoneType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_type":
                        StoneType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone";
            record.Id = 1;
            record.States.Add(new BlockStateString {Name = "stone_type", Value = StoneType});
            return record;
        } // method
    } // class

    public partial class StoneBlockSlab : SlabBase // 44 typeof=StoneSlab
    {
        [StateEnum("smooth_stone","sandstone","wood","cobblestone","brick","stone_brick","quartz","nether_brick")]
        public  string StoneSlabType { get; set; } = "smooth_stone";
        [StateBit] public override bool TopSlotBit { get; set; } = false;
        
        public StoneBlockSlab() : base(44)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type":
                        StoneSlabType = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_block_slab";
            record.Id = 44;
            record.States.Add(new BlockStateString {Name = "stone_slab_type", Value = StoneSlabType});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class StoneBlockSlab2 : SlabBase // 182 typeof=StoneSlab2
	{
        [StateEnum("red_sandstone","purpur","prismarine_rough","prismarine_dark","prismarine_brick","mossy_cobblestone","smooth_sandstone","red_nether_brick")]
        public  string StoneSlabType2 { get; set; } = "red_sandstone";
        [StateBit] public override bool TopSlotBit { get; set; } = false;
        
        public StoneBlockSlab2() : base(182)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_2":
                        StoneSlabType2 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_block_slab2";
            record.Id = 182;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_2", Value = StoneSlabType2});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class StoneBlockSlab3 : SlabBase // 417 typeof=StoneSlab3
	{
        [StateEnum("end_stone_brick","smooth_red_sandstone","polished_andesite","andesite","diorite","polished_diorite","granite","polished_granite")]
        public  string StoneSlabType3 { get; set; } = "end_stone_brick";
        [StateBit] public override bool TopSlotBit { get; set; } = false;
        
        public StoneBlockSlab3() : base(417)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_3":
                        StoneSlabType3 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_block_slab3";
            record.Id = 417;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_3", Value = StoneSlabType3});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class StoneBlockSlab4 : SlabBase // 421 typeof=StoneSlab4
	{
        [StateEnum("smooth_quartz","stone","cut_sandstone","cut_red_sandstone","mossy_stone_brick")]
        public  string StoneSlabType4 { get; set; } = "";
        [StateBit] public override bool TopSlotBit { get; set; } = false;
        
        public StoneBlockSlab4() : base(421)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_slab_type_4":
                        StoneSlabType4 = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_block_slab4";
            record.Id = 421;
            record.States.Add(new BlockStateString {Name = "stone_slab_type_4", Value = StoneSlabType4});
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class StoneBrickStairs  // 109 typeof=StoneBrickStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_brick_stairs";
            record.Id = 109;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class StoneButton  // 77 typeof=StoneButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_button";
            record.Id = 77;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StonePressurePlate  // 70 typeof=StonePressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_pressure_plate";
            record.Id = 70;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class StoneStairs  // 67 typeof=StoneStairs
    {
        [StateBit] public override bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public override int WeirdoDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stone_stairs";
            record.Id = 67;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class Stonebrick  // 98 typeof=Stonebrick
    {
        [StateEnum("mossy","cracked","chiseled","smooth","default")]
        public  string StoneBrickType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "stone_brick_type":
                        StoneBrickType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonebrick";
            record.Id = 98;
            record.States.Add(new BlockStateString {Name = "stone_brick_type", Value = StoneBrickType});
            return record;
        } // method
    } // class

    public partial class Stonecutter  // 245 typeof=Stonecutter
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonecutter";
            record.Id = 245;
            return record;
        } // method
    } // class

    public partial class StonecutterBlock : Block // 452 typeof=StonecutterBlock
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public StonecutterBlock() : base(452)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stonecutter_block";
            record.Id = 452;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class StrippedAcaciaLog : LogBase // 263 typeof=StrippedAcaciaLog
	{
        public StrippedAcaciaLog() : base(263)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_acacia_log";
            record.Id = 263;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedBambooBlock : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedBambooBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_bamboo_block";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedBirchLog : LogBase // 261 typeof=StrippedBirchLog
	{
        public StrippedBirchLog() : base(261)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_birch_log";
            record.Id = 261;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedCherryLog : LogBase // 0 typeof=Air
	{
        public StrippedCherryLog() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_cherry_log";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedCherryWood : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedCherryWood() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_cherry_wood";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedCrimsonHyphae : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedCrimsonHyphae() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_crimson_hyphae";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedCrimsonStem : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedCrimsonStem() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_crimson_stem";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedDarkOakLog : LogBase // 264 typeof=StrippedDarkOakLog
	{
        public StrippedDarkOakLog() : base(264)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_dark_oak_log";
            record.Id = 264;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedJungleLog : LogBase // 262 typeof=StrippedJungleLog
	{
        public StrippedJungleLog() : base(262)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_jungle_log";
            record.Id = 262;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedMangroveLog : LogBase // 0 typeof=Air
	{
        public StrippedMangroveLog() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_mangrove_log";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedMangroveWood : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedMangroveWood() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_mangrove_wood";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedOakLog : LogBase // 265 typeof=StrippedOakLog
	{
        public StrippedOakLog() : base(265)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_oak_log";
            record.Id = 265;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedSpruceLog : LogBase // 260 typeof=StrippedSpruceLog
	{
        public StrippedSpruceLog() : base(260)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_spruce_log";
            record.Id = 260;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedWarpedHyphae : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedWarpedHyphae() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_warped_hyphae";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StrippedWarpedStem : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public StrippedWarpedStem() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:stripped_warped_stem";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class StructureBlock  // 252 typeof=StructureBlock
    {
        [StateEnum("save","load","corner","invalid","export","data")]
        public  string StructureBlockType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "structure_block_type":
                        StructureBlockType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:structure_block";
            record.Id = 252;
            record.States.Add(new BlockStateString {Name = "structure_block_type", Value = StructureBlockType});
            return record;
        } // method
    } // class

    public partial class StructureVoid : Block // 0 typeof=Air
    {
        [StateEnum("void","air")]
        public  string StructureVoidType { get; set; } = "void";
        
        public StructureVoid() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "structure_void_type":
                        StructureVoidType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:structure_void";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "structure_void_type", Value = StructureVoidType});
            return record;
        } // method
    } // class

    public partial class SuspiciousGravel : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int BrushedProgress { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public SuspiciousGravel() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "brushed_progress":
                        BrushedProgress = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:suspicious_gravel";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "brushed_progress", Value = BrushedProgress});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class SuspiciousSand : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int BrushedProgress { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public SuspiciousSand() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "brushed_progress":
                        BrushedProgress = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:suspicious_sand";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "brushed_progress", Value = BrushedProgress});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class SweetBerryBush : Block // 462 typeof=SweetBerryBush
    {
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;
        
        public SweetBerryBush() : base(462)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:sweet_berry_bush";
            record.Id = 462;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class Tallgrass  // 31 typeof=Tallgrass
    {
        [StateEnum("default","tall","fern","snow")]
        public  string TallGrassType { get; set; } = "default";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "tall_grass_type":
                        TallGrassType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tallgrass";
            record.Id = 31;
            record.States.Add(new BlockStateString {Name = "tall_grass_type", Value = TallGrassType});
            return record;
        } // method
    } // class

    public partial class Target : Block // 0 typeof=Air
    {
        
        public Target() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:target";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class TintedGlass : Block // 0 typeof=Air
    {
        
        public TintedGlass() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tinted_glass";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Tnt  // 46 typeof=Tnt
    {
        [StateBit] public  bool AllowUnderwaterBit { get; set; } = false;
        [StateBit] public  bool ExplodeBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "allow_underwater_bit":
                        AllowUnderwaterBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "explode_bit":
                        ExplodeBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tnt";
            record.Id = 46;
            record.States.Add(new BlockStateByte {Name = "allow_underwater_bit", Value = Convert.ToByte(AllowUnderwaterBit)});
            record.States.Add(new BlockStateByte {Name = "explode_bit", Value = Convert.ToByte(ExplodeBit)});
            return record;
        } // method
    } // class

    public partial class Torch  // 50 typeof=Torch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:torch";
            record.Id = 50;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class Torchflower : Block // 0 typeof=Air
    {
        
        public Torchflower() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:torchflower";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class TorchflowerCrop : Block // 0 typeof=Air
    {
        [StateRange(0, 7)] public  int Growth { get; set; } = 0;
        
        public TorchflowerCrop() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:torchflower_crop";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class Trapdoor  // 96 typeof=Trapdoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpsideDownBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trapdoor";
            record.Id = 96;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class TrappedChest  // 146 typeof=TrappedChest
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trapped_chest";
            record.Id = 146;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class TripWire // 132 typeof=TripWire
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateBit] public  bool DisarmedBit { get; set; } = false;
        [StateBit] public  bool PoweredBit { get; set; } = false;
        [StateBit] public  bool SuspendedBit { get; set; } = false;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "disarmed_bit":
                        DisarmedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "suspended_bit":
                        SuspendedBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:trip_wire";
            record.Id = 132;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateByte {Name = "disarmed_bit", Value = Convert.ToByte(DisarmedBit)});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            record.States.Add(new BlockStateByte {Name = "suspended_bit", Value = Convert.ToByte(SuspendedBit)});
            return record;
        } // method
    } // class

    public partial class TripwireHook  // 131 typeof=TripwireHook
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool PoweredBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "powered_bit":
                        PoweredBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tripwire_hook";
            record.Id = 131;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "powered_bit", Value = Convert.ToByte(PoweredBit)});
            return record;
        } // method
    } // class

    public partial class Tuff : Block // 0 typeof=Air
    {
        
        public Tuff() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:tuff";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class TurtleEgg : Block // 414 typeof=TurtleEgg
    {
        [StateEnum("cracked","max_cracked","no_cracks")]
        public  string CrackedState { get; set; } = "";
        [StateEnum("one_egg","two_egg","three_egg","four_egg")]
        public  string TurtleEggCount { get; set; } = "";
        
        public TurtleEgg() : base(414)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "cracked_state":
                        CrackedState = s.Value;
                        break;
                    case BlockStateString s when s.Name == "turtle_egg_count":
                        TurtleEggCount = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:turtle_egg";
            record.Id = 414;
            record.States.Add(new BlockStateString {Name = "cracked_state", Value = CrackedState});
            record.States.Add(new BlockStateString {Name = "turtle_egg_count", Value = TurtleEggCount});
            return record;
        } // method
    } // class

    public partial class TwistingVines : Block // 0 typeof=Air
    {
        [StateRange(0, 25)] public  int TwistingVinesAge { get; set; } = 0;
        
        public TwistingVines() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "twisting_vines_age":
                        TwistingVinesAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:twisting_vines";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "twisting_vines_age", Value = TwistingVinesAge});
            return record;
        } // method
    } // class

    public partial class UnderwaterTorch : Block // 239 typeof=UnderwaterTorch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public  string TorchFacingDirection { get; set; } = "";
        
        public UnderwaterTorch() : base(239)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:underwater_torch";
            record.Id = 239;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class UndyedShulkerBox  // 205 typeof=UndyedShulkerBox
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:undyed_shulker_box";
            record.Id = 205;
            return record;
        } // method
    } // class

    public partial class Unknown : Block // 0 typeof=Air
    {
        
        public Unknown() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unknown";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class UnlitRedstoneTorch  // 75 typeof=UnlitRedstoneTorch
    {
        [StateEnum("west","east","north","south","top","unknown")]
        public override string TorchFacingDirection { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "torch_facing_direction":
                        TorchFacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unlit_redstone_torch";
            record.Id = 75;
            record.States.Add(new BlockStateString {Name = "torch_facing_direction", Value = TorchFacingDirection});
            return record;
        } // method
    } // class

    public partial class UnpoweredComparator  // 149 typeof=UnpoweredComparator
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool OutputLitBit { get; set; } = false;
        [StateBit] public  bool OutputSubtractBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "output_lit_bit":
                        OutputLitBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "output_subtract_bit":
                        OutputSubtractBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unpowered_comparator";
            record.Id = 149;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "output_lit_bit", Value = Convert.ToByte(OutputLitBit)});
            record.States.Add(new BlockStateByte {Name = "output_subtract_bit", Value = Convert.ToByte(OutputSubtractBit)});
            return record;
        } // method
    } // class

    public partial class UnpoweredRepeater  // 93 typeof=UnpoweredRepeater
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateRange(0, 3)] public  int RepeaterDelay { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "repeater_delay":
                        RepeaterDelay = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:unpowered_repeater";
            record.Id = 93;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateInt {Name = "repeater_delay", Value = RepeaterDelay});
            return record;
        } // method
    } // class

    public partial class VerdantFroglight : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public VerdantFroglight() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:verdant_froglight";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class Vine  // 106 typeof=Vine
    {
        [StateRange(0, 15)] public  int VineDirectionBits { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "vine_direction_bits":
                        VineDirectionBits = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:vine";
            record.Id = 106;
            record.States.Add(new BlockStateInt {Name = "vine_direction_bits", Value = VineDirectionBits});
            return record;
        } // method
    } // class

    public partial class WallBanner  // 177 typeof=WallBanner
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wall_banner";
            record.Id = 177;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WallSign  // 68 typeof=WallSign
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wall_sign";
            record.Id = 68;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WarpedButton : Block // 0 typeof=Air
    {
        [StateBit] public  bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public WarpedButton() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_button";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WarpedDoor : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool DoorHingeBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        [StateBit] public  bool UpperBlockBit { get; set; } = false;
        
        public WarpedDoor() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_door";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class WarpedDoubleSlab // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_double_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WarpedFence : Block // 0 typeof=Air
    {
        
        public WarpedFence() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_fence";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WarpedFenceGate : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Direction { get; set; } = 0;
        [StateBit] public  bool InWallBit { get; set; } = false;
        [StateBit] public  bool OpenBit { get; set; } = false;
        
        public WarpedFenceGate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "in_wall_bit":
                        InWallBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_fence_gate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "in_wall_bit", Value = Convert.ToByte(InWallBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            return record;
        } // method
    } // class

    public partial class WarpedFungus : Block // 0 typeof=Air
    {
        
        public WarpedFungus() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_fungus";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WarpedHangingSign : Block // 0 typeof=Air
    {
        [StateBit] public  bool AttachedBit { get; set; } = false;
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        [StateBit] public  bool Hanging { get; set; } = false;
        
        public WarpedHangingSign() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "attached_bit":
                        AttachedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "hanging":
                        Hanging = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_hanging_sign";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "attached_bit", Value = Convert.ToByte(AttachedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            record.States.Add(new BlockStateByte {Name = "hanging", Value = Convert.ToByte(Hanging)});
            return record;
        } // method
    } // class

    public partial class WarpedHyphae : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public WarpedHyphae() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_hyphae";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class WarpedNylium : Block // 0 typeof=Air
    {
        
        public WarpedNylium() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_nylium";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WarpedPlanks : Block // 0 typeof=Air
    {
        
        public WarpedPlanks() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_planks";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WarpedPressurePlate : Block // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;
        
        public WarpedPressurePlate() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_pressure_plate";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class WarpedRoots : Block // 0 typeof=Air
    {
        
        public WarpedRoots() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_roots";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WarpedSlab // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WarpedStairs // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WarpedStandingSign // 0 typeof=Air
    {
        [StateRange(0, 15)] public  int GroundSignDirection { get; set; } = 0;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "ground_sign_direction":
                        GroundSignDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_standing_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "ground_sign_direction", Value = GroundSignDirection});
            return record;
        } // method
    } // class

    public partial class WarpedStem : Block // 0 typeof=Air
    {
        [StateEnum("y","x","z")]
        public  string PillarAxis { get; set; } = "y";
        
        public WarpedStem() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_stem";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            return record;
        } // method
    } // class

    public partial class WarpedTrapdoor // 0 typeof=Air
    {
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_trapdoor";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            return record;
        } // method
    } // class

    public partial class WarpedWallSign // 0 typeof=Air
    {
        [StateRange(0, 5)] public  int FacingDirection { get; set; } = 0;
        
        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_wall_sign";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WarpedWartBlock : Block // 0 typeof=Air
    {
        
        public WarpedWartBlock() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:warped_wart_block";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Water  // 9 typeof=Water
    {
        [StateRange(0, 15)] public override int LiquidDepth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "liquid_depth":
                        LiquidDepth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:water";
            record.Id = 9;
            record.States.Add(new BlockStateInt {Name = "liquid_depth", Value = LiquidDepth});
            return record;
        } // method
    } // class

    public partial class Waterlily  // 111 typeof=Waterlily
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waterlily";
            record.Id = 111;
            return record;
        } // method
    } // class

    public partial class WaxedCopper : Block // 0 typeof=Air
    {
        
        public WaxedCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedCutCopper : Block // 0 typeof=Air
    {
        
        public WaxedCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public WaxedCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WaxedDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedExposedCopper : Block // 0 typeof=Air
    {
        
        public WaxedExposedCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_exposed_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedExposedCutCopper : Block // 0 typeof=Air
    {
        
        public WaxedExposedCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_exposed_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedExposedCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedExposedCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_exposed_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedExposedCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public WaxedExposedCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_exposed_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WaxedExposedDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedExposedDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_exposed_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedOxidizedCopper : Block // 0 typeof=Air
    {
        
        public WaxedOxidizedCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_oxidized_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedOxidizedCutCopper : Block // 0 typeof=Air
    {
        
        public WaxedOxidizedCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_oxidized_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedOxidizedCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedOxidizedCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_oxidized_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedOxidizedCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public WaxedOxidizedCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_oxidized_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WaxedOxidizedDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedOxidizedDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_oxidized_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedWeatheredCopper : Block // 0 typeof=Air
    {
        
        public WaxedWeatheredCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_weathered_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedWeatheredCutCopper : Block // 0 typeof=Air
    {
        
        public WaxedWeatheredCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_weathered_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WaxedWeatheredCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedWeatheredCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_weathered_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WaxedWeatheredCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public WaxedWeatheredCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_weathered_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WaxedWeatheredDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WaxedWeatheredDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:waxed_weathered_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WeatheredCopper : Block // 0 typeof=Air
    {
        
        public WeatheredCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weathered_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WeatheredCutCopper : Block // 0 typeof=Air
    {
        
        public WeatheredCutCopper() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weathered_cut_copper";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class WeatheredCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WeatheredCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weathered_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class WeatheredCutCopperStairs : Block // 0 typeof=Air
    {
        [StateBit] public  bool UpsideDownBit { get; set; } = false;
        [StateRange(0, 3)] public  int WeirdoDirection { get; set; } = 0;
        
        public WeatheredCutCopperStairs() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "upside_down_bit":
                        UpsideDownBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "weirdo_direction":
                        WeirdoDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weathered_cut_copper_stairs";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "upside_down_bit", Value = Convert.ToByte(UpsideDownBit)});
            record.States.Add(new BlockStateInt {Name = "weirdo_direction", Value = WeirdoDirection});
            return record;
        } // method
    } // class

    public partial class WeatheredDoubleCutCopperSlab : Block // 0 typeof=Air
    {
        [StateBit] public  bool TopSlotBit { get; set; } = false;
        
        public WeatheredDoubleCutCopperSlab() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weathered_double_cut_copper_slab";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            return record;
        } // method
    } // class

    public partial class Web  // 30 typeof=Web
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:web";
            record.Id = 30;
            return record;
        } // method
    } // class

    public partial class WeepingVines : Block // 0 typeof=Air
    {
        [StateRange(0, 25)] public  int WeepingVinesAge { get; set; } = 0;
        
        public WeepingVines() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "weeping_vines_age":
                        WeepingVinesAge = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:weeping_vines";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "weeping_vines_age", Value = WeepingVinesAge});
            return record;
        } // method
    } // class

    public partial class Wheat  // 59 typeof=Wheat
    {
        [StateRange(0, 7)] public override int Growth { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "growth":
                        Growth = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wheat";
            record.Id = 59;
            record.States.Add(new BlockStateInt {Name = "growth", Value = Growth});
            return record;
        } // method
    } // class

    public partial class WhiteCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public WhiteCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:white_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class WhiteCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public WhiteCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:white_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class WhiteGlazedTerracotta  // 220 typeof=WhiteGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:white_glazed_terracotta";
            record.Id = 220;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WhiteWool : Block // 35 typeof=Wool
    {
        
        public WhiteWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:white_wool";
            record.Id = 35;
            return record;
        } // method
    } // class

    public partial class WitherRose : Block // 0 typeof=Air
    {
        
        public WitherRose() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wither_rose";
            record.Id = 0;
            return record;
        } // method
    } // class

    public partial class Wood : Block // 0 typeof=Air
    {
        [StateEnum("x","z","y")]
        public  string PillarAxis { get; set; } = "x";
        [StateBit] public  bool StrippedBit { get; set; } = false;
        [StateEnum("oak","spruce","birch","jungle","acacia","dark_oak")]
        public  string WoodType { get; set; } = "oak";
        
        public Wood() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateString s when s.Name == "pillar_axis":
                        PillarAxis = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "stripped_bit":
                        StrippedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wood";
            record.Id = 0;
            record.States.Add(new BlockStateString {Name = "pillar_axis", Value = PillarAxis});
            record.States.Add(new BlockStateByte {Name = "stripped_bit", Value = Convert.ToByte(StrippedBit)});
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class WoodenButton  // 143 typeof=WoodenButton
    {
        [StateBit] public override bool ButtonPressedBit { get; set; } = false;
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "button_pressed_bit":
                        ButtonPressedBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_button";
            record.Id = 143;
            record.States.Add(new BlockStateByte {Name = "button_pressed_bit", Value = Convert.ToByte(ButtonPressedBit)});
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class WoodenDoor  // 64 typeof=WoodenDoor
    {
        [StateRange(0, 3)] public override int Direction { get; set; } = 0;
        [StateBit] public override bool DoorHingeBit { get; set; } = false;
        [StateBit] public override bool OpenBit { get; set; } = false;
        [StateBit] public override bool UpperBlockBit { get; set; } = false;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "direction":
                        Direction = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "door_hinge_bit":
                        DoorHingeBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "open_bit":
                        OpenBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateByte s when s.Name == "upper_block_bit":
                        UpperBlockBit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_door";
            record.Id = 64;
            record.States.Add(new BlockStateInt {Name = "direction", Value = Direction});
            record.States.Add(new BlockStateByte {Name = "door_hinge_bit", Value = Convert.ToByte(DoorHingeBit)});
            record.States.Add(new BlockStateByte {Name = "open_bit", Value = Convert.ToByte(OpenBit)});
            record.States.Add(new BlockStateByte {Name = "upper_block_bit", Value = Convert.ToByte(UpperBlockBit)});
            return record;
        } // method
    } // class

    public partial class WoodenPressurePlate  // 72 typeof=WoodenPressurePlate
    {
        [StateRange(0, 15)] public  int RedstoneSignal { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "redstone_signal":
                        RedstoneSignal = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_pressure_plate";
            record.Id = 72;
            record.States.Add(new BlockStateInt {Name = "redstone_signal", Value = RedstoneSignal});
            return record;
        } // method
    } // class

    public partial class WoodenSlab  // 158 typeof=WoodenSlab
    {
        [StateBit] public override bool TopSlotBit { get; set; } = false;
        [StateEnum("spruce","birch","jungle","acacia","dark_oak","oak")]
        public  string WoodType { get; set; } = "";

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "top_slot_bit":
                        TopSlotBit = Convert.ToBoolean(s.Value);
                        break;
                    case BlockStateString s when s.Name == "wood_type":
                        WoodType = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:wooden_slab";
            record.Id = 158;
            record.States.Add(new BlockStateByte {Name = "top_slot_bit", Value = Convert.ToByte(TopSlotBit)});
            record.States.Add(new BlockStateString {Name = "wood_type", Value = WoodType});
            return record;
        } // method
    } // class

    public partial class YellowCandle : Block // 0 typeof=Air
    {
        [StateRange(0, 3)] public  int Candles { get; set; } = 0;
        [StateBit] public  bool Lit { get; set; } = false;
        
        public YellowCandle() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "candles":
                        Candles = s.Value;
                        break;
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_candle";
            record.Id = 0;
            record.States.Add(new BlockStateInt {Name = "candles", Value = Candles});
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class YellowCandleCake : Block // 0 typeof=Air
    {
        [StateBit] public  bool Lit { get; set; } = false;
        
        public YellowCandleCake() : base(0)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateByte s when s.Name == "lit":
                        Lit = Convert.ToBoolean(s.Value);
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_candle_cake";
            record.Id = 0;
            record.States.Add(new BlockStateByte {Name = "lit", Value = Convert.ToByte(Lit)});
            return record;
        } // method
    } // class

    public partial class YellowFlower  // 37 typeof=YellowFlower
    {

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_flower";
            record.Id = 37;
            return record;
        } // method
    } // class

    public partial class YellowGlazedTerracotta  // 224 typeof=YellowGlazedTerracotta
    {
        [StateRange(0, 5)] public override int FacingDirection { get; set; } = 0;

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                    case BlockStateInt s when s.Name == "facing_direction":
                        FacingDirection = s.Value;
                        break;
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_glazed_terracotta";
            record.Id = 224;
            record.States.Add(new BlockStateInt {Name = "facing_direction", Value = FacingDirection});
            return record;
        } // method
    } // class

    public partial class YellowWool : Block // 35 typeof=Wool
    {
        
        public YellowWool() : base(35)
        {
            IsGenerated = true;
        }

        public override void SetState(List<IBlockState> states)
        {
            foreach (var state in states)
            {
                switch(state)
                {
                } // switch
            } // foreach
        } // method

        public override BlockStateContainer GetState()
        {
            var record = new BlockStateContainer();
            record.Name = "minecraft:yellow_wool";
            record.Id = 35;
            return record;
        } // method
    } // class
}