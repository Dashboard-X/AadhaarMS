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
	/// An object representation of the Profile table
	/// </summary>
	[Serializable]
	public class Profile : Users
	{

		private string _PropertyNames;
		private string _PropertyValuesString;
		private Byte[] _PropertyValuesBinary;
		private System.DateTime _LastUpdatedDate;

		public virtual string PropertyNames
		{
			get
			{
				return _PropertyNames;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("PropertyNamesRequired", "PropertyNames must not be null.");
				}
				_PropertyNames = value;
			}
		}

		public virtual string PropertyValuesString
		{
			get
			{
				return _PropertyValuesString;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("PropertyValuesStringRequired", "PropertyValuesString must not be null.");
				}
				_PropertyValuesString = value;
			}
		}

		public virtual Byte[] PropertyValuesBinary
		{
			get
			{
				return _PropertyValuesBinary;
			}
			set
			{
				_PropertyValuesBinary = value;
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


		protected bool Equals(Profile entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Profile);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
