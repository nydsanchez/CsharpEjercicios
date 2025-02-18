﻿/* Challenge: Improve renewal rate of subscriptions
You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements. */

//Review the business rules for this challenge
/* Rule 1: Your code should only display one message.
            The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
Output: Your subscription will expire soon. Renew now!

Rule 3: If the user's subscription will expire in five days or less, display the messages:
Output:Your subscription expires in _ days. Renew now and save 10%!

Rule 4: If the user's subscription will expire in one day, display the messages:
Output:Your subscription expires within a day! Renew now and save 20%!

Rule 5: If the user's subscription has expired, display the message:
Output:Your subscription has expired.

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.
 */

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired");
}
else if (daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day! Renew now and save " + discountPercentage +"%!");
}
else if(daysUntilExpiration <= 5){
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration<=10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else{
    Console.WriteLine("");
}