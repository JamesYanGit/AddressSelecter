using AddressSelecter.Abstract;
using AddressSelecter.Interface;
using AddressSelecter.Model;
using System.Collections.Generic;

namespace AddressSelecter
{
    public class IterationClass : ASelecter, IAddressSelecter
    {
        public int _startPoint;
        public int _endPoint;
        public int _currentPoint;
        Dictionary<int, FTPHostModel> _FTPSeverInfo;
        public IterationClass(int start, int end, int current)
        {
            _startPoint = start;
            _endPoint = end;
            _currentPoint = current;
            
            if (Config.ftpCollection.Count<=0)
            {
                Config.addFTPInfo();
            }
            _FTPSeverInfo = Config.ftpCollection;
        }
        public int getAddress()
        {
            //add 1 to the initial channel, if the channel number is greater than use the number subsitite end point.
            int temp = _currentPoint + 1;
            while (true)
            {
                
                if (temp > _endPoint)
                {
                    temp -= _endPoint;
                }

                _fTPHost = _FTPSeverInfo[temp];
                if (detectFTPServer() != "serverDown") // verify if the server is availiable
                {
                    return temp;
                }
                else
                {
                    temp++;
                }
            }
            
            return temp;
        }

        
    }
}
