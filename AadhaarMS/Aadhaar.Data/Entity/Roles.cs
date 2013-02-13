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
	/// An object representation of the Roles table
	/// </summary>
	[Serializable]
	public class Roles
	{
		protected System.Guid _Id;

		private readonly ISet _FKroleactionsroles = new HashedSet();
		private Applications _Application;
		private System.String _RoleName;
		private System.String _LoweredRoleName;
		private System.String _Description;
		private readonly ISet _FKaspnetUsRoleI4AB81AF0 = new HashedSet();

		public virtual ISet FKroleactionsroles
		{
			get
			{
				return _FKroleactionsroles;
			}
		}

		public virtual Applications Application
		{
			get
			{
				return _Application;
			}
			set
			{
				_Application = value;
			}
		}
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

		public virtual System.String RoleName
		{
			get
			{
				return _RoleName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("RoleNameRequired", "RoleName must not be null.");
				}
				_RoleName = value;
			}
		}

		public virtual System.String LoweredRoleName
		{
			get
			{
				return _LoweredRoleName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("LoweredRoleNameRequired", "LoweredRoleName must not be null.");
				}
				_LoweredRoleName = value;
			}
		}

		public virtual System.String Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}

		public virtual ISet FKaspnetUsRoleI4AB81AF0
		{
			get
			{
				return _FKaspnetUsRoleI4AB81AF0;
			}
		}


		protected bool Equals(Roles entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Roles);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
