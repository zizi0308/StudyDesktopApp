﻿using System;
using System.Net;

namespace BookRentalShopApp.Helper
{
    public class Common
    {
        public static string ConnString = "Data Source=127.0.0.1;" +
                                        "Initial Catalog=bookrentalshop;" +
                                        "Persist Security Info=True;" +
                                        "User ID=SA;" +
                                        "Password=msspl_p@ssw0rd!";

        public static string LoginUserId = string.Empty;

        /// <summary>
        /// IP주소 받아오는 메서드
        /// </summary>
        /// <returns></returns>
        internal static string GetLocalIp()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        internal static string ReplaceCmdText(string strSource)
        {
            var result = strSource.Replace("'", "＇"); // 특수문자 홑따옴표로 바꿔서 SqlInjection 예방
            result = result.Replace("--", "");
            result = result.Replace(";", "");

            return result;
        }

    }
}
