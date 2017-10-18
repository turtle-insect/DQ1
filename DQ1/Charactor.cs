using System;
using System.Collections.ObjectModel;

namespace DQ1
{
	class Charactor
	{
		public ObservableCollection<CharactorItem> Items { get; set; } = new ObservableCollection<CharactorItem>();

		private readonly uint mAddress;

		public Charactor(uint address)
		{
			mAddress = address;

			for (uint i = 0; i < Util.ItemCount; i++)
			{
				Items.Add(new CharactorItem(mAddress + 0x2E + i * 2));
			}
		}

		public uint Lv
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x13, 1);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x13, 1, value, 1, 99);
			}
		}

		public String Name
		{
			get
			{
				return SaveData.Instance().ReadText(mAddress, 4);
			}

			set
			{
				SaveData.Instance().WriteText(mAddress, 4, value);
			}
		}

		public uint Power
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x1C, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x1C, 2, value, 0, 999);
			}
		}

		public uint Speed
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x1E, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x1E, 2, value, 0, 999);
			}
		}

		public uint Protect
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x20, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x20, 2, value, 0, 999);
			}
		}

		public uint HP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x14, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x14, 2, value, 0, 999);
			}
		}

		public uint MaxHP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x22, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x22, 2, value, 0, 999);
			}
		}

		public uint MP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x16, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x16, 2, value, 0, 999);
			}
		}

		public uint MaxMP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x24, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x24, 2, value, 0, 999);
			}
		}

		public uint Attack
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x26, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x26, 2, value, 0, 999);
			}
		}

		public uint Defense
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x28, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x28, 2, value, 0, 999);
			}
		}

		public uint Key
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x42, 1);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x42, 1, value, 0, 127);
			}
		}

		public uint Plant
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x43, 1);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x43, 1, value, 0, 127);
			}
		}

		public uint Exp
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x18, 4);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x18, 4, value, 0, 99999999);
			}
		}
	}
}
