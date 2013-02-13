using System;
using System.Collections.Generic;
using System.Text;
using Aadhaar.Data.Entity;

namespace Aadhaar.Data
{

    /// <summary>
    /// Helper Class for ADHPermissionsModule
    /// All "Controller+Actions(Folder\File.aspx)" Rules handled Here.
    /// </summary>
   public static class ADHSecurityHelper
    {
       /// <summary>
       /// Retrieves all the Permissions Set (for Super Admin USE)
       /// </summary>
       /// <returns></returns>
       public static IList<ViewModel.Permission> getAllPermissions()
       {
           IList<ViewModel.Permission> returnList = new List<ViewModel.Permission>();
           try
           {
                IList<roleactions> permlist = Helper.EntityHelper.ConvertToListOf<Aadhaar.Data.Entity.roleactions>(Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("roleactions.FindAll"));
               
               foreach (roleactions item in permlist)
               {
                   returnList.Add(new ViewModel.Permission(item));
               }
           }
           catch (Exception ex)
           {
               throw (ex);
           }
           return (returnList);
       }

       /// <summary>
       /// Deletes a particular Permission on the basis of Id
       /// </summary>
       /// <param name="Id">Permission Id to be deleted.</param>
       /// <returns></returns>
       public static int DeletePermission(int Id)
       {
           int result=0;
           try
           {
               roleactions ra = new roleactions();
               ra.Id = Id;
               Aadhaar.Data.Helper.NHibernateHelper.Delete(ra);

           }
           catch (Exception ex)
           {
               throw (ex);
           }
           return (result);
       }

       /// <summary>
       /// Create a Permission on the basis of input ViewModel.Permission Set
       /// Input Permission must have RoleName as the string input.Roles 
       /// and the Permission ID as input.ControllerId
       /// </summary>
       /// <param name="input"></param>
       public static void CreatePermission(ViewModel.Permission input)
       {

           try
           {
               //roleactions toCreate = input.toRoleAction();
               roleactions toCreate = new roleactions();
               if (!string.IsNullOrEmpty(input.Roles))
               {
                   toCreate.Role = Aadhaar.Data.Helper.EntityHelper.GetRole(input.Roles);
                   //toCreate.Users.Name = string.Empty;
               }
               else
               {
                   //toCreate.Roles.Name = string.Empty;
                   toCreate.User = Aadhaar.Data.Helper.EntityHelper.GetUser(input.Users);
               }

               toCreate.Action = (Aadhaar.Data.Helper.EntityHelper.ConvertToListOf<actions>(Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("actions.byId", input.ControllerId, NHibernate.NHibernateUtil.Int32)))[0]; //(actions)Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("", new object[] { input.Controller, input.Action }, new NHibernate.Type.IType[] { NHibernate.NHibernateUtil.String, NHibernate.NHibernateUtil.String })[0];
               
               //toCreate.Action.ActionName = input.Action;
               //toCreate.Action.ControllerName = input.Controller;
               toCreate.PermissionType = input.PermissionType;

               Aadhaar.Data.Helper.NHibernateHelper.Save(toCreate);
           }
           catch (Exception ex)
           {
               throw (ex);
           }
       }


       /// <summary>
       /// Retrieves list of all the locations configured for access control.
       /// If the location is not configured, the default Asp.Net Role Based security applies.
       /// </summary>
       /// <returns>List of ViewModel.Activities</returns>
       public static IList<ViewModel.Activities> getAllActions()
       {
           IList<ViewModel.Activities> resultList = new List<ViewModel.Activities>();

           try
           {
               IList<actions> actList = Helper.EntityHelper.ConvertToListOf<actions>(Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("actions.FindAll"));

                   foreach(actions item in actList)
                   {
                       resultList.Add(new ViewModel.Activities(item));
                   }
           }
           catch
           {
               throw;
           }
           return (resultList);
       }


       /// <summary>
       /// Retrieves the list of all the roles from Asp.Net Roles Database
       /// This method can be ommitted. Asp.Nets RoleProvider's Roles.GetAllRoles() can be used instead.
       /// </summary>
       /// <returns></returns>
       public static IList<ViewModel.DbEntity> getAllRoles()
       {
           IList<ViewModel.DbEntity> resultList = new List<ViewModel.DbEntity>();

           try
           {
               IList<Roles> actList = Helper.EntityHelper.ConvertToListOf<Roles>(Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("Roles.FindAll"));

               foreach (Roles item in actList)
               {
                   ViewModel.DbEntity tmp = new ViewModel.DbEntity();
                   tmp.Id = item.Id;
                   tmp.Name = item.RoleName;
                   tmp.Description = item.Description;
                   tmp.LoweredName = item.LoweredRoleName;

                   resultList.Add(tmp);
               }
           }
           catch
           {
               throw;
           }
           return (resultList);
       }

