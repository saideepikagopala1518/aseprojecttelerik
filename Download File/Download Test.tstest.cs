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

namespace ECommerceTesting
{

    public class Download_Test : BaseWebAiiTest
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
        string filepath=@"C:\Users\Ishu\Desktop\myfile.css";
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void Download_Test_CodedStep()
        {
           if(System.IO.File.Exists(filepath) ){
               System.IO.File.Delete(filepath);
           }
        }
    
        [CodedStep(@"New Coded Step")]
        public void Download_Test_CodedStep1()
        {
            Assert.IsTrue(System.IO.File.Exists(@"C:\Users\Ishu\Desktop\myfile.css"));
        }
    }
}
