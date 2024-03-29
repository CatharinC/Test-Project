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

    public class Ecommerce : BaseWebAiiTest
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
    
        [CodedStep(@"Click 'LogInToLink'")]
        public void Ecommerce_CodedStep()
        {
            // Click 'LogInToLink'
            Pages.MyStore.LogInToLink.MouseClick();
            
        }
    
        [CodedStep(@"Desktop command: Drag & Drop Link to Window Target")]
        public void Ecommerce_CodedStep1()
        {
            
            HtmlAnchor dragFrom = Find.ByXPath<HtmlAnchor>("//*[@id'layered_price_slider']/a[2]");
            //HtmlStyle styleBar = dragFrom.GetStyle("left");
            //string leftValue = styleBar.GetComputedStyleValue("left")
            //dragFrom.SetValue(left,80);
           // dragFrom.ClientSideLocator{80};
            dragFrom.DragTo(80,40);
           // Assert.AreEqual(leftValue, "80");
           
        }
    }
}
