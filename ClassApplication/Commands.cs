using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailwayDatabaseClient.ClassApplication;
using TSDConnection;
using MySql.Data.MySqlClient;
using RailwayDatabaseClient.ClassEncry;

namespace RailwayDatabaseClient.ClassApplication
{
    class Commands
    {
        static public void Initialize()
        {
            AppVars.AppParas.isAdmin = false;
            AppVars.AppParas.isEdit = false;
            AppVars.AppParas.isFilter = false;
            AppVars.AppParas.isLock = false;
            AppVars.AppParas.isLogin = false;
            AppVars.AppParas.salt = "BsoUyJiwzTl8V3WU";
            AppVars.AppParas.Enc0 = "vbzT0qs2QnTcXJYM";
            AppVars.AppParas.Enc1 = "XGZ3eORp7w0bRwDY";
            AppVars.AppParas.Enc2 = "1D7QHEOWRnjrVp3y";
            AppVars.AppParas.Enc3 = "EBs4hjtUkziISNkK";
            AppVars.initalDataCnt = 0;
            AppVars.dbInfo.ipUrl = "HEvbi+/iy9WJp/tTj3l0cA==";
            AppVars.dbInfo.dataName = "6WBYbn5DpDLfrLuolTIKyA==";
            AppVars.dbInfo.userName = "Og6tpHeUYW/w7kdHe3YSJA==";
            AppVars.dbInfo.passWord = "qSGfrYbaWD4kns4OcJqveA==";
            AppVars.dbInfo.portNum = 3306;
            return;
        }

