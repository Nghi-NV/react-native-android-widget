
# react-native-android-widget

## Getting started

`$ npm install react-native-android-widget --save`

### Mostly automatic installation

`$ react-native link react-native-android-widget`

### Manual installation


#### iOS

- Not support

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.nghinv.RNReactNativeAndroidWidgetPackage;` to the imports at the top of the file
  - Add `new RNReactNativeAndroidWidgetPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-android-widget'
  	project(':react-native-android-widget').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-android-widget/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-android-widget')
  	```


## Usage
```javascript
import RNReactNativeAndroidWidget from 'react-native-android-widget';

// TODO: What to do with the module?
RNReactNativeAndroidWidget;
```
  # react-native-android-widget
