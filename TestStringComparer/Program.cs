using System.Globalization;

// public class Class1 {
//     public static void Main() 
//     {
//         // Create a list of string.
//         List<string> list = new List<string>();
//
//         // Get the tr-TR (Turkish-Turkey) culture.
//         CultureInfo turkish = new CultureInfo("tr-TR");
//
//         // Get the culture that is associated with the current thread.
//         CultureInfo thisCulture = Thread.CurrentThread.CurrentCulture;
//
//         // Get the standard StringComparers.
//         StringComparer invCmp =   StringComparer.InvariantCulture;
//         StringComparer invICCmp = StringComparer.InvariantCultureIgnoreCase;
//         StringComparer currCmp = StringComparer.CurrentCulture;
//         StringComparer currICCmp = StringComparer.CurrentCultureIgnoreCase;
//         StringComparer ordCmp = StringComparer.Ordinal;
//         StringComparer ordICCmp = StringComparer.OrdinalIgnoreCase;
//
//         // Create a StringComparer that uses the Turkish culture and ignores case.
//         StringComparer turkICComp = StringComparer.Create(turkish, true);
//
//         // Define three strings consisting of different versions of the letter I.
//         // LATIN CAPITAL LETTER I (U+0049)
//         string capitalLetterI = "I";  
//
//         // LATIN SMALL LETTER I (U+0069)
//         string smallLetterI   = "i";
//
//         // LATIN SMALL LETTER DOTLESS I (U+0131)
//         string smallLetterDotlessI = "\u0131";
//
//         // Add the three strings to the list.
//         list.Add(capitalLetterI);
//         list.Add(smallLetterI);
//         list.Add(smallLetterDotlessI);
//
//         // Display the original list order.
//         Display(list, "The original order of the list entries...");
//
//         // Sort the list using the invariant culture.
//         list.Sort(invCmp);
//         Display(list, "Invariant culture...");
//         list.Sort(invICCmp);
//         Display(list, "Invariant culture, ignore case...");
//
//         // Sort the list using the current culture.
//         Console.WriteLine("The current culture is \"{0}\".", thisCulture.Name);
//         list.Sort(currCmp);
//         Display(list, "Current culture...");
//         list.Sort(currICCmp);
//         Display(list, "Current culture, ignore case...");
//
//         // Sort the list using the ordinal value of the character code points.
//         list.Sort(ordCmp);
//         Display(list, "Ordinal...");
//         list.Sort(ordICCmp);
//         Display(list, "Ordinal, ignore case...");
//
//         // Sort the list using the Turkish culture, which treats LATIN SMALL LETTER 
//         // DOTLESS I differently than LATIN SMALL LETTER I.
//         list.Sort(turkICComp);
//         Display(list, "Turkish culture, ignore case...");
//     }
//
//     public static void Display(List<string> lst, string title)
//     {
//         Char c;
//         int  codePoint;
//         Console.WriteLine(title);
//         foreach (string s in lst)
//         {
//             c = s[0];
//             codePoint = Convert.ToInt32(c);
//             Console.WriteLine("0x{0:x}", codePoint); 
//         }
//         Console.WriteLine();
//     }
// }
using System.Globalization;


// Set the current culture to Turkish
// CultureInfo.CurrentCulture = new CultureInfo("tr-TR");
// CultureInfo.CurrentCulture = new CultureInfo("en-AU");
CultureInfo.CurrentCulture = new CultureInfo("zh-CN");

// string[] strings = new string[] { "i", "I", "ı", "İ" };
string[] strings = new string[] { "0", "10", "9" };

// Sort using Ordinal comparison
Array.Sort(strings, StringComparer.Ordinal);
Console.WriteLine("Ordinal sort: " + string.Join(", ", strings));
Display(strings.ToList(), "");
// Sort using CurrentCulture comparison
Array.Sort(strings, StringComparer.CurrentCulture);
Console.WriteLine("CurrentCulture sort2: " + string.Join(", ", strings));
Display(strings.ToList(), "");




Console.WriteLine("===================================");
List<string> list = new();

string str1 = "é";
string str2 = "e";

// Define three strings consisting of different versions of the letter I.
// LATIN CAPITAL LETTER I (U+0049)
string capitalLetterI = "I";  

// LATIN SMALL LETTER I (U+0069)
string smallLetterI   = "i";

// LATIN SMALL LETTER DOTLESS I (U+0131)
string smallLetterDotlessI = "\u0131";

// Add the three strings to the list.
list.Add(capitalLetterI);
list.Add(smallLetterI);
list.Add(smallLetterDotlessI);


CultureInfo turkish = new CultureInfo("tr-TR");
CultureInfo french = new CultureInfo("fr-FR");
CultureInfo englishUs = new CultureInfo("en-US");
//set to us current culture
Thread.CurrentThread.CurrentCulture = french;
CultureInfo.CurrentCulture = french;

StringComparer turkishICComp = StringComparer.Create(turkish, false);

StringComparer frenchICComp = StringComparer.Create(french, false);

StringComparer enUsICComp = StringComparer.Create(englishUs, false);
list.Sort(turkishICComp);
Display(list, "title");
Console.WriteLine(str1);

//
// CultureInfo enUs = new CultureInfo("en-US");
// StringComparer enUsICComp = StringComparer.Create(enUs, false);
//
// // Get the standard StringComparers.
// StringComparer invCmp =   StringComparer.InvariantCulture;
// StringComparer invICCmp = StringComparer.InvariantCultureIgnoreCase;
// StringComparer currCmp = StringComparer.CurrentCulture;
// StringComparer currICCmp = StringComparer.CurrentCultureIgnoreCase;
// StringComparer ordCmp = StringComparer.Ordinal;
// StringComparer ordICCmp = StringComparer.OrdinalIgnoreCase;
//
// // Sort using Ordinal comparison
// strings.Sort(ordCmp);
// Console.WriteLine("Ordinal sort: " + string.Join(", ", strings));
//
// // Sort using CurrentCulture comparison
// strings.Sort(enUsICComp);
// Console.WriteLine("CurrentCulture sort: " + string.Join(", ", strings));
//
// int comparisonResult = StringComparer.CurrentCulture.Compare(str1, str2);
//
// if (comparisonResult < 0)
// {
//     Console.WriteLine("In the current culture, str1 comes before str2.");
// }
// else if (comparisonResult > 0)
// {
//     Console.WriteLine("In the current culture, str2 comes before str1.");
// }
// else
// {
//     Console.WriteLine("In the current culture, str1 and str2 are considered equal.");
// }
// CultureInfo culture = CultureInfo.CurrentCulture; Console.WriteLine("The current culture is {0} [{1}]", culture.NativeName, culture.Name);

     static void Display(List<string> lst, string title)
     {
         Char c;
         int  codePoint;
         Console.WriteLine(title);
         foreach (string s in lst)
         {
             c = s[0];
             codePoint = Convert.ToInt32(c);
             Console.Write( c + " == 0x{0:x} ,", codePoint); 
         }
         Console.WriteLine();
     }
