using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jxglxt;

namespace Moodle
{
    class Wskt
    {
        #region 公共变量
        private String token = "e9369a3cd3ea23d7a280aa4ba61ed9ac";
        private String DomianName = "http://192.168.1.103/webservice/rest/server.php";
        private String FunctionName = "";
        private String Parameters = "";
        #endregion

        /// <summary>
        /// 构造函数，传递函数名和函数参数
        /// </summary>
        /// <param name="APIName">函数名</param>
        /// <param name="ParametersTable">函数参数表</param>
        public Wskt(String APIName,Hashtable ParametersTable) 
        {
            StringBuilder StringData = new StringBuilder();

            FunctionName = APIName;
            //遍历键值对表，将其变成字符串
            foreach (DictionaryEntry Item in ParametersTable)
            {
                StringData.Append(Item.Key.ToString()+"="+Item.Value.ToString()+"&");
            }
            
            Parameters=StringData.ToString();	 
        }

        /// <summary>
        /// 发送Post请求
        /// </summary>
        /// <returns>返回xml文档</returns>
        public String SendRequest() 
        {
            String Url = DomianName + "?wstoken=" + token + "&wsfunction=" + FunctionName;
            HttpRequest Http = new HttpRequest();
            
            String Response=Http.PostRequest(Url,Parameters);
            Http.Close();
            return Response;
        }
    }
}