        static public int GetDatabaseContent()
        {
            MysqlConnector mySql = new MysqlConnector();
            MySqlDataReader reader;
            mySql.SetServer(AESManager.AESDecrypt(AppVars.dbInfo.ipUrl,AppVars.AppParas.Enc0));
            mySql.SetDataBase(AESManager.AESDecrypt(AppVars.dbInfo.dataName,AppVars.AppParas.Enc1));
            mySql.SetUserID(AESManager.AESDecrypt(AppVars.dbInfo.userName,AppVars.AppParas.Enc2));
            mySql.SetPassword(AESManager.AESDecrypt(AppVars.dbInfo.passWord,AppVars.AppParas.Enc3));
            mySql.SetPort(AppVars.dbInfo.portNum.ToString());
            mySql.SetCharset("utf-8");
            try
            {
                reader = mySql.ExeQuery(string.Format("select * from {0}", "vehicle_info"));
                while (reader.Read())
                {
                    AppVars.DataStruct tempData;
                    AppVars.initalDataCnt++;
                    tempData.ID = Int32.Parse(reader.GetValue(0).ToString());
                    tempData.Name = reader.GetValue(1).ToString();
                    tempData.NickName= reader.GetValue(2).ToString();
                    tempData.Type= Int32.Parse(reader.GetValue(3).ToString());
                    tempData.Count = Int32.Parse(reader.GetValue(4).ToString());
                    tempData.Cap= Int32.Parse(reader.GetValue(5).ToString());
                    tempData.Date1= Int32.Parse(reader.GetValue(6).ToString());
                    tempData.Date2 = Int32.Parse(reader.GetValue(7).ToString());
                    tempData.Date3 = Int32.Parse(reader.GetValue(8).ToString());
                    tempData.Date4 = Int32.Parse(reader.GetValue(9).ToString());
                    tempData.Lenght = Int32.Parse(reader.GetValue(10).ToString());
                    tempData.Weight = Int32.Parse(reader.GetValue(11).ToString());
                    tempData.DescribeText = reader.GetValue(12).ToString();
                    String tempImageData = reader.GetValue(13).ToString();
                    tempData.ImageCount = tempImageData.Split(';').Length;
                    tempData.ImageUrl = new List<string>();
                    tempData.ImageUrl = tempImageData.Split(';').ToList();
                    tempData.Manu = reader.GetValue(14).ToString();
                    tempData.Runner = reader.GetValue(15).ToString();
                    String tempImageDescibeData = reader.GetValue(16).ToString();
                    tempData.ImageDescribe = new List<string>();
                    tempData.ImageDescribe = tempImageDescibeData.Split(';').ToList();
                    tempData.Speed = Int32.Parse(reader.GetValue(17).ToString());
                    tempData.AttachmentNum = 0;
                    tempData.Attachment = new List<string>();
                    tempData.AttachDescibe = new List<string>();
                    tempData.AttachImageCnt = 0;
                    tempData.AttachImage = new List<string>();
                    tempData.AttachNumber = new List<string>();
                    AppVars.initalData.Add(tempData);
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }

        static public int GetAttachmentData()
        {
            MysqlConnector mySql = new MysqlConnector();
            MySqlDataReader reader;
            mySql.SetServer(AESManager.AESDecrypt(AppVars.dbInfo.ipUrl, AppVars.AppParas.Enc0));
            mySql.SetDataBase(AESManager.AESDecrypt(AppVars.dbInfo.dataName, AppVars.AppParas.Enc1));
            mySql.SetUserID(AESManager.AESDecrypt(AppVars.dbInfo.userName, AppVars.AppParas.Enc2));
            mySql.SetPassword(AESManager.AESDecrypt(AppVars.dbInfo.passWord, AppVars.AppParas.Enc3));
            mySql.SetPort(AppVars.dbInfo.portNum.ToString());
            mySql.SetCharset("utf-8");
            try
            {
                for(int i=0;i<AppVars.initalData.Count();i++)
                {
                    AppVars.DataStruct tempData;
                    tempData = AppVars.initalData[i];
                    reader = mySql.ExeQuery(string.Format("select * from {0} where id = {1}", "vehicle_attach", tempData.ID.ToString()));
                    while (reader.Read())
                    {
                        tempData.AttachmentNum = (reader.GetValue(1).ToString()).Split(';').Length;
                        tempData.Attachment = (reader.GetValue(1).ToString()).Split(';').ToList();
                        tempData.AttachDescibe = (reader.GetValue(2).ToString()).Split(';').ToList();
                        tempData.AttachImageCnt = (reader.GetValue(3).ToString()).Split(';').Length;
                        tempData.AttachImage = (reader.GetValue(3).ToString()).Split(';').ToList();
                        tempData.AttachNumber= (reader.GetValue(4).ToString()).Split(';').ToList();
                        AppVars.initalData[i] = tempData;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }

        static public int VerifyLogin(string userName, string passWord)
        {
            MysqlConnector mySql = new MysqlConnector();
            MySqlDataReader reader;
            mySql.SetServer(AESManager.AESDecrypt(AppVars.dbInfo.ipUrl, AppVars.AppParas.Enc0));
            mySql.SetDataBase(AESManager.AESDecrypt(AppVars.dbInfo.dataName, AppVars.AppParas.Enc1));
            mySql.SetUserID(AESManager.AESDecrypt(AppVars.dbInfo.userName, AppVars.AppParas.Enc2));
            mySql.SetPassword(AESManager.AESDecrypt(AppVars.dbInfo.passWord, AppVars.AppParas.Enc3));
            mySql.SetPort(AppVars.dbInfo.portNum.ToString());
            mySql.SetCharset("utf-8");
            string pwd = "", salt = AppVars.AppParas.salt;
            int uid=0,type=0;
            try
            {
                reader = mySql.ExeQuery(string.Format("select * from {0} where username = '{1}'", "user", userName));
                while (reader.Read())
                {
                    uid = Int32.Parse(reader.GetValue(0).ToString());
                    pwd = reader.GetValue(1).ToString();
                    salt = reader.GetValue(2).ToString();
                    type = Int32.Parse(reader.GetValue(3).ToString());
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            if (pwd == "" || salt == "") return 1;
            if (MD5Manager.HashString(MD5Manager.HashString(passWord) + salt) == pwd)
            {
                AppVars.AppParas.isAdmin = type == 0 ? true : false;
                AppVars.AppParas.isLogin = true;
                AppVars.AppParas.uid = uid;
                AppVars.AppParas.UserName = userName;
                return 2;
            }
            return 3;
        }

        static public int RegNewUser(string userName, string passWord,string Email)
        {
            int VerifyExist = VerifyLogin(userName, passWord);
            if (VerifyExist == 0) return 0;
            else if (VerifyExist != 1) return 1;
            MysqlConnector mySql = new MysqlConnector();
            mySql.SetServer(AESManager.AESDecrypt(AppVars.dbInfo.ipUrl, AppVars.AppParas.Enc0));
            mySql.SetDataBase(AESManager.AESDecrypt(AppVars.dbInfo.dataName, AppVars.AppParas.Enc1));
            mySql.SetUserID(AESManager.AESDecrypt(AppVars.dbInfo.userName, AppVars.AppParas.Enc2));
            mySql.SetPassword(AESManager.AESDecrypt(AppVars.dbInfo.passWord, AppVars.AppParas.Enc3));
            mySql.SetPort(AppVars.dbInfo.portNum.ToString());
            mySql.SetCharset("utf-8");
            string pwd = passWord, salt = AppVars.AppParas.salt;
            try
            {
                mySql.ExeUpdate(string.Format("insert into {0}({1},{2},{3}) values('{4}','{5}',{6},'{7}')", 
                    "user", "username","password","type", userName ,MD5Manager.HashString(MD5Manager.HashString(passWord) + salt),1, Email));
            }
            catch (Exception ex)
            {
                return 0;
            }
            if (VerifyLogin(userName, passWord) == 3) return 2;
            return 0;
        }

        static public int UpdatePassWord(string userName, string OldpassWord, string NewPassWord)
        {
            if (VerifyLogin(userName, OldpassWord) != 3) return 0;
            MysqlConnector mySql = new MysqlConnector();
            mySql.SetServer(AESManager.AESDecrypt(AppVars.dbInfo.ipUrl, AppVars.AppParas.Enc0));
            mySql.SetDataBase(AESManager.AESDecrypt(AppVars.dbInfo.dataName, AppVars.AppParas.Enc1));
            mySql.SetUserID(AESManager.AESDecrypt(AppVars.dbInfo.userName, AppVars.AppParas.Enc2));
            mySql.SetPassword(AESManager.AESDecrypt(AppVars.dbInfo.passWord, AppVars.AppParas.Enc3));
            mySql.SetPort(AppVars.dbInfo.portNum.ToString());
            mySql.SetCharset("utf-8");
            string pwd = NewPassWord, salt = AppVars.AppParas.salt;
            try
            {
                mySql.ExeUpdate(string.Format("update {0} set password = '{1}' where uid = {2}", 
                    "user",MD5Manager.HashString(MD5Manager.HashString(NewPassWord) + salt),AppVars.AppParas.uid));
            }
            catch (Exception ex)
            {
                return 0;
            }
            AppVars.AppParas.isLogin = false;
            return 2;
        }
    }
}
