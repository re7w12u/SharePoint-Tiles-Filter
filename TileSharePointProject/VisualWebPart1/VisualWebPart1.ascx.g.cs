﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TileSharePointProject.VisualWebPart1 {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class VisualWebPart1 {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "12.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(VisualWebPart1 target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControlTree(global::TileSharePointProject.VisualWebPart1.VisualWebPart1 @__ctrl) {
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write("\r\n\r\n<link rel=\"stylesheet\" href=\"");
                     @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/sp-bootstrap.min.css\" type=\"text/css\" />\r\n<link rel=\"stylesheet\" href" +
                    "=\"");
                     @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/se.sp.tiles.css\" type=\"text/css\" />\r\n\r\n<script type=\"text/javascript\"" +
                    " src=\"");
                            @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/jquery.js\"></script>\r\n<script type=\"text/javascript\" src=\"");
                            @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/angular.min.js\"></script>\r\n<script type=\"text/javascript\" src=\"");
                            @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/angular-animate.min.js\"></script>\r\n<script type=\"text/javascript\" src" +
                    "=\"");
                            @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/SiteAssets/se.sp.tiles.js\"></script>\r\n\r\n<script type=\"text/javascript\">\r\n    var" +
                    " filterListName = \"");
                  @__w.Write( ListName );

            @__w.Write("\";\r\n    var defaultImgPath = \"");
                  @__w.Write( ImgPath );

            @__w.Write("\";\r\n    var orderByDesc = Boolean.parse(\"");
                             @__w.Write( OrderByDesc);

            @__w.Write(@""");
</script>

<div ng-app=""FilterModule"" class=""sp-bootstrap"">
    <div ng-controller=""FilterController"">
        <div class=""panel"" id=""tile-filter"">
            <h2>Filter : </h2>
            <input type=""text"" ng-model=""filter"" ng-change=""change()"" class=""form-control"" />
            <span class=""clear""></span>
        </div>

        <div id=""tile-wrapper"">
            <tile ng-repeat=""x in tiles"" text=""x.Title"" url=""x.LinkLocation.Url"" img=""x.BackgroundImageLocation.Url"" description=""x.Description"" ng-show=""Show(x)"" class=""tile""></tile>
        </div>
    </div>
</div>

");
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
