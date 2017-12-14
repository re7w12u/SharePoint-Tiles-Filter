using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using Microsoft.SharePoint;

namespace TileSharePointProject.VisualWebPart1
{
    [ToolboxItemAttribute(false)]
    public partial class VisualWebPart1 : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public VisualWebPart1()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        #region custom properties

        // Create a custom category in the property sheet.
        [Category("Schneider")]
        // Property is available in both Personalization
        // and Customization mode.
        [Personalizable(PersonalizationScope.Shared)]
        // The caption that appears in the property sheet.
        [WebDisplayName("List Name")]
        // The tool tip that appears when pausing the mouse pointer over
        // the friendly name in the property pane.
        [WebDescription("Type the target list name.")]
        // Display the property in the property pane.
        [WebBrowsable(true)]
        // The accessor for this property.
        public string ListName { get; set; }

        // Create a custom category in the property sheet.
        [Category("Schneider")]
        // Property is available in both Personalization
        // and Customization mode.
        [Personalizable(PersonalizationScope.Shared)]
        // The caption that appears in the property sheet.
        [WebDisplayName("Image Path")]
        // The tool tip that appears when pausing the mouse pointer over
        // the friendly name in the property pane.
        [WebDescription("default illustration image url.")]
        // Display the property in the property pane.
        [WebBrowsable(true)]
        // The accessor for this property.
        public string ImgPath { get; set; }

        // Create a custom category in the property sheet.
        [Category("Schneider")]
        // Property is available in both Personalization
        // and Customization mode.
        [Personalizable(PersonalizationScope.Shared)]
        // The caption that appears in the property sheet.
        [WebDisplayName("Order By Desc")]
        // The tool tip that appears when pausing the mouse pointer over
        // the friendly name in the property pane.
        [WebDescription("Check to order from high to low order field value")]
        // Display the property in the property pane.
        [WebBrowsable(true)]
        // The accessor for this property.
        public bool OrderByDesc { get; set; }

        #endregion
    }
}
