// Copyright 2020 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Toolkit.UI.Controls;
using Esri.ArcGISRuntime.UI.Controls;
using Foundation;
using System;
using UIKit;

namespace ArcGISRuntimeXamarin.Samples.ShowBookmarksWithToolkit
{
    [Register("ShowBookmarksWithToolkit")]
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        "Show bookmarks with toolkit",
        "Toolkit",
        "Use the toolkit's BookmarksView to allow users to navigate to a map's bookmarks.",
        "")]
    [ArcGISRuntime.Samples.Shared.Attributes.OfflineData()]
    public class ShowBookmarksWithToolkit : UIViewController
    {
        // Hold references to UI controls.
        private MapView _myMapView;
        private BookmarksView _bookmarksView;
        private UIBarButtonItem _showBookmarksButton;

        public ShowBookmarksWithToolkit()
        {
            Title = "Show bookmarks with toolkit";
        }

        private void Initialize()
        {
            // Create and show the map.
            _myMapView.Map = new Map(new Uri("https://arcgisruntime.maps.arcgis.com/home/item.html?id=16f1b8ba37b44dc3884afc8d5f454dd2"));
        }

        public override void LoadView()
        {
            // Create the views.
            View = new UIView() { BackgroundColor = UIColor.White };

            _myMapView = new MapView();
            _myMapView.TranslatesAutoresizingMaskIntoConstraints = false;

            _bookmarksView = new BookmarksView();
            _bookmarksView.GeoView = _myMapView;

            _showBookmarksButton = new UIBarButtonItem("Bookmarks", UIBarButtonItemStyle.Plain, null);

            // Add the views.
            View.AddSubviews(_myMapView);

            // Lay out the views.
            NSLayoutConstraint.ActivateConstraints(new []{
                _myMapView.TopAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TopAnchor),
                _myMapView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor),
                _myMapView.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor),
                _myMapView.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor)
            });  
            
            // Set up the navigation area button.
            if (NavigationItem != null)
            {
                NavigationItem.RightBarButtonItem = _showBookmarksButton;
            }
        }

        private void ShowBookmarks_Clicked(object sender, EventArgs e)
        {
            // Note: BookmarksView is a UIViewController.
            UINavigationController navController = new UINavigationController();
            navController.PushViewController(_bookmarksView, false);
            PresentModalViewController(navController, true);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Initialize();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            _showBookmarksButton.Clicked += ShowBookmarks_Clicked;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            _showBookmarksButton.Clicked -= ShowBookmarks_Clicked;
        }
    }
}
