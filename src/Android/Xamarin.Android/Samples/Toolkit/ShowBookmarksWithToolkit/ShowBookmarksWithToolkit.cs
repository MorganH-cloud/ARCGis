// Copyright 2020 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Android.App;
using Android.OS;
using Android.Widget;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.Tasks;
using Esri.ArcGISRuntime.Tasks.Offline;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.ArcGISServices;
using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime.Toolkit.UI.Controls;
using Android.Views;
using System;

namespace ArcGISRuntimeXamarin.Samples.ShowBookmarksWithToolkit
{
    [Activity (ConfigurationChanges=Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        "Show bookmarks with toolkit",
        "Toolkit",
        "Use the toolkit's BookmarksView to allow users to navigate to a map's bookmarks.",
        "")]
    public class ShowBookmarksWithToolkit : Activity
    {
        // Hold references to the UI controls.
        private MapView _myMapView;
        private BookmarksView _bookmarksView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Title = "Show bookmarks with toolkit";

            CreateLayout();
            Initialize();
        }

        private void Initialize()
        {
            _myMapView.Map = new Map(new Uri("https://arcgisruntime.maps.arcgis.com/home/item.html?id=16f1b8ba37b44dc3884afc8d5f454dd2"));
        }

        private void CreateLayout()
        {
            // Create a new vertical layout for the app.
            var layout = new LinearLayout(this) { Orientation = Orientation.Vertical };

            // Add the map view to the layout.
            _myMapView = new MapView(this);
            layout.AddView(_myMapView);
            _myMapView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1f);

            _bookmarksView = new BookmarksView(this);
            _bookmarksView.GeoView = _myMapView;
            _bookmarksView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1f);

            layout.AddView(_bookmarksView);

            // Show the layout in the app.
            SetContentView(layout);
        }
    }
}
