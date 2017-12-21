<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisualWebPart1.ascx.cs" Inherits="TileSharePointProject.VisualWebPart1.VisualWebPart1" %>

<link rel="stylesheet" href="<%= SPContext.Current.Site.Url %>/SiteAssets/sp-bootstrap.min.css" type="text/css" />
<link rel="stylesheet" href="<%= SPContext.Current.Site.Url %>/SiteAssets/se.sp.tiles.css" type="text/css" />

<script type="text/javascript" src="<%= SPContext.Current.Site.Url %>/SiteAssets/jquery.js"></script>
<script type="text/javascript" src="<%= SPContext.Current.Site.Url %>/SiteAssets/angular.min.js"></script>
<script type="text/javascript" src="<%= SPContext.Current.Site.Url %>/SiteAssets/angular-animate.min.js"></script>
<script type="text/javascript" src="<%= SPContext.Current.Site.Url %>/SiteAssets/se.sp.tiles.js"></script>

<script type="text/javascript">
    var filterListName = "<%= ListName %>";
    var defaultImgPath = "<%= ImgPath %>";
    var orderByDesc = Boolean.parse("<%= OrderByDesc%>");
</script>

<div ng-app="FilterModule" class="sp-bootstrap">
    <div ng-controller="FilterController">
        <div class="panel" id="tile-filter">
            <h2>Filter *: </h2>
            <input type="text" ng-model="filter" ng-change="change()" class="form-control" />
            <span class="clear"></span>
        </div>

        <div id="tile-wrapper">
            <tile ng-repeat="x in tiles" text="x.Title" url="x.LinkLocation.Url" img="x.BackgroundImageLocation.Url" description="x.Description" ng-show="Show(x)" class="tile"></tile>
        </div>
    </div>
</div>

