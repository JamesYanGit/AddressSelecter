using AddressSelecter.Model;
using FTPHelper;

namespace AddressSelecter.Abstract
{
    public class ASelecter
    {
        protected FTPHostModel _fTPHost;
        protected string detectFTPServer()
        {
            try
            {
                FTPHelperClass fTPHelper = new FTPHelperClass(_fTPHost.ftpHost, _fTPHost.ftpUsername, _fTPHost.ftpPassword, _fTPHost.ftpDirectory);
                return fTPHelper.detectFTPServer();
            }
            catch (System.Exception)
            {
                return "serverDown";
            }
        }
    }
}
