# Custom dictionary style

Use a custom dictionary style (.stylx) to symbolize features using a variety of attribute values.

![Custom dictionary style](custom-dictionary-style.jpg)

## Use case

When symbolizing geoelements in your map, you might need to convey several pieces of information with a single symbol. You could try to symbolize such data using a unique value renderer, but as the number of fields and values increases, that approach becomes impractical. With a dictionary renderer you can build each symbol on-the-fly based on one or several attribute values and handle a nearly infinite number of unique combinations.

In this example, a restaurant layer with attributes for rating, style, health score, and open hours is symbolized using a dictionary renderer that displays a single symbol for all of these variables. 

## How to use the sample

Run the app to see a restaurants layer displayed with a simple marker symbol for all features. Tap "Apply renderer" to apply a dictionary renderer to the layer. The renderer uses symbols from a custom dictionary style to show unique symbols based on several feature attributes. Change the fields used for the renderer by specifying the `inspection` field for the expected `healthgrade` attribute or by choosing to use the alternate `rating` from the field called `MyRating`. You can also turn symbol text on, choose a field to display, and re-apply the renderer. Clear the renderer to return to the symbol marker symbol display.

## How it works

1. Create a new `DictionarySymbolStyle` by passing in the path to the custom style (.stylx).
2. Define symbol attribute overrides (if any) using a collection of key-value pairs: `configured-attribute-name : override-attribute-name`.
3. Define text attribute overrides (if any) using a collection of key-value pairs: `configured-attribute-name : override-attribute-name`.
4. If necessary, provide new values for configuration settings defined in `DictionarySymbolStyle.Configurations`.
5. Create a new `DictionaryRenderer`, providing the `DictionarySymbolStyle` and (optionally) the collection of symbol and text attribute overrides.
6. Apply the dictionary renderer to a feature layer or graphics overlay with the expected attributes.

## Relevant API

* DictionaryRenderer
* DictionarySymbolStyle
* DictionarySymbolStyleConfiguration

## About the data

The custom [restaurant style file](https://arcgisruntime.maps.arcgis.com/home/item.html?id=751138a2e0844e06853522d54103222a) is downloaded automatically from an ArcGIS Online portal item. The symbols it contains were created using ArcGIS Pro. The logic used to apply the symbols comes from an Arcade script embedded in the stylx file (which is a SQLite database), along with a JSON string that defines expected attribute names and configuration properties. For information about creating your own custom dictionary style, see the open source [dictionary-renderer-toolkit](https://esriurl.com/DictionaryToolkit). 

The style is applied to a dataset showing a subset of [restaurants in Redlands, CA](https://services2.arcgis.com/ZQgQTuoyBrtmoGdP/arcgis/rest/services/Redlands_Restaurants/FeatureServer).

## Tags

dictionary, military, renderer, style, stylx, unique value, visualization
