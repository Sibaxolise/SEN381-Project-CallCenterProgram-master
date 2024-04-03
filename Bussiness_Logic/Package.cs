using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
{
    class Package
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private string packageName;
        private string services;
        private string serviceLevels;
        private int packageID;

        public Package(string packageName, string services, string serviceLevels, int packageID)
        {
            this.packageName = packageName;
            this.services = services;
            this.serviceLevels = serviceLevels;
            this.packageID = packageID;
        }

        public Package()
        {
        }

        public string PackageName { get => packageName; set => packageName = value; }
        public string Services { get => services; set => services = value; }
        public string ServiceLevels { get => serviceLevels; set => serviceLevels = value; }
        public int PackageID { get => packageID; set => packageID = value; }

        public void AddPackage(string packageName, string serviceIDs, string serviceLevelIDs)
        {
            dataAccess.InsertPackage(packageName, serviceIDs, serviceLevelIDs);
        }

        public void UpdatePackage(int packageId, string packageName, string serviceIDs, string serviceLevelIDs)
        {
            dataAccess.UpdatePackage(packageId, packageName, serviceIDs, serviceLevelIDs);
        }

        public int PackagesInLast30Days()
        {
            return dataAccess.GetNumberCurrentTotalPackagesInLast30Days();
        }
        public List<Bussiness_Logic.Package> BestPackageOrPackagesOfTheMonth()
        {
            int mostSelling = dataAccess.BestPackageOrPackagesOfTheMonthQuantity();
            return dataAccess.BestPackagesDetails(mostSelling);
        }
        public int MostSoldPackageQuantity()
        {
            return dataAccess.BestPackageOrPackagesOfTheMonthQuantity();
        }
        public List<string> PackagePerfromance(int packageID)
        {
            return dataAccess.PackagePerfromance(packageID);
        }
    }
}
