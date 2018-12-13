using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.BL.Common
{
    public class GlobalDecleration
    {
        #region message formats

        public static string _internalServerError = "Something went wrong.";
        public static string _alreadyExits = "Already Exits! Please try with different";
        public static string _savedSuccesfully = "Successfully Saved.";
        public static string _uploadedSuccesfully = "Successfully Uploaded.";
        public static string _uploadError = "Unable to upload the file. Please try again shortly.";
        public static string _iTServiceRequestNotFoundError = "IT Service Request not found.";
        public static string _requesterDepartmentAvailablity = "Requester Department is needed to proceed for approvals.";
        public static string _wftemplateNotFound = "Sorry, No Workflow template is assign to this condition.";
        public static string _wftemplateConfigurationError = "Workflow configuration or approval mapping is incorrect.";

        internal static string _encryptionSalt = "toguniversalcreditapprovalsystem";

        #endregion

        #region User Profile Properties
        public static string _userDepartment = "Department";
        public static string _userDesignation = "SPS-JobTitle";
        #endregion

        #region Workflow Product Name
        public static string _OnlineDocApproval = "Online Document Approval";
        #endregion
    }
}