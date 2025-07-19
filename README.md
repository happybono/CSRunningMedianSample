# CSRunningMedianSample
This sample implements a 5-point running median filter for numeric data entered into a WinForms ListBox.<br><br>

The **AllMedian** method applies the filter across every position by mirroring indices at the boundaries, while the **MiddleMedian** method preserves the first and last two values and only filters the central section.<br><br>

For each window, values are copied into a temporary array, sorted via a recursive Quicksort routine, and the third element (the median) is selected. Users add source data via the Add button and trigger filtering with the Calculate button, after which results appear in a separate ListBox. Internal data lists are cleared after each run to guarantee consistent behavior on subsequent executions. A simple UI makes it easy to visualize the smoothing effect in real time. <br><br>


> **Disclaimer :** This implementation uses a plain (equal-weight) median filter. For weighted-median calculations and a wider range of smoothing / correction methods, please refer to the **[SonataSmooth](https://github.com/sonatasmooth/SonataSmooth)** project.

## What's New
<details>
<summary>Click to Expand</summary>

### v1.0
#### February 20, 2022
> Initial release.

</details>

## Features
- To calibrate and convert original data using the running median method, click on the [Calculate] button.
- Correcting for outliers in a running median.

## Principle Demonstration
[![Data Calibration Demo Using the Running Median Method.](https://videoapi-muybridge.vimeocdn.com/animated-thumbnails/image/2dbb2e91-d9c1-4799-beea-9b1e6a9e6a85.gif?ClientID=vimeo-core-prod&Date=1648603639&Signature=a785b7936ee37beb6a0e010ae71a8215ae16bdf9)](https://vimeo.com/693794659 "Data Calibration Demo Using the Running Median Method - Click to Watch.")

## Known Issues
- Results may not be accurate when you use less than the 5 numeric data samples.
  
## Copyright
Copyright ⓒ HappyBono 2022 - 2025. All rights Reserved.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.
