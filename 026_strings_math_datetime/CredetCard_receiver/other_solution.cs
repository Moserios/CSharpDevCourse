using System;

class Program
{
 static void Main()
 {
  // Test the MaskCreditCard method
  string input = "My credit card number is 1234-5678-9012-3456";
  string output = MaskCreditCard(input);
  Console.WriteLine(output); // Output: "My credit card number is XXXX-XXXX-XXXX-3456"

  // Test the MaskSocialSecurity method
  input = "My social security number is 123-45-6789";
  output = MaskSocialSecurity(input);
  Console.WriteLine(output); // Output: "My social security number is XXX-45-XXXX"

  // Test the MaskData method
  input = "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789";
  output = MaskData(input);
  Console.WriteLine(output); // Output: "My credit card number is XXXX-XXXX-XXXX-3456 and my social security number is XXX-45-XXXX"
  Console.ReadKey();
 }


 // Masks all credit card numbers in the input string
 static string MaskCreditCard(string input)
 {
  string[] parts = input.Split(' '); // Split the input string into parts

  for (int i = 0; i < parts.Length; i++)
  {
   string part = parts[i];
   if (part.Length == 19 && part[4] == '-' && part[9] == '-' && part[14] == '-') // Check if the part matches the credit card number format
   {
    string mask = new string('X', 4); // Create a mask with 4 'X'
    string lastFourDigits = part.Substring(15, 4); // Get the last four digits of the credit card number
    parts[i] = mask + "-" + mask + "-" + mask + "-" + lastFourDigits; // Replace the credit card number with the mask and the last four digits
   }
  }

  return string.Join(" ", parts); // Join the parts back into a string
 }

 // Masks all social security numbers in the input string
 static string MaskSocialSecurity(string input)
 {
  string[] parts = input.Split(' '); // Split the input string into parts

  for (int i = 0; i < parts.Length; i++)
  {
   string part = parts[i];
   if (part.Length == 11 && part[3] == '-' && part[6] == '-') // Check if the part matches the social security number format
   {
    string mask3 = new string('X', 3); // Create a mask with 3 'X'
    string mask4 = new string('X', 4); // Create a mask with 4 'X'
    string middleTwoDigits = part.Substring(4, 2); // Get the last four digits of the social security number
    parts[i] = mask3 + "-" + middleTwoDigits + "-" + mask4; // Replace the social security number with the mask and the middle two digits
   }
  }

  return string.Join(" ", parts); // Join the parts back into a string
 }


 // Masks all credit card numbers and social security numbers in the input string
 static string MaskData(string input)
 {
  string output = MaskCreditCard(input); // Mask the credit card numbers
  output = MaskSocialSecurity(output); // Mask the social security numbers
  return output;
 }
}