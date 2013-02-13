using System;
using System.Collections.Generic;
using System.ComponentModel;
using Iesi.Collections;
////using Iesi.Collections.Generic;
using Aadhaar.Data.Entity.Components;


using Aadhaar.Data.Entity;

namespace Aadhaar.Data.Entity 
{    
	/// <summary>
	/// An object representation of the UsersInRoles table
	/// </summary>
	[Serializable]
	public class UsersInRoles
	{
		protected PairIdComponent _Id;

		private Users _User;
		private Roles _Role;

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

		public virtual PairIdComponent Id
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

		public virtual Roles Role
		{
			get
			{
				return _Role;
			}
			set
			{
				_Role = value;
			}
		}


		protected bool Equals(UsersInRoles entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as UsersInRoles);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
