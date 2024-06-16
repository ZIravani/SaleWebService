using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using NovinMedia.Data;

namespace DataLayer
{
    [DataObject(true)]
    public class WebCustomer
    {
		[DataObjectMethod(DataObjectMethodType.Fill)]
		public static DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_WebCustomer_SelectAll", parameters, "WebCustomer");
        }

		[DataObjectMethod(DataObjectMethodType.Fill)]
		public static DataSet SelectCostomerRow(string WebUser)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("WebUser",WebUser) 
                };
            return dbo.RunProcedure("WebCustomer_SelectRow", parameters, "WebCustomer");
        }

		[DataObjectMethod(DataObjectMethodType.Insert)]
		public static int InsertRow(string CstmName,string CstmEcNo,string CstmAddress,string CstmTelNo,string CstmFax,
            string CstmEmail,string CstmDesc,string FactoryPhone,
            string FactoryFax,string FactoryAdd,string WebSiteAdd,string City,string CstmFullName,
            string CstmRabet,string CstmMobile,string CstmSabtNo,string MeliCode,string PostCode,
            string Province,string PerNumber,string WebUser)
		{
			int RowsAffected = 0;
			int Result = 0;
			DbObject dbo = new DbObject();
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("CstmName",CstmName),
					new SqlParameter("CstmEcNo",CstmEcNo),
					new SqlParameter("CstmAddress",CstmAddress),
					new SqlParameter("CstmTelNo",CstmTelNo),
					new SqlParameter("CstmFax",CstmFax),
					new SqlParameter("CstmEmail",CstmEmail),
					new SqlParameter("CstmDesc",CstmDesc),
					new SqlParameter("FactoryPhone",FactoryPhone),
					new SqlParameter("FactoryFax",FactoryFax),
					new SqlParameter("FactoryAdd",FactoryAdd),
					new SqlParameter("WebSiteAdd",WebSiteAdd),
					new SqlParameter("City",City),
					new SqlParameter("CstmFullName",CstmFullName),
					new SqlParameter("CstmRabet",CstmRabet),
					new SqlParameter("CstmMobile",CstmMobile),
					new SqlParameter("CstmSabtNo",CstmSabtNo),
					new SqlParameter("MeliCode",MeliCode),
					new SqlParameter("PostCode",PostCode),
					new SqlParameter("Province",Province),
					new SqlParameter("PerNumber",PerNumber),
					new SqlParameter("WebUser",WebUser) 
				};
			Result = dbo.RunProcedure("WebCustomer_Insert", parameters, out RowsAffected);
			return Result;
        }


        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int InsertRowTestWeb(string Name, string WebUser, string Question)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Name",Name),
					new SqlParameter("WebUser",WebUser),
					new SqlParameter("Question",Question)				
				};
            Result = dbo.RunProcedure("InsertRowTestWeb", parameters, out RowsAffected);
            return Result;
        }


		[DataObjectMethod(DataObjectMethodType.Update)]
		public static int UpdateRow(string CstmName,string CstmEcNo,string CstmAddress,string CstmTelNo,
            string CstmFax,string CstmEmail,string CstmDesc,
            string FactoryPhone,string FactoryFax,string FactoryAdd,string WebSiteAdd,string City,
            string CstmFullName,string CstmRabet,string CstmMobile,string CstmSabtNo,string MeliCode,
            string PostCode,string Province,string PerNumber,string WebUser)
		{
			int RowsAffected = 0;
			int Result = 0;
			DbObject dbo = new DbObject();
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("CstmName",SqlDbType.NVarChar,1000,ParameterDirection.Input,true,18,18,"CstmName",DataRowVersion.Current,CstmName),
					new SqlParameter("CstmEcNo",CstmEcNo),
					new SqlParameter("CstmAddress",CstmAddress),
					new SqlParameter("CstmTelNo",CstmTelNo),
					new SqlParameter("CstmFax",CstmFax),
					new SqlParameter("CstmEmail",CstmEmail),
					new SqlParameter("CstmDesc",CstmDesc),
					new SqlParameter("FactoryPhone",FactoryPhone),
					new SqlParameter("FactoryFax",FactoryFax),
					new SqlParameter("FactoryAdd",FactoryAdd),
					new SqlParameter("WebSiteAdd",WebSiteAdd),
					new SqlParameter("City",City),
					new SqlParameter("CstmFullName",CstmFullName),
					new SqlParameter("CstmRabet",CstmRabet),
					new SqlParameter("CstmMobile",CstmMobile),
					new SqlParameter("CstmSabtNo",CstmSabtNo),
					new SqlParameter("MeliCode",MeliCode),
					new SqlParameter("PostCode",PostCode),
					new SqlParameter("Province",Province),
					new SqlParameter("PerNumber",PerNumber),
					new SqlParameter("WebUser",WebUser) 
				};
			Result = dbo.RunProcedure("WebCustomer_Update", parameters, out RowsAffected);
			return Result;
        }

		[DataObjectMethod(DataObjectMethodType.Delete)]
		public static int DeleteRow(int Pk_WebCustomer)
		{
			int RowsAffected = 0;
			int Result = 0;
			DbObject dbo = new DbObject();
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Pk_WebCustomer",Pk_WebCustomer) 
				};
			Result = dbo.RunProcedure("sp_WebCustomer_DeleteRow", parameters, out RowsAffected);
			return Result;
        }
        
        
        
        
        //Sadegh Beigi :
        
        /// <summary>
        /// WebInsertRequest
        /// </summary>
        /// <param name="WebUser"></param>
        /// <param name="RequestDate"></param>
        /// <param name="RequestValue"></param>
        /// <param name="RequestDesc"></param>
        /// <param name="Fk_ProdTypeSale"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int WebInsertRequest(string WebUser, string RequestDate, long RequestValue,string RequestDesc, int Fk_ProdTypeSale)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("WebUser",WebUser),
					new SqlParameter("RequestDate",RequestDate),
					new SqlParameter("RequestValue",RequestValue),
					new SqlParameter("RequestDesc",RequestDesc),
					new SqlParameter("Fk_ProdTypeSale",Fk_ProdTypeSale) 
				};
            Result = dbo.RunProcedure("WebInsertRequest", parameters, out RowsAffected);
            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WebUser"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebSelectProduct(string WebUser)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("WebUser",WebUser) 
                };
            return dbo.RunProcedure("WebSelectProduct", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsActive"></param>
        /// <param name="WebUser"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebSelectAllHavaleh(int IsActive, string WebUser)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("IsActive",IsActive),
                    new SqlParameter("WebUser",WebUser)
                };
            return dbo.RunProcedure("WebSelectAllHavaleh", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_havaleh"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebSelectHavaleh(int Pk_havaleh)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("Pk_havaleh",Pk_havaleh)
                };
            return dbo.RunProcedure("WebSelectHavaleh", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_Havaleh"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebSelectHavalehLoading(int Pk_Havaleh)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("Pk_Havaleh",Pk_Havaleh)
                };
            return dbo.RunProcedure("WebSelectHavalehLoading", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_Havaleh"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebPrintPishFactor(int Pk_Havaleh)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("Pk_Havaleh",Pk_Havaleh)
                };
            return dbo.RunProcedure("WebPrintPishFactor", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_Havaleh"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public static DataSet WebPrintHavaleh(int Pk_Havaleh)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("Pk_Havaleh",Pk_Havaleh)
                };
            return dbo.RunProcedure("WebPrintHavaleh", parameters, "WebCustomer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_Havaleh"></param>
        /// <param name="Fname"></param>
        /// <param name="Lname"></param>
        /// <param name="TelNo"></param>
        /// <param name="MobileNo"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int WebInternetPayment(int Pk_Havaleh,string Fname,string Lname,string TelNo,string MobileNo,string Email)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Pk_Havaleh",Pk_Havaleh),
					new SqlParameter("Fname",Fname),
					new SqlParameter("Lname",Lname),
                    new SqlParameter("TelNo",TelNo),
                    new SqlParameter("MobileNo",MobileNo),
                    new SqlParameter("Email",Email)
				};
            Result = dbo.RunProcedure("WebInternetPayment", parameters, out RowsAffected);
            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pk_Havaleh"></param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int WebManualPayment(int Pk_Havaleh, string PicURL)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Pk_Havaleh",Pk_Havaleh),
                    new SqlParameter("PicURL",PicURL)
				};
            Result = dbo.RunProcedure("WebManualPayment", parameters, out RowsAffected);
            return Result;
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int WebCustomerIsOk(string WebUser)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					  new SqlParameter("WebUser",WebUser)
				};
            Result = dbo.RunProcedure("WebCustomerIsOk", parameters, out RowsAffected);
            return Result;
        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public static int Update_ActiveUser(string WebUser)
        {
            int RowsAffected = 0;
            int Result = 0;
            DORSADbObject dbo = new DORSADbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{					
					new SqlParameter("WebUser",WebUser) 
				};
            Result = dbo.RunProcedure("EPC_Websales_ActiveUser", parameters, out RowsAffected);
            return Result;
        }


    }
}