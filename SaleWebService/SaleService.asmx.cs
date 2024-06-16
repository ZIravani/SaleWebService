using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;

namespace TestWebService
{
    /// <summary>
    /// Summary description for SaleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class SaleService : System.Web.Services.WebService
    {

     

        [WebMethod]
        public DataSet SelectCustomer(string User,int Pass, string WebUser)
        {

            DataSet ds1 = DataLayer.WebCustomer.SelectCostomerRow(WebUser);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public void InsertCustomer(string User, int Pass, string CstmName, string CstmEcNo, string CstmAddress, 
            string CstmTelNo, string CstmFax, string CstmEmail, string CstmDesc, string FactoryPhone, string FactoryFax, 
            string FactoryAdd, string WebSiteAdd, string City, string CstmFullName, string CstmRabet, string CstmMobile, 
            string CstmSabtNo, string MeliCode, string PostCode, string Province, string PerNumber, string WebUser)
        {

            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.InsertRow(CstmName, CstmEcNo, CstmAddress, CstmTelNo, CstmFax, CstmEmail, CstmDesc,  FactoryPhone, FactoryFax, FactoryAdd, WebSiteAdd, City, CstmFullName, CstmRabet, CstmMobile, CstmSabtNo, MeliCode, PostCode, Province, PerNumber, WebUser);
        }

       

        [WebMethod]
        public void UpdateCustomer(string User, int Pass, string CstmName, string CstmEcNo, string CstmAddress, 
            string CstmTelNo, string CstmFax, string CstmEmail, string CstmDesc, string FactoryPhone, 
            string FactoryFax, string FactoryAdd, string WebSiteAdd, string City, string CstmFullName, 
            string CstmRabet, string CstmMobile, string CstmSabtNo, string MeliCode, string PostCode, 
            string Province, string PerNumber, string WebUser)
        {

            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.UpdateRow(CstmName, CstmEcNo, CstmAddress, CstmTelNo, CstmFax, CstmEmail, CstmDesc, FactoryPhone, FactoryFax, FactoryAdd, WebSiteAdd, City, CstmFullName, CstmRabet, CstmMobile, CstmSabtNo, MeliCode, PostCode, Province, PerNumber, WebUser);
           
          
        }




        //Sadegh Beigi:

        [WebMethod]
        public void InsertRequest(string User, int Pass, string WebUser, string RequestDate, long RequestValue, string RequestDesc, int Fk_ProdTypeSale)
        {
            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.WebInsertRequest(WebUser, RequestDate, RequestValue, RequestDesc, Fk_ProdTypeSale);
        }

        [WebMethod]
        public DataSet SelectProduct(string User, int Pass, string WebUser)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebSelectProduct(WebUser);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public DataSet SelectAllHavaleh(string User, int Pass, int IsActive, string WebUser)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebSelectAllHavaleh(IsActive, WebUser);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public DataSet SelectHavaleh(string User, int Pass, int Pk_havaleh)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebSelectHavaleh(Pk_havaleh);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public DataSet SelectHavalehLoading(string User, int Pass, int Pk_Havaleh)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebSelectHavalehLoading(Pk_Havaleh);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public DataSet PrintPishFactor(string User, int Pass, int Pk_Havaleh)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebPrintPishFactor(Pk_Havaleh);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public DataSet PrintHavaleh(string User, int Pass, int Pk_Havaleh)
        {
            DataSet ds1 = DataLayer.WebCustomer.WebPrintHavaleh(Pk_Havaleh);
            if ((User == "admin") && (Pass == 489752))
                return ds1;
            else
                return null;
        }

        [WebMethod]
        public void InternetPayment(string User, int Pass, int Pk_Havaleh, string Fname, string Lname, string TelNo, string MobileNo, string Email)
        {
            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.WebInternetPayment(Pk_Havaleh, Fname, Lname, TelNo, MobileNo, Email);
        }

        [WebMethod]
        public void ManualPayment(string User, int Pass, int Pk_Havaleh, string PicURL)
        {
            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.WebManualPayment(Pk_Havaleh, PicURL);
        }

        [WebMethod]
        public void  CustomerIsOk(string User, int Pass, string WebUser)
        {
            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.WebCustomerIsOk(WebUser);
        }

        [WebMethod]
        public void InsertCustomerIRVN(string User, int Pass, string Name, string WebUser, string Question)
        {

            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.InsertRowTestWeb(Name, WebUser, Question);
        }

        [WebMethod]
        public void UpdateActiveUser(string User, int Pass, string WebUser)
        {

            if ((User == "admin") && (Pass == 489752))
                DataLayer.WebCustomer.Update_ActiveUser(WebUser);


        }
    }
}
