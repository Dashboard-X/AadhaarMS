using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace Aadhaar.MVC.Controllers
{
    public class AdminController : Controller
    {


        public ActionResult Users()
        {
            int totalRecords = 0;
            //ViewBag["totalRecords"] = totalRecords;
            MembershipUserCollection uList = Membership.GetAllUsers(0, 10, out totalRecords);

            List<Models.UsersModel> dispList = new List<Models.UsersModel>();

            foreach (MembershipUser usr in uList)
            {
                dispList.Add(new Models.UsersModel().FromMembershipUser(usr));
            }

            ViewData["userList"] = dispList;

            return View();
        }

        

        #region Users & Roles
        ////[Authorize(Roles = "Administrator")]
        //public ActionResult Users()
        //{
        //    int totalRecords = 0;
        //    //ViewBag["totalRecords"] = totalRecords;
        //    MembershipUserCollection uList = Membership.GetAllUsers(0, 10, out totalRecords);

        //    List<Models.UsersModel> dispList = new List<Models.UsersModel>();

        //    foreach (MembershipUser usr in uList)
        //    {
        //        dispList.Add(new Models.UsersModel().FromMembershipUser(usr));
        //    }

        //    return View(dispList);
        //}

        public ActionResult UserDetails(Guid id)
        {
            Models.UsersModel model;

                model = (new Models.UsersModel()).FromMembershipUser(Membership.GetUser(id));
                model.roles = Roles.GetRolesForUser(model.name);

               
            ViewData["allRoles"] = Roles.GetAllRoles();
            ViewData["CurrenUser"] = model;
            
            return View();
        }

        [HttpPost]
        public ActionResult ResetUserPass(FormCollection collection)
        {
            if (string.IsNullOrEmpty(collection["txtAddRoleName"]))
            { TempData["message"] = "Role Name cannot be null."; return RedirectToAction("EditRoles"); }

            try
            {
                // TODO: Add insert logic here
                TempData["message"] = "Required Role Name is added now";
                //Aadhaar.Data.ADHSecurityHelper.CreateAction(collection["ControllerName"], collection["ActionName"]);
                Roles.CreateRole(collection["txtAddRoleName"]);
                return RedirectToAction("EditRoles");
            }
            catch
            {
                return RedirectToAction("EditRoles");
            }
        }

        //[Authorize(Roles = "Administrator")]
        public ActionResult EditRoles()
        {
            ViewData["roleList"] = Roles.GetAllRoles();

            return View();
        }


        public ActionResult DeleteRole(string roleName)
        {
            try
            {
                if (roleName != "Super Admin")
                {
                    Roles.DeleteRole(roleName);
                    TempData["message"] = "Requested Role is deleted now";
                }
                else { TempData["message"] = "Super Admin role cannot be deleted."; }
            }
            catch
            {
                throw;
            }

            return (RedirectToAction("EditRoles"));
        }

        [HttpPost]
        public ActionResult AddRole(FormCollection collection)
        {
            if (string.IsNullOrEmpty(collection["txtAddRoleName"]))
            { TempData["message"] = "Role Name cannot be null."; return RedirectToAction("EditRoles"); }

            try
            {
                // TODO: Add insert logic here
                TempData["message"] = "Required Role Name is added now";
                //Aadhaar.Data.ADHSecurityHelper.CreateAction(collection["ControllerName"], collection["ActionName"]);
                Roles.CreateRole(collection["txtAddRoleName"]);
                return RedirectToAction("EditRoles");
            }
            catch
            {
                return RedirectToAction("EditRoles");
            }
        }

        [HttpPost]
        public ActionResult RemoveUserRole(FormCollection collection)
        {
            string UsrKey = collection["hdnUserKy"];
            string UsrName = collection["hdnUsrName"];
            string RoleName = collection["hdnRoleNm"];

            if (RoleName == "Super Admin")
            {
                TempData["message"] = "User: " + UsrName + " cannot be removed from the role: " + RoleName;
                return RedirectToAction("UserDetails", new { id = UsrKey });
            }

            Roles.RemoveUserFromRole(UsrName, RoleName);

            TempData["message"] = "User: " + UsrName + " is now removed from the role: " + RoleName;
            return RedirectToAction("UserDetails", new { id = UsrKey });
        }

        [HttpPost]
        public ActionResult AddUserRole(FormCollection collection)
        {
            string UsrKey = collection["hdnUserKy"];
            string UsrName = collection["hdnUsrName"];
            string RoleName = collection["hdnRoleNm"];

            Roles.AddUserToRole(UsrName, RoleName);

            TempData["message"] = "User: " + UsrName + " has been assigned to the role: " + RoleName;
            return RedirectToAction("UserDetails", new { id = UsrKey });
        }
        //
        // GET: /Admin/Details/5

        #endregion Users & Roles

        #region Permission Rules

        public ActionResult Permissions()
        {
            Models.Permissions perm = new Models.Permissions();




            //  IEnumerable<Aadhaar.Data.Entity.RoleActions> rslt;
            try
            {
                string[] roles = Roles.GetAllRoles();

                for (int count1 = 0; count1 <= roles.Length - 1; count1++)
                {
                    perm.rolesList.Add(new SelectListItem { Text = roles[count1], Value = roles[count1] });
                }

                perm.actionsList = Aadhaar.Data.ADHSecurityHelper.getAllActions();
                perm.permissionsList = Aadhaar.Data.ADHSecurityHelper.getAllPermissions();

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            if (TempData["message"] != null)
            {
                ModelState.AddModelError("", TempData["message"].ToString());
            }

            return View(perm);
        }

        public ActionResult UserLogs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Permissions(Models.Permissions model)
        {
            // Models.Permissions model = new Models.Permissions();

            Aadhaar.Data.ViewModel.Permission toCreate = new Aadhaar.Data.ViewModel.Permission();






            //  IEnumerable<Aadhaar.Data.Entity.RoleActions> rslt;

            try
            {

                model.actionsList = Aadhaar.Data.ADHSecurityHelper.getAllActions();

                //if (string.IsNullOrEmpty(collection["selectedRoleName"]))
                //{
                //    throw new Exception("Please Select a Role First.");
                //}
                //else
                //{
                //    toCreate.Roles = collection["selectedRoleName"];
                //}

                //if (collection["selectedActionId"] == "-1")
                //{
                //    throw new Exception("Please Select An Action - Controller.");
                //}

                if (string.IsNullOrEmpty(model.selectedRoleName))
                {
                    throw new Exception("Please Select a Role First.");
                }
                else
                {
                    toCreate.Roles = model.selectedRoleName;
                }

                if (model.selectedActionId == -1)
                {
                    throw new Exception("Please Select An Action - Controller.");
                }
                else
                {

                    foreach (Aadhaar.Data.ViewModel.Activities item in model.actionsList)
                    {
                        if (item.Id == model.selectedActionId)
                        {
                            toCreate.Controller = item.ControllerName;
                            toCreate.Action = item.ActionName;
                            toCreate.ControllerId = item.Id;
                        }
                    }
                }



                toCreate.PermissionType = 0;

                //Creating permission Now
                Aadhaar.Data.ADHSecurityHelper.CreatePermission(toCreate);
                TempData["message"] = "The Requested Role Based Permission Rule is Created now";

            }
            catch (Exception ex)
            {
                TempData["message"] = "Oops. We got and Error:-" + ex.Message + ex.StackTrace;
            }
            finally
            {
                string[] roles = Roles.GetAllRoles();

                for (int count1 = 0; count1 <= roles.Length - 1; count1++)
                {
                    model.rolesList.Add(new SelectListItem { Text = roles[count1], Value = roles[count1] });
                }

                model.permissionsList = Aadhaar.Data.ADHSecurityHelper.getAllPermissions();

            }

            
            return RedirectToAction("Permissions");

        }

       
        [HttpPost]
        public ActionResult UserPermission(Models.Permissions model)
        {
            // Models.Permissions model = new Models.Permissions();

            Aadhaar.Data.ViewModel.Permission toCreate = new Aadhaar.Data.ViewModel.Permission();







            //  IEnumerable<Aadhaar.Data.Entity.RoleActions> rslt;

            try
            {

                model.actionsList = Aadhaar.Data.ADHSecurityHelper.getAllActions();

                //if (string.IsNullOrEmpty(collection["selectedRoleName"]))
                //{
                //    throw new Exception("Please Select a Role First.");
                //}
                //else
                //{
                //    toCreate.Roles = collection["selectedRoleName"];
                //}

                //if (collection["selectedActionId"] == "-1")
                //{
                //    throw new Exception("Please Select An Action - Controller.");
                //}

                if (string.IsNullOrEmpty(model.selectedUserId))
                {
                    throw new Exception("Please Enter a User Id First.");
                }
                else if (((MembershipUser)Membership.GetUser(model.selectedUserId)) == null)
                {
                    throw new Exception("User Not Found. Please select another User.");
                }
                else
                {
                    toCreate.Users = model.selectedUserId;
                }

                if (model.selectedActionIdUser == null)
                {
                    throw new Exception("Please Select An Action - Controller.");
                }
                else
                {

                    foreach (Aadhaar.Data.ViewModel.Activities item in model.actionsList)
                    {
                        if (item.Id == model.selectedActionIdUser)
                        {
                            toCreate.Controller = item.ControllerName;
                            toCreate.Action = item.ActionName;
                            toCreate.ControllerId = item.Id;
                        }
                    }
                }



                toCreate.PermissionType = 0;

                //Creating permission Now
                Aadhaar.Data.ADHSecurityHelper.CreatePermission(toCreate);
                TempData["message"] = "The Requested User Based Permission Rule is Created now";
            }
            catch (Exception ex)
            {
                TempData["message"] = "Oops. We got and Error:-" + ex.Message + ex.StackTrace;
            }
            finally
            {
                string[] roles = Roles.GetAllRoles();

                for (int count1 = 0; count1 <= roles.Length - 1; count1++)
                {
                    model.rolesList.Add(new SelectListItem { Text = roles[count1], Value = roles[count1] });
                }

                model.permissionsList = Aadhaar.Data.ADHSecurityHelper.getAllPermissions();

            }

            return RedirectToAction("Permissions");

        }

        [HttpPost]
        public ActionResult DeletePermission(FormCollection collection)
        {

            try
            {
                int id = int.Parse(collection["hdnPermId"]);
                Aadhaar.Data.ADHSecurityHelper.DeletePermission(id);
                TempData["message"] = "Requested permission is deleted now";
            }
            catch
            {
                throw;
            }

            return (RedirectToAction("Permissions"));
        }

        [HttpPost]
        public ActionResult AddAction(FormCollection collection)
        {
            if ((string.IsNullOrEmpty(collection["ControllerName"])) || (string.IsNullOrEmpty(collection["ActionName"])))
            { TempData["message"] = "ControllerName and ActionName cannot be null."; return RedirectToAction("Permissions"); }

            try
            {
                // TODO: Add insert logic here
                TempData["message"] = "Required Controller Action is added now";
                Aadhaar.Data.ADHSecurityHelper.CreateAction(collection["ControllerName"], collection["ActionName"]);

            }
            catch
            {
                throw;
            }
            return RedirectToAction("Permissions");
        }

        [HttpPost]
        public ActionResult DeleteAction(FormCollection collection)
        {
            try
            {
                int id = int.Parse(collection["hdnActionId"]);
                Aadhaar.Data.ADHSecurityHelper.DeleteAction(id);
                TempData["message"] = "Requested Action is deleted now";
            }
            catch
            {
                throw;
            }

            return (RedirectToAction("Permissions"));
        }

        #endregion Permission Rules

        #region Basic CRUD

        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion Basic CRUD
    }
}
