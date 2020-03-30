# Pattern Matching
## How to run it:
Open a terminal and go to `bin/Debug/netcoreapp3.1/`then type
```bash
.\PatternMatching.exe
```
and follow the steps

## About 
Pattern Matching is a program that looks for matchs in a provided text and with a given pattern

## Tweaks in the program

### Choosing an Algorithm

Pattern Matching currently uses [KMPALgorithm](https://www.geeksforgeeks.org/kmp-algorithm-for-pattern-searching/?ref=lbp
) however it has another two implementation [Boyer Moore Algorithm](https://www.geeksforgeeks.org/boyer-moore-algorithm-for-pattern-searching/
) and Naive Algorithm these can be changed in the Mantching Center


### Chosing a way to read Data

Currently the program asks for input to the user, however we maight to provide a very long text.Therefore it would 
be better to provide a txt file. This can be changed in the MatchingCenter by updating the var readFromFile to true.

After this the program can be runned like this

```bash
.\PatternMatching.exe "..\..\..\Hamlet.txt" "..\..\..\pattern.txt"
```


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)