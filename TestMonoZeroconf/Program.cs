using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Zeroconf;


namespace TestMonoZeroconf
{
    class Program
    {
        static void Main(string[] args)
        {
            Mono.Zeroconf.RegisterService bonjourBrowserService = null;

            //-------------------------------------------------
            //begin setup zeroconf
            bonjourBrowserService = new RegisterService();
            bonjourBrowserService.Name = "CNCTouch Wi-fi Server";
            bonjourBrowserService.RegType = "_cnctouch._tcp";
            bonjourBrowserService.ReplyDomain = "local.";
            bonjourBrowserService.Port = 2030;

            // TxtRecords are optional
            TxtRecord txt_record = new TxtRecord();
            txt_record.Add("Password", "false");
            bonjourBrowserService.TxtRecord = txt_record;

            bonjourBrowserService.Register();

            // End setup zeroconf
            //---------------------------------------------------

            Console.ReadKey(); 
        }
    }
}
