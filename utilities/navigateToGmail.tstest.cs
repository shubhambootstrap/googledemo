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

namespace google
{

    public class navigateToGmail : BaseWebAiiTest
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
    
        [CodedStep(@"Keyboard (KeyPress) - Ctrl+A (1 times) on 'LstIbText'")]
        public void navigateToGmail_CodedStep()
        {
            ActiveBrowser.ContentWindow.SetFocus();
            Pages.GoogleHistoryGoogleSearch1.LstIbText.ScrollToVisible();
            Pages.GoogleHistoryGoogleSearch1.LstIbText.Focus();
            ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(ArtOfTest.WebAii.Win32.KeyBoard.KeysFromString("Ctrl+A"), 150, 1);
            ActiveBrowser.WaitUntilReady();
            
        }
    }
}
