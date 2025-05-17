using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace EmailAzureFunction;

public class EmailTrigger
{
    private readonly ILogger<EmailTrigger> _logger;
    private readonly string? _smtpEmail = Environment.GetEnvironmentVariable("SmtpEmail");
    private readonly string? _smtpPassword = Environment.GetEnvironmentVariable("SmtpPassword");

    public EmailTrigger(ILogger<EmailTrigger> logger)
    {
        _logger = logger;
    }

    [Function(nameof(EmailTrigger))]
    public async Task Run(
        [ServiceBusTrigger("email", Connection = "ServiceBusConnection")]
        ServiceBusReceivedMessage message,
        ServiceBusMessageActions messageActions)
    {

        try
        {
            var json = message.Body.ToString();
            var order = JsonSerializer.Deserialize<OrderPayload>(json);
            Console.WriteLine("OrderId: " + order.OrderId + "\nOrder price: " + order.OrderPrice + "\nEmail: " + order.Email);
            using var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_smtpEmail, _smtpPassword)
            };
            
            var body = $"Thank you for your order!\n\nOrder ID: {order.OrderId}\nTotal Price: ${order.OrderPrice:F2}";

            var mail = new MailMessage(_smtpEmail, order.Email)
            {
                Subject = "Order Confirmation",
                Body = body,
                BodyEncoding = Encoding.UTF8
            };

            await client.SendMailAsync(mail);
            _logger.LogInformation("Email sent successfully to {recipient}", order.Email);

            await messageActions.CompleteMessageAsync(message);
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to send email: {error}", ex.Message);
            throw;
        }
    }
    
     private record OrderPayload(string Email, string OrderId, decimal OrderPrice);
}
