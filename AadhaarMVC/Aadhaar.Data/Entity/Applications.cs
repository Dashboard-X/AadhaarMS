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
	/// An object representation of the Applications table
	/// </summary>
	[Serializable]
	public class Applications
	{
		protected System.Guid _Id;

		private System.String _ApplicationName;
		private readonly ISet _FKaspnetRoAppli440B1D61 = new HashedSet();
		private readonly ISet _FKaspnetMeAppli21B6055D = new HashedSet();
		private System.String _LoweredApplicationName;
		private System.String _Description;
		private readonly ISet _FKaspnetUsAppli0DAF0CB05907 = new HashedSet();
		private readonly ISet _FKaspnetPaAppli5AEE82B90dad = new HashedSet();
		private readonly ISet _FKaspnetUsAppli0DAF0CB0590764fc = new HashedSet();

		public virtual System.String ApplicationName
		{
			get
			{
				return _ApplicationName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("ApplicationNameRequired", "ApplicationName must not be null.");
				}
				_ApplicationName = value;
			}
		}

		public virtual ISet FKaspnetRoAppli440B1D61
		{
			get
			{
				return _FKaspnetRoAppli440B1D61;
			}
		}

		public virtual ISet FKaspnetMeAppli21B6055D
		{
			get
			{
				return _FKaspnetMeAppli21B6055D;
			}
		}

		public virtual System.String LoweredApplicationName
		{
			get
			{
				return _LoweredApplicationName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("LoweredApplicationNameRequired", "LoweredApplicationName must not be null.");
				}
				_LoweredApplicationName = value;
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

		public virtual ISet FKaspnetUsAppli0DAF0CB05907
		{
			get
			{
				return _FKaspnetUsAppli0DAF0CB05907;
			}
		}

		public virtual ISet FKaspnetPaAppli5AEE82B90dad
		{
			get
			{
				return _FKaspnetPaAppli5AEE82B90dad;
			}
		}

		public virtual ISet FKaspnetUsAppli0DAF0CB0590764fc
		{
			get
			{
				return _FKaspnetUsAppli0DAF0CB0590764fc;
			}
		}


		protected bool Equals(Applications entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Applications);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
