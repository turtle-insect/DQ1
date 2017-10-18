﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}