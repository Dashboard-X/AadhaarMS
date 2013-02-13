using System;
using System.Collections.Generic;
using System.Text;

namespace Aadhaar.Data.ViewModel
{
   public class Permission
    {
       Entity.roleactions _base;

        #region Properties
        public int Id
        {
            get { return _base.Id; }
            set { _base.Id = value; }
        }
        public string Roles
        {
            get { return (_base.Role==null||string.IsNullOrEmpty(_base.Role.RoleName)) ? string.Empty : _base.Role.RoleName; }
            set { _base.Role.RoleName = value; }
        }
        public string Controller
        {
            get { return _base.Action.ControllerName; }
            set { _base.Action.ControllerName = value; }
        }
        public string Action
        {
            get { return _base.Action.ActionName; }
            set { _base.Action.ActionName = value; }
        }
        public string Users
        {
            get { return (_base.User==null||string.IsNullOrEmpty(_base.User.UserName))?string.Empty:_base.User.UserName; }
            set { _base.User.UserName = value; }
        }
        public int ControllerId
        {
            get;
            set;
        }

        public Guid UserId
        {
            get { return _base.User.Id; }
            set { _base.User.Id = value; }
        }
        public int PermissionType
        {
            get { return _base.PermissionType; }
            set { _base.PermissionType = value; }
        }

        #endregion Properties

        internal Permission(Entity.roleactions inputbase)
        {
            _base = new Entity.roleactions();
            _base.Role = new Entity.Roles();
            _base.User = new Entity.Users();
            _base.Action = new Entity.actions();
            _base.Id = inputbase.Id;
            _base.Role = inputbase.Role;
            _base.Action = inputbase.Action;
            _base.User = inputbase.User;
            _base.PermissionType = inputbase.PermissionType;
        }
        public Permission()
        {
            _base = new Entity.roleactions();
            _base.Role = new Entity.Roles();
            _base.User = new Entity.Users();
            _base.Action = new Entity.actions();
        }

        internal Entity.roleactions toRoleAction()
        {
            return _base;
        }
    }
}
