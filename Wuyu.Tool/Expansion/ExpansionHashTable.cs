using System.Collections;

namespace Wuyu.Tool.Expansion
{
	public static class ExpansionHashTable
	{
		public static object Read(this Hashtable hashtable, object key)
		{
			if (hashtable.Contains(key))
			{
				return hashtable[key];
			}
			return null;
		}

		public static void Write(this Hashtable hashtable, object key, object value)
		{
			hashtable[key] = value;
		}
	}
}
