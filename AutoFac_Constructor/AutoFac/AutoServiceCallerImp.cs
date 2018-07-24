using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac
{
    public class AutoServiceCallerImp : AutoServiceCaller
    {
        public AutoServiceCallerImp() { }

        private AutoService bmwAutoService;
        private AutoService hondaAutoService;
        private AutoService fordAutoService; 
        public AutoServiceCallerImp(AutoService bmwAutoService, AutoService hondaAutoService, AutoService fordAutoService)
        {
            this.bmwAutoService = bmwAutoService;
            this.hondaAutoService = hondaAutoService;
            this.fordAutoService = fordAutoService;
        }

        public void CallAutoService() {

            bmwAutoService.GetService();

            // get ford's auto service
            fordAutoService.GetService();

            // get honda's auto service
            hondaAutoService.GetService();

        }


    }
}
