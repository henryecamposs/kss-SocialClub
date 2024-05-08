using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Data.Objects.DataClasses;
using System.Data.Entity.Core.Objects.DataClasses;

namespace kss_DataObjects.Base
{
	public partial class kssDBBaseEntity : EntityObject, IDisposable
	{
		#region variables
		private Hashtable _Items;
		#endregion

		#region properties
		public object this[string name]
		{
			get
			{
				if (_Items == null)
					return null;

				return _Items[name];
			}
			set
			{
				if (_Items == null)
					_Items = new Hashtable();
				_Items[name] = value;
			}
		}
		#endregion

		#region public methods

		public void Dispose()
		{
		}
		#endregion
	}
}
