# TWord

![CI](https://github.com/szyn33k/TWord/workflows/Continuous-Integration/badge.svg)
![CD](https://github.com/szyn33k/TWord/workflows/Continuous-Delivery/badge.svg)
[![codecov](https://codecov.io/gh/szyn33k/TWord/branch/master/graph/badge.svg?token=4T0U8LOPUV)](https://codecov.io/gh/szyn33k/TWord)
![Version](https://img.shields.io/nuget/v/TWord?label=Version&logo=nuget)

## Download

- [NuGet](https://nuget.org/packages/TWord): `dotnet add package TWord`

## Description

Library to transform number or amount of money to words.

### Available languages

|  Language  | 
| ------------ | 
|  ![PolandFlag](https://raw.githubusercontent.com/tkrotoff/famfamfam_flags/master/pl.png) Polish | 
|  ![USFlag](https://raw.githubusercontent.com/tkrotoff/famfamfam_flags/master/us.png) English | 

If language that interest you is not listed - create issue, I will do my best to add it.

### Available currencies

Using [ISO-4217](https://www.iso.org/iso-4217-currency-codes.html)

|  Currency  | 
| ------------ | 
|  ![PolandFlag](https://raw.githubusercontent.com/tkrotoff/famfamfam_flags/master/pl.png) PLN | 
|  ![USFlag](https://raw.githubusercontent.com/tkrotoff/famfamfam_flags/master/us.png) USD | 
| ![EUFlag](https://raw.githubusercontent.com/tkrotoff/famfamfam_flags/master/eu.png) EUR |

If currency that interest you is not listed - create issue, I will do my best to add it.

Flag icons comes from https://github.com/tkrotoff/famfamfam_flags

## Usage

- [Number to words usage](#number-to-words-usage)
- [Amount of money to words usage](#amount-of-money-to-words-usage)

### Number to words

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

#### NtWordBuilder Extension Methods

| Method  | Description  |
| ------------ | ------------ |
| SetLanguage(Language)  | sets the language. See: [availabe languages](#available-languages)  |


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

#### AtWordBuilder Extension Methods

| Method  | Description  |
| ------------ | ------------ |
| SetLanguage(Language)  | sets the language. See: [availabe languages](#available-languages)  |
| SetCurrency(CurrencySymbol)  | sets the currency. See: [availabe currencies](#available-currencies)  |
| IntegerPartOnly()  | omnits decimal part from given amount. Example: 100.04 returns `one hundred dollars`  |
| DecimalPartAsFraction()  | displays decimal part as fraction. Example: 100.04 returns `one hundred dollars 4/100 cents`  |
| HideSubunit()  | hides decimal part as fraction. usually use with DecimalPartAsFraction(). Example: 100.04 returns `one hundred dollars 4/100`  |
| IntegerAndDecimalPartSeparator(string) | sets integer and decimal part separator. If separator is `and`, value is 100.04 result will be  `one hundred dollars and four cents` |
