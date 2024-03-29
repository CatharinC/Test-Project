using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestProject1
{

    public class Login___CSV : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Enter text 'catharin.mathumitha@gmail.com' in 'EmailText'")]
        public void Login__CSV_CodedStep()
        {
            // Enter text 'catharin.mathumitha@gmail.com' in 'EmailText'
            object userName = Data["Username"];
            Actions.SetText(Pages.LoginMyStore.EmailText, userName.ToString());
            
        }
    
        [CodedStep(@"Enter text 'mathu1234' in 'PasswdPassword'")]
        public void Login__CSV_CodedStep1()
        {
            // Enter text 'mathu1234' in 'PasswdPassword'
            object password = Data["Password"];
            Actions.SetText(Pages.LoginMyStore.PasswdPassword, password.ToString());
            
        }
    }
}
