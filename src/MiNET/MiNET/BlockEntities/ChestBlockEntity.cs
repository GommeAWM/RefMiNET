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

using System.Collections.Generic;
using fNbt;
using MiNET.Items;
using MiNET.Net;
using MiNET.Utils.Nbt;
using MiNET.Worlds;

namespace MiNET.BlockEntities
{
	public class ChestBlockEntity : BlockEntity
	{
		private NbtCompound Compound { get; set; }

		public ChestBlockEntity() : this("Chest")
		{

		}

		protected ChestBlockEntity(string id) : base(id)
		{
			Compound = new NbtCompound(string.Empty)
			{
				new NbtString("id", Id),
				new NbtList("Items", new NbtCompound()),
				new NbtInt("x", Coordinates.X),
				new NbtInt("y", Coordinates.Y),
				new NbtInt("z", Coordinates.Z)
			};

			NbtList items = (NbtList) Compound["Items"];
			for (byte i = 0; i < 27; i++)
			{
				var itemTag = new ItemAir().ToNbt();
				itemTag.Add(new NbtByte("Slot", i));

				items.Add(itemTag);
			}
		}
		
		public void CreatePair(ChestBlockEntity sideChest, Level level)
		{
			sideChest.Pair(Coordinates.X, Coordinates.Z);
			Nbt sideChestNbt = sideChest.CreateNbt();
			
			var entityDataForSideChest = McpeBlockEntityData.CreateObject();
			entityDataForSideChest.namedtag = sideChestNbt;
			entityDataForSideChest.coordinates = sideChest.Coordinates;

			level.RelayBroadcast(entityDataForSideChest);
		}
		
		private void Pair(int sideChestX, int sideChestZ)
		{
			Compound.Add(new NbtInt("pairx", sideChestX));
			Compound.Add(new NbtInt("pairz", sideChestZ));
		}

		private Nbt CreateNbt()
		{
			return new Nbt
			{
				NbtFile = new NbtFile
				{
					BigEndian = false,
					UseVarInt = true,
					RootTag = Compound
				}
			};
		}

		public bool IsPaired() => Compound.Contains("pairx") && Compound.Contains("pairz");

		public override NbtCompound GetCompound()
		{
			Compound["x"] = new NbtInt("x", Coordinates.X);
			Compound["y"] = new NbtInt("y", Coordinates.Y);
			Compound["z"] = new NbtInt("z", Coordinates.Z);

			return Compound;
		}

		public override void SetCompound(NbtCompound compound)
		{
			Compound = compound;

			if (Compound["Items"] == null)
			{
				NbtList items = new NbtList("Items");
				for (byte i = 0; i < 27; i++)
				{
					var itemTag = new ItemAir().ToNbt();
					itemTag.Add(new NbtByte("Slot", i));

					items.Add(itemTag);
				}
				Compound["Items"] = items;
			}
		}

		public override List<Item> GetDrops()
		{
			List<Item> slots = new List<Item>();

			var items = Compound["Items"] as NbtList;
			if (items == null) return slots;

			for (byte i = 0; i < items.Count; i++)
			{
				slots.Add(ItemFactory.FromNbt(items[i]));
			}

			return slots;
		}
	}
}