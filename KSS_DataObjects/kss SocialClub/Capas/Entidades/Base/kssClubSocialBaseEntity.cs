using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;

namespace kss_DataObjects.Base
{
	public partial class kssClubSocialBaseEntity :  IDisposable
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

        public override string ToString()
        {
            return ksslib_c.Utiles.clsUtil_Class.getPropertiesClassToString(this);
        }
        #endregion

        #region public methods

        public void Dispose()
		{
		}
		#endregion
	}
    
}
