using AddressSelecter.Interface;
using System;

namespace AddressSelecter
{
    public class RandomClass : IAddressSelecter
    {
        public int _startPoint;
        public int _endPoint;
        public RandomClass(int start, int end) 
        {
            _startPoint=start;
            _endPoint=end+1;
        }
        public int getAddress()
        {
            Random random = new Random();
            return random.Next(_startPoint, _endPoint);
        }
    }
}
