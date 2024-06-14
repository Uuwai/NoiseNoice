# NoiseNoice (NoiNoi)
Perlin Noise Generator
Seperated for Red, Green, and Blue.

## JSON Settings file

### The default settings
```
{
    "division" : 1,
    "opacity" : 0.05,
    "rgapx" : 0,
    "rgapy" : 0,
    "iterations" : 1,
    "R" : {
        "scale" : 0.1,
        "octaves" : 3,
        "persistence" : 0.1,
        "amplifier" : 0.1,
        "frequency" : 0.1
    },
    "G" : {
        "scale" : 0.1,
        "octaves" : 3,
        "persistence" : 0.1,
        "amplifier" : 0.1,
        "frequency" : 0.1
    },
    "B" : {
        "scale" : 0.1,
        "octaves" : 3,
        "persistence" : 0.1,
        "amplifier" : 0.1,
        "frequency" : 0.1
    }
}
```

### Description of settings

| Setting    | Type   | Description                                                                              |
| ---------- | ------ | ---------------------------------------------------------------------------------------- |
| division   | int    | Divides the noise resolution, High values for large images will be faster.               |
| opacity    | double | Opacity of the noise to show.                                                            |
| rgapx      | int    | Number of Randomized Pixel gap in X Position, zero for no gaps.                          |
| rgapy      | int    | Number of Randomized Pixel gap in Y Position, zero for no gaps.                          |
| iterations | int    | Number of times to put noise. The opacity will multiply if iterations is more than one.  |

### Settings for each color

| Setting     | Type   | Description                |
| ----------- | ------ | ---------------------------|
| scale       | double | Scale of the Noise,        |
| octaves     | int    | Octaves of the noise.      |
| persistence | double | Persistence of the noise   |
| amplifier   | double | Amplification of the noise |
| freqency    | double | Frequency of the noise     |

## Run on Terminal

`NoiseNoice.exe [input] [output] [json file]`


`[input]`
Input Image to create a noise on.

Leaving only the `input` will open the gui with the Image.

`[output]`
Output location of the Image processed with noise.

`[json file]`
Location of the .json file.

This will print the settings.

Leaving this empty will generate random settings.
