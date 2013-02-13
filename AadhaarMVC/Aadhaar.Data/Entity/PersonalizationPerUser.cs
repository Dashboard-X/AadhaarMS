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
	/// An object representation of the PersonalizationPerUser table
	/// </summary>
	[Serializable]
	public class PersonalizationPerUser
	{
		protected System.Guid _Id;

		private Paths _Path;
		private Users _User;
		private Byte[] _PageSettings;
		private System.DateTime _LastUpdatedDate;

		public virtual System.Guid Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_Id = value;
			}
		}

		public virtual Paths Path
		{
			get
			{
				return _Path;
			}
			set
			{
				_Path = value;
			}
		}
		public virtual Users User
		{
			get
			{
				return _User;
			}
			set
			{
				_User = value;
			}
		}
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


		protected bool Equals(PersonalizationPerUser entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as PersonalizationPerUser);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
