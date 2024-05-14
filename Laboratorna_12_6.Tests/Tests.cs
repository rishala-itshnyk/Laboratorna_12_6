namespace Laboratorna_12_6.Tests;

[TestFixture]
public class Tests
{

    [Test]
    public void AddSubscriber_WhenCalled_AddsSubscriberToPhoneBook()
    {
        // Arrange
        var lastName = "Лисяк";
        var phoneNumber = "0991234567";

        // Act
        Program.AddSubscriber(lastName, phoneNumber);

        // Assert
        Assert.IsTrue(Program.phoneBook.Contains(new Program.Subscriber { lastName = lastName, phoneNumber = phoneNumber }));
    }
}