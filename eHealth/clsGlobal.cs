using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHealth.Model;
using eHealth.BusinessLogic;

namespace eHealth
{
    public static class eHealthGlobal
    {
        public static string ConnectionString {get;set;}
        public static clsRole globalUserRole;
        public static ClsUserLoging globalUser;
        public static string gBarcodePatientType = string.Empty;
        public static string ProductVersion;

        public static string globalFacilityId;
        public static string globalFacilityPassword;
        public static string globalSQLConnection;
        public static string globalSenderId;


        public static string globalLoginLocation;

        public static string globalEAuth;

        public static string facilityId;
        public static string facilityPassword;
        public static string Dispositionflag;

    }
}
