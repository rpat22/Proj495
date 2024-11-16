using System;
using MySql.Data.MySqlClient; // Import MySQL library
using PhysioDynamik_Prototype_1;
class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a PaymentGateway instance
        PaymentGateway paymentGateway = new PaymentGateway
        {
            MethodType = 1,
            AccountNumber = "1234-5678-9012-3456",
            CardHolderName = "John Doe",
            ExpirationDate = new DateTime(2025, 12, 31)
        };

        // Step 2: Create a Payment instance
        Payment payment = new Payment
        {
            PaymentID = 1,
            Amount = 150.00m
        };

        // Step 3: Initiate payment
        payment.InitiatePayment(paymentGateway, payment.Amount);
    }
}