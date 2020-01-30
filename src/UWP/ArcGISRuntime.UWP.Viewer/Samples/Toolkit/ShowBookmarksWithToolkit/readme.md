# Show bookmarks with toolkit

Use the toolkit's BookmarksView to allow users to navigate to a map's bookmarks.

![Screenshot showing a map with a list of bookmarks overlaid](ShowBookmarksWithToolkit.jpg)

## Use case

Toolkit provides commonly-used controls that simplify app development. `BookmarksView` shows the bookmarks for the Map or Scene shown in a MapView or SceneView and will navigate the view to the user-selected bookmark.

## How to use the sample

Select a bookmark to navigate to that area.

## How it works

1. Create a `MapView` and populate it with a `Map`.
2. Create and add a `BookmarksView` to the view.
3. Either through binding or in code, assign the map view to the bookmarks view's `GeoView` property.

## Relevant API

* BookmarksView
* MapView

## About the data

The sample opens on the [Portland Tree Survey](https://arcgisruntime.maps.arcgis.com/home/item.html?id=16f1b8ba37b44dc3884afc8d5f454dd2) map from ArcGIS Online. It has been configured with several bookmarks highlighting interesting areas.

## Additional information

Toolkit is open source on [GitHub](https://github.com/esri/arcgis-toolkit-dotnet). You can either incorporate the toolkit code directly into your project or solution, or add via [Nuget](https://www.nuget.org/packages/Esri.ArcGISRuntime.Toolkit).

## Tags

bookmark, map, map area, toolkit
