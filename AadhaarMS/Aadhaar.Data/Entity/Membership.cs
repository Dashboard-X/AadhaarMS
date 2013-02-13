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
	/// An object representation of the Membership table
	/// </summary>
	[Serializable]
	public class Membership : Users
	{

		private Applications _Application;
		private System.String _Password;
		private System.Int32 _PasswordFormat;
		private System.String _PasswordSalt;
		private System.String _MobilePIN;
		private System.String _Email;
		private System.String _LoweredEmail;
		private System.String _PasswordQuestion;
		private System.String _PasswordAnswer;
		private System.Boolean _IsApproved;
		private System.Boolean _IsLockedOut;
		private System.DateTime _CreateDate;
		private System.DateTime _LastLoginDate;
		private System.DateTime _LastPasswordChangedDate;
		private System.DateTime _LastLockoutDate;
		private System.Int32 _FailedPasswordAttemptCount;
		private System.DateTime _FailedPasswordAttemptWindowStart;
		private System.Int32 _FailedPasswordAnswerAttemptCount;
		private System.DateTime _FailedPasswordAnswerAttemptWindowStart;
		private string _Comment;

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
		public virtual System.String Password
		{
			get
			{
				return _Password;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("PasswordRequired", "Password must not be null.");
				}
				_Password = value;
			}
		}

		public virtual System.Int32 PasswordFormat
		{
			get
			{
				return _PasswordFormat;
			}
			set
			{
				_PasswordFormat = value;
			}
		}

		public virtual System.String PasswordSalt
		{
			get
			{
				return _PasswordSalt;
			}
			set
			{
				if (value == null)
				{
					throw new BusinessException("PasswordSaltRequired", "PasswordSalt must not be null.");
				}
				_PasswordSalt = value;
			}
		}

		public virtual System.String MobilePIN
		{
			get
			{
				return _MobilePIN;
			}
			set
			{
				_MobilePIN = value;
			}
		}

		public virtual System.String Email
		{
			get
			{
				return _Email;
			}
			set
			{
				_Email = value;
			}
		}

		public virtual System.String LoweredEmail
		{
			get
			{
				return _LoweredEmail;
			}
			set
			{
				_LoweredEmail = value;
			}
		}

		public virtual System.String PasswordQuestion
		{
			get
			{
				return _PasswordQuestion;
			}
			set
			{
				_PasswordQuestion = value;
			}
		}

		public virtual System.String PasswordAnswer
		{
			get
			{
				return _PasswordAnswer;
			}
			set
			{
				_PasswordAnswer = value;
			}
		}

		public virtual System.Boolean IsApproved
		{
			get
			{
				return _IsApproved;
			}
			set
			{
				_IsApproved = value;
			}
		}

		public virtual System.Boolean IsLockedOut
		{
			get
			{
				return _IsLockedOut;
			}
			set
			{
				_IsLockedOut = value;
			}
		}

		public virtual System.DateTime CreateDate
		{
			get
			{
				return _CreateDate;
			}
			set
			{
				_CreateDate = value;
			}
		}

		public virtual System.DateTime LastLoginDate
		{
			get
			{
				return _LastLoginDate;
			}
			set
			{
				_LastLoginDate = value;
			}
		}

		public virtual System.DateTime LastPasswordChangedDate
		{
			get
			{
				return _LastPasswordChangedDate;
			}
			set
			{
				_LastPasswordChangedDate = value;
			}
		}

		public virtual System.DateTime LastLockoutDate
		{
			get
			{
				return _LastLockoutDate;
			}
			set
			{
				_LastLockoutDate = value;
			}
		}

		public virtual System.Int32 FailedPasswordAttemptCount
		{
			get
			{
				return _FailedPasswordAttemptCount;
			}
			set
			{
				_FailedPasswordAttemptCount = value;
			}
		}

		public virtual System.DateTime FailedPasswordAttemptWindowStart
		{
			get
			{
				return _FailedPasswordAttemptWindowStart;
			}
			set
			{
				_FailedPasswordAttemptWindowStart = value;
			}
		}

		public virtual System.Int32 FailedPasswordAnswerAttemptCount
		{
			get
			{
				return _FailedPasswordAnswerAttemptCount;
			}
			set
			{
				_FailedPasswordAnswerAttemptCount = value;
			}
		}

		public virtual System.DateTime FailedPasswordAnswerAttemptWindowStart
		{
			get
			{
				return _FailedPasswordAnswerAttemptWindowStart;
			}
			set
			{
				_FailedPasswordAnswerAttemptWindowStart = value;
			}
		}

		public virtual string Comment
		{
			get
			{
				return _Comment;
			}
			set
			{
				_Comment = value;
			}
		}


		protected bool Equals(Membership entity)
		{
			if (entity == null) return false;
			if (!base.Equals(entity)) return false;
			if (!Equals(_Id, entity._Id)) return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj as Membership);
		}

		public override int GetHashCode()
		{
			int result = base.GetHashCode();
			result = 29*result + _Id.GetHashCode();
			return result;
		}

	}
}
