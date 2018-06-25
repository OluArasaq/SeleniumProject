using seleniumtestnew.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace seleniumtestnew.Hooks
{
    [Binding]
    public sealed class testhook
    {
        private readonly Context _context;

        public testhook(Context context)
        {
            _context = context;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _context.CloseBrowser();
        }
    }
}