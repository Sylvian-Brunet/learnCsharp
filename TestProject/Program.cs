Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration <= 10) { // Règle 6
    if(daysUntilExpiration == 0) { // Règle 5
        Console.WriteLine("Your subscription as expired.");
    } else if(daysUntilExpiration == 1) { // Règle 4
        discountPercentage = 20;
        Console.WriteLine("Your subscription expires within a day!");
    } else if (daysUntilExpiration <= 5) { // Règle 3
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} day(s)!");
    } else { // Règle 2
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

    if(discountPercentage > 0) {
        Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
}