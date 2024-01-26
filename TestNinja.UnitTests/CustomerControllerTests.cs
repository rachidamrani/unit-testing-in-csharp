using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;


[TestFixture]
public class CustomerControllerTests
{
    private CustomerController _customerController;

    [SetUp]
    public void SetUp()
    {
        _customerController = new CustomerController();
    }

    [Test]
    public void GetCustomer_IdIsZero_ShouldReturnNotFound()
    {
        var result = _customerController.GetCustomer(0);

        // Should be a not found object 
        Assert.That(result, Is.TypeOf<NotFound>());

        // Should be a not found object or one of its derevitives
        //Assert.That(result, Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdIsNotZero_ShouldReturnOk()
    {
        var result = _customerController.GetCustomer(1);

        // The result should be an Ok object
        Assert.That(result, Is.TypeOf<Ok>());
    }
}
