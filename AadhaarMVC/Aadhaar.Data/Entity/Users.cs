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
	/// An object representation of the Users table
	/// </summary>
	[Serializable]
	public class Users
	{
		protected System.Guid _Id;

		private Applications _Application;
		private readonly ISet _FKaspnetPeUserI693CA210 = new HashedSet();
		private readonly ISet _FKroleactionsusers = new HashedSet();
		private System.String _UserName;
		private System.String _LoweredUserName;
		private System.String _MobileAlias;
		private System.Boolean _IsAnonymous;
		private System.DateTime _LastActivityDate;
		private readonly ISet _FKaspnetUsUserI49C3F6B7 = new HashedSet();

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
		public virtual ISet FKaspnetPeUserI693CA210
		{
			get
			{
				return _FKaspnetPeUserI693CA210;
			}
		}

		public virtual ISet FKroleactionsusers
		{
			get
			{
				return _FKroleactionsusers;
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

		public virtual System.String UserName
		{
			get
			{
				return _UserName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("UserNameRequired", "UserName must not be null.");
				}
				_UserName = value;
			}
		}

		public virtual System.String LoweredUserName
		{
			get
			{
				return _LoweredUserName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("LoweredUserNameRequired", "LoweredUserName must not be null.");
				}
				_LoweredUserName = value;
			}
		}

		public virtual System.String MobileAlias
		{
			get
			{
				return _MobileAlias;
			}
			set
			{
				_MobileAlias = value;
			}
		}

		public virtual System.Boolean IsAnonymous
		{
			get
			{
				return _IsAnonymous;
			}
			set
			{
				_IsAnonymous = value;
			}
		}

		public virtual System.DateTime LastActivityDate
		{
			get
			{
				return _LastActivityDate;
			}
			set
			{
				_LastActivityDate = value;
			}
		}

		public virtual ISet FKaspnetUsUserI49C3F6B7
		{
			get
			{
				return _FKaspnetUsUserI49C3F6B7;
			}
		}


		protected bool Equals(Users entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Users);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
