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
	/// An object representation of the WebEvent_Events table
	/// </summary>
	[Serializable]
	public class WebEvent_Events
	{
		protected System.String _Id;

		private System.DateTime _EventTimeUtc;
		private System.DateTime _EventTime;
		private System.String _EventType;
		private System.Decimal _EventSequence;
		private System.Decimal _EventOccurrence;
		private System.Int32 _EventCode;
		private System.Int32 _EventDetailCode;
		private System.String _Message;
		private System.String _ApplicationPath;
		private System.String _ApplicationVirtualPath;
		private System.String _MachineName;
		private System.String _RequestUrl;
		private System.String _ExceptionType;
		private string _Details;

		public virtual System.String Id
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

		public virtual System.DateTime EventTimeUtc
		{
			get
			{
				return _EventTimeUtc;
			}
			set
			{
				_EventTimeUtc = value;
			}
		}

		public virtual System.DateTime EventTime
		{
			get
			{
				return _EventTime;
			}
			set
			{
				_EventTime = value;
			}
		}

		public virtual System.String EventType
		{
			get
			{
				return _EventType;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("EventTypeRequired", "EventType must not be null.");
				}
				_EventType = value;
			}
		}

		public virtual System.Decimal EventSequence
		{
			get
			{
				return _EventSequence;
			}
			set
			{
				_EventSequence = value;
			}
		}

		public virtual System.Decimal EventOccurrence
		{
			get
			{
				return _EventOccurrence;
			}
			set
			{
				_EventOccurrence = value;
			}
		}

		public virtual System.Int32 EventCode
		{
			get
			{
				return _EventCode;
			}
			set
			{
				_EventCode = value;
			}
		}

		public virtual System.Int32 EventDetailCode
		{
			get
			{
				return _EventDetailCode;
			}
			set
			{
				_EventDetailCode = value;
			}
		}

		public virtual System.String Message
		{
			get
			{
				return _Message;
			}
			set
			{
				_Message = value;
			}
		}

		public virtual System.String ApplicationPath
		{
			get
			{
				return _ApplicationPath;
			}
			set
			{
				_ApplicationPath = value;
			}
		}

		public virtual System.String ApplicationVirtualPath
		{
			get
			{
				return _ApplicationVirtualPath;
			}
			set
			{
				_ApplicationVirtualPath = value;
			}
		}

		public virtual System.String MachineName
		{
			get
			{
				return _MachineName;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("MachineNameRequired", "MachineName must not be null.");
				}
				_MachineName = value;
			}
		}

		public virtual System.String RequestUrl
		{
			get
			{
				return _RequestUrl;
			}
			set
			{
				_RequestUrl = value;
			}
		}

		public virtual System.String ExceptionType
		{
			get
			{
				return _ExceptionType;
			}
			set
			{
				_ExceptionType = value;
			}
		}

		public virtual string Details
		{
			get
			{
				return _Details;
			}
			set
			{
				_Details = value;
			}
		}


		protected bool Equals(WebEvent_Events entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as WebEvent_Events);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
