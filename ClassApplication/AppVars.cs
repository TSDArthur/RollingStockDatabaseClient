using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayDatabaseClient.ClassApplication
{
    class AppVars
    {
        const int MAXN = 100000 + 5;
        public struct AppLoad
        {
            public bool isLogin;
            public bool isAdmin;
            public bool isFilter;
            public bool isEdit;
            public bool isLock;
            public string UserName;
            public int uid;
            public string salt;
            public string Enc0;
            public string Enc1;
            public string Enc2;
            public string Enc3;
        }

        public struct DataStruct
        {
            public int ID;
            public string Name;
            public string NickName;
            public int Count;
            public int Type;
            public int Weight;
            public int Lenght;
            public int Cap;
            public int Speed;
            public int Date1;
            public int Date2;
            public int Date3;
            public int Date4;
            public int ImageCount;
            public List<string> ImageUrl;
            public List<string> ImageDescribe;
            public string Manu;
            public string DescribeText;
            public string Runner;
            public int AttachmentNum;
            public List<string> Attachment;
            public List<string> AttachDescibe;
            public int AttachImageCnt;
            public List<string> AttachImage;
        }

        public struct Filter
        {
            public int ID_From;
            public int ID_To;
            public string Name;
            public int Type_Cnt;
            public List<int> Type;
            public int Weight_From;
            public int Weight_To;
            public int Length_From;
            public int Length_To;
            public int Cap_From;
            public int Cap_To;
            public int Speed_From;
            public int Speed_To;
            public int Date1_From;
            public int Date_To;
            public int Date2_From;
            public int Date2_To;
            public int Date3_From;
            public int Date3_To;
            public int Date4_From;
            public int Date4_To;
            public int Attachment_Cnt;
            public List<string> Attachment;
        }

        public struct DBInfo
        {
            public string ipUrl;
            public int portNum;
            public string userName;
            public string passWord;
            public string dataName;
        }

        static public int onDisplayDataCnt;
        static public List<DataStruct> onDisplayData = new List<DataStruct>();
        static public int initalDataCnt;
        static public List<DataStruct> initalData = new List<DataStruct>();
        static public Filter initalFilter;
        static public Filter lastFilter;
        static public AppLoad AppParas;
        static public DBInfo dbInfo;
    }
}
