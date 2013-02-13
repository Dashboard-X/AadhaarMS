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
	/// An object representation of the SchemaVersions table
	/// </summary>
	[Serializable]
	public class SchemaVersions
	{
		protected PairIdComponent _Id;

		private System.String _Feature;
		private System.String _CompatibleSchemaVersion;
		private System.Boolean _IsCurrentVersion;

		public virtual System.String Feature
		{
			get
			{
				return _Feature;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("FeatureRequired", "Feature must not be null.");
				}
				_Feature = value;
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

		public virtual System.String CompatibleSchemaVersion
		{
			get
			{
				return _CompatibleSchemaVersion;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("CompatibleSchemaVersionRequired", "CompatibleSchemaVersion must not be null.");
				}
				_CompatibleSchemaVersion = value;
			}
		}

		public virtual System.Boolean IsCurrentVersion
		{
			get
			{
				return _IsCurrentVersion;
			}
			set
			{
				_IsCurrentVersion = value;
			}
		}


		protected bool Equals(SchemaVersions entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as SchemaVersions);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
