using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

[TestFixture]
public class ErrorLoggerTest
{
    private ErrorLogger logger { get; set; }

    [SetUp]
    public void SetUp()
    {
        logger = new ErrorLogger();
    }
    [Test]
    public void Log_WhenCalled_SetTheLastErrorProperty()
    {
        logger.Log("a");
        Assert.That(logger.LastError, Is.EqualTo("a"));
    }


    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("    ")]
    public void Log_InvalidError_ThrowArgumentNullException(string error)
    {
        //logger.Log(error);
        Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Log_ValidError_RaiseErrorLoggedEvent()
    {
        var id = Guid.Empty;
        logger.ErrorLogged += (sender, args) => id = args;
        logger.Log("a");
        Assert.That(id, Is.Not.EqualTo(Guid.Empty));
    }

}
