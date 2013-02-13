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
	/// An object representation of the Paths table
	/// </summary>
	[Serializable]
	public class Paths
	{
		protected System.Guid _Id;

		private readonly ISet _FKaspnetPePathI68487DD7 = new HashedSet();
		private Applications _Application;
		private System.String _Path;
		private System.String _LoweredPath;

		public virtual ISet FKaspnetPePathI68487DD7
		{
			get
			{
				return _FKaspnetPePathI68487DD7;
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

		public virtual System.String Path
		{
			get
			{
				return _Path;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("PathRequired", "Path must not be null.");
				}
				_Path = value;
			}
		}

		public virtual System.String LoweredPath
		{
			get
			{
				return _LoweredPath;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("LoweredPathRequired", "LoweredPath must not be null.");
				}
				_LoweredPath = value;
			}
		}


		protected bool Equals(Paths entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Paths);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
