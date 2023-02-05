using AddressSelecter.Model;
using System.Collections.Generic;

namespace AddressSelecter
{
    public static class Config
    {
        public static Dictionary<int, FTPHostModel> ftpCollection = new Dictionary<int, FTPHostModel>();

        public static void addFTPInfo()
        {
            FTPHostModel ftp = new FTPHostModel();
            ftp.ftpHost = "";
            ftp.ftpPort = ;
            ftp.ftpUsername = "";
            ftp.ftpPassword = "";
            ftp.ftpDirectory = @"";
            ftpCollection.Add(1, ftp);
        }
    }
}
