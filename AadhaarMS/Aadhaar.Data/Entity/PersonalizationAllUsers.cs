using System;
using System.Collections.Generic;
using System.ComponentModel;
using Iesi.Collections;
//using Iesi.Collections.Generic;
using Aadhaar.Data.Entity.Components;


using Aadhaar.Data.Entity;

namespace Aadhaar.Data.Entity 
{    
	/// <summary>
	/// An object representation of the PersonalizationAllUsers table
	/// </summary>
	[Serializable]
	public class PersonalizationAllUsers : Paths
	{

		private Byte[] _PageSettings;
		private System.DateTime _LastUpdatedDate;

		public virtual Byte[] PageSettings
		{
			get
			{
				return _PageSettings;
			}
			set
			{
				_PageSettings = value;
			}
		}

		public virtual System.DateTime LastUpdatedDate
		{
			get
			{
				return _LastUpdatedDate;
			}
			set
			{
				_LastUpdatedDate = value;
			}
		}


		protected bool Equals(PersonalizationAllUsers entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as PersonalizationAllUsers);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
