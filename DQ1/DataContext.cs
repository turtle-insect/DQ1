namespace DQ1
{
	class DataContext
	{
		public Charactor Hero { get; set; } = new Charactor(0x13);

		public uint Gold
		{
			get
			{
				return SaveData.Instance().ReadNumber(0x5C, 4);
			}

			set
			{
				Util.WriteNumber(0x5C, 4, value, 0, 99999999);
			}
		}

		public bool Princess
		{
			get
			{
				return SaveData.Instance().ReadNumber(0xC4, 1) == 1;
			}

			set
			{
				SaveData.Instance().WriteNumber(0xC4, 1, value ? 1U : 0);
			}
		}
	}
}