       /// <summary>
       /// Deletes a particular location (like Folder\File.aspx) on the basis of ID
       /// </summary>
       /// <param name="Id">Input Action Id for a particular location as configured into the Actions table.</param>
       /// <returns></returns>
       public static int DeleteAction(int Id)
       {
           int result = 0;
           try
           {
               actions act = new actions();
               act.Id = Id;

               Aadhaar.Data.Helper.NHibernateHelper.DeleteByNamedQuery("roleactions.byActionId", Id, NHibernate.NHibernateUtil.Int32);

               Aadhaar.Data.Helper.NHibernateHelper.DeleteById(typeof(actions),Id);

           }
           catch (Exception ex)
           {
               throw (ex);
           }
           return (result);
       }


       /// <summary>
       /// Creates an entry for the particular location (like Folder\File.aspx) to be configured for access control.
       /// ControllerName refers to the "Folder" name of the location
       /// Action Name refers to the "File" name of the location
       /// </summary>
       /// <param name="ControllerName">Folder Name for the location to be added (* No leading and trailing slashes("/")).</param>
       /// <param name="ActionName">File name of the resource to be added.</param>
       public static void CreateAction(string ControllerName, string ActionName)
       {

           try
           {
               actions toCreate = new actions();
               toCreate.ControllerName = ControllerName;
               toCreate.ActionName = ActionName;

               Aadhaar.Data.Helper.NHibernateHelper.Save(toCreate);
           }
           catch (Exception ex)
           {
               throw (ex);
           }
       }


/// <summary>
/// If the UserId has a UserLevel exclusive permission, returns the variable "HasUserPermission" as true.
/// Otherwise
/// Retrieves the list of Allowed roles for a particular location.
/// ControllerName refers to the "Folder" name of the location
/// Action Name refers to the "File" name of the location
/// </summary>
/// <param name="UserId">Input UserId to be tested</param>
/// <param name="HasUserPermission">Out Parameter to set if the User has a User Level Permission to a Location.</param>
/// <param name="controllerName">Folder Name</param>
/// <param name="actionName">File Name</param>
/// <returns>String array of Role Names Having exclusive access to the specified location.</returns>
       public static string[] GetRolesForControllerAction(string UserId, out bool HasUserPermission,string controllerName, string actionName)
       {
           string rslt = "";
           HasUserPermission = false;

           System.Collections.IList ra = getAction(controllerName, actionName);

            if (ra.Count != 0)
               for (int count1 = 0; count1 <= ra.Count - 1; count1++)
               {
                   if (((ra[count1] as roleactions).Role) != null)
                       rslt += (ra[count1] as roleactions).Role.RoleName;
                   else if ((((ra[count1] as roleactions).User) != null) && (string.Equals(UserId, ((ra[count1] as roleactions).User).UserName, StringComparison.InvariantCultureIgnoreCase)))
                   { HasUserPermission = true;}

                   if (count1 != ra.Count - 1)
                       rslt += ",";
               }

           return (rslt.Split(','));
       }


       #region Action
       /// <summary>
       /// Retrieves an action on the basis of ControllerName + Action Name
       /// ControllerName refers to the "Folder" name of the location
       /// Action Name refers to the "File" name of the location
       /// </summary>
       /// <param name="controllerName">Folder Name</param>
       /// <param name="actionName">File Name</param>
       /// <returns></returns>
       private static System.Collections.IList getAction(string controllerName, string actionName)
       {
           // Get the role record from the data store.
           try
           {
                System.Collections.IList acts = Aadhaar.Data.Helper.NHibernateHelper.FindByNamedQuery("roleactions.byControllerAndActionNames", new object[] { controllerName, actionName }, new NHibernate.Type.IType[] { NHibernate.NHibernateUtil.String, NHibernate.NHibernateUtil.String });
               return (acts);
           }
           catch (Exception ex)
           {
               throw new Exception(Aadhaar.Data.Properties.Resources.Role_UnableToGet, ex);
           }
       }
       #endregion Action
     
    }
}
