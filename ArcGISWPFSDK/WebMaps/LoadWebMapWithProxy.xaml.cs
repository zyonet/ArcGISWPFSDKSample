﻿using System;
using System.Windows.Controls;
using ESRI.ArcGIS.Client.WebMap;
using ESRI.ArcGIS.Client;

namespace ArcGISWPFSDK
{
	public partial class LoadWebMapWithProxy:UserControl
	{
		public LoadWebMapWithProxy()
		{
			InitializeComponent();

			Document webMap = new Document();
			webMap.ProxyUrl = "http://serverapps.esri.com/SilverlightDemos/ProxyPage/proxy.ashx";
			webMap.GetMapCompleted += webMap_GetMapCompleted;

			webMap.GetMapAsync("07cbed6b51474885b420cd5ed4c3e082");
		}

		void webMap_GetMapCompleted(object sender,GetMapCompletedEventArgs e)
		{
			if (e.Error == null)
				LayoutRoot.Children.Add(e.Map);
		}
	}
}
