<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571891/21.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4214)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MapCacheOptions/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MapCacheOptions/MainWindow.xaml))
<!-- default file list end -->
# How to use cache options of a map control


<p>This example illustrates what actions should be done to customize the local cache of a map control.  </p><p>The local cache allows you to save internet resources and significantly increases the map performance by loading saved map tiles from the local directory. </p><p>To enable map cache, it is necessary to assign  the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_CacheOptionstopic"><u>MapControl.CacheOptions</u></a> property to the  <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfMapCacheOptionstopic"><u>CacheOptions</u></a> object and specify the directory to which the loaded map tiles will be saved using the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapCacheOptions_Directorytopic"><u>CacheOptions.Directory</u></a> property. It is also necessary to specify the time interval after which map tile images will be updated from a map data provider via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapCacheOptions_KeepIntervaltopic"><u>CacheOptions.KeepInterval</u></a> property.</p><p>In this example tile images of a map are loaded from the <a href="http://www.openstreetmap.org/"><u>openstreetmap.org</u></a> resource.    </p>

<br/>


