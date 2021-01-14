# TWord

![CI](https://github.com/szyn33k/TWord/workflows/Continuous-Integration/badge.svg)
![CD](https://github.com/szyn33k/TWord/workflows/Continuous-Delivery/badge.svg)
![Version](https://img.shields.io/nuget/v/TWord?label=Version&logo=nuget)

## Download

- [NuGet](https://nuget.org/packages/TWord): `dotnet add package TWord`

## Description

Library to transform number or amount of money to words.

- [Number to words usage](#number-to-words-usage)
- [Amount of money to words usage](#amount-of-money-to-words-usage)

### Number to words usage

To transform number to words use code like below.

```c#
public static class Program
{
    INtWord nt = new NtWordBuilder()
                .SetLanguage(Language.English)
                .Build(); 
								
	var words = nt.ToWords(56123);
		
	// Words is equal to 
	// fifty six thousand one hundred twenty three
}
```

### Amount of money to words usage

To transform amount of money to words use code like below.

```c#
public static class Program
{
    IAtWord at = new AtWordBuilder()
                .SetLanguage(Language.English)
                .SetCurrency(CurrencySymbol.USD)
                .Build(); 
								
	var words = at.ToWords(56123.01m);
		
	// Words is equal to 
	// fifty six thousand one hundred twenty three dollars one cent
}
```
