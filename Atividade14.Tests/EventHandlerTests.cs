using NSubstitute;

namespace Atividade14.Tests
{
    public class EventHandlerTests
    {
        [Fact]
        public void HandleEvent_WithMessage_ServiceSendEmail()
        {
            var emailService = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailService);
            var message = "mensagem enviada";
            var recipient = "test@example.com";
            var subject = "Event Occurred";

            eventHandler.HandleEvent(message);

            emailService.Received(1).SendEmail(recipient, subject, message);
        }
    }
}
