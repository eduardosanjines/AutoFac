using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Constructor
{
    public class AutoServiceCallerImp : IAutoServiceCaller
    {
        public AutoServiceCallerImp() { }

        private IAutoService bmwAutoService;
        private IAutoService hondaAutoService;
        private IAutoService fordAutoService; 
        public AutoServiceCallerImp(IAutoService bmwAutoService, IAutoService hondaAutoService, IAutoService fordAutoService)
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
