using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SearhService.HeartBeatService;

namespace SearhService
{
    public class MyAddressCallback : IAddressCallback
    {
        public void LiveAddress(string address)
        {
            Console.WriteLine("111恭喜你," + address + "已被心跳成功接收！\n");
            Console.WriteLine("111发送时间：null" + "\n接收时间：" + DateTime.Now);
        }
    }
}
