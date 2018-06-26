using UITestAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UITestAutomation.Hooks
{
    [Binding]
    public sealed class Testhook
    {
        private readonly Context _context;

        public Testhook(Context context)
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