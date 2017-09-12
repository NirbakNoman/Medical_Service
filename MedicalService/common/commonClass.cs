using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MedicalService.common
{
   public  class commonClass
    {
       commonTDSTableAdapters.sprCommon_query_executionTableAdapter tds = new MedicalService.commonTDSTableAdapters.sprCommon_query_executionTableAdapter();

       public string nonselect(string query)
       {
           string ret = "";
           try
           {
               tds.commonGateway(query);

           }
           catch(Exception ex)
           {
               ret = ex.InnerException.Message;            
           }
           return ret;
       }

       public DataTable select(string query)
       {
           string ret = "";
           DataTable dt = null;
           try
           {
            dt=    tds.commonGateway(query);

           }
           catch (Exception ex)
           {
               ret = ex.InnerException.Message;
           }
           return dt;
       }
    }
}
