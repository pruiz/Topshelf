using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topshelf
{
	public static class EnviromentHelper
	{
		public static bool RunningOnMono
		{
			get
			{
				Type t = Type.GetType("Mono.Runtime");
				if (t != null)
					return true;

				return false;
			}
		}

		public static bool RunninOnUnix
		{
			get
			{
				int p = (int)Environment.OSVersion.Platform;
				return ((p == 4) || (p == 6) || (p == 128));
			}
		}
	}
}
