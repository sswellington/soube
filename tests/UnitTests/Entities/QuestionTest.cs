using Newtonsoft.Json.Linq;
using UnitTests.Fixtures;

namespace UnitTests.Entities;

[Trait("Entities", "Question")]
public class QuestionTest
{
	[Fact(DisplayName = "Primary Key Generator should return successfully")]
	public void PrimaryKeyGenerator_Should_ReturnSuccessfully()
	{
		//Arrange
		var entity = QuestionFixture.GetQuestionEntity();

		//Act
		var id = entity.Id;

		//Assert
		id.Should().NotBeNull();
		id.Should().BeOfType<string>();
		id.Should().StartWithEquivalentOf(entity.Discipline.ToLower() + "-" + entity.Organizer.ToLower());
	}

	[Fact(DisplayName = "Entity is new should return default value of entity")]
	public void EntityIsNew_Should_ReturnDefaultValueOfEntity()
	{
		//Arrange
		var entity = QuestionFixture.GetQuestionEntityIsNew();
		string init = "empty";

		//Act
		var id = entity.Id;

		//Assert
		id.Should().NotBeNull();
		id.Should().BeOfType<string>();
		id.Should().StartWithEquivalentOf(init + "-" + init);

		entity.Correct.Should().Be('W');

		entity.Discipline.Should().Be(init);
		entity.Organizer.Should().Be(init);
		entity.Statement.Should().Be(init);
		entity.OptionA.Should().Be(init);
		entity.OptionB.Should().Be(init);
		entity.OptionC.Should().Be(init);
		entity.OptionD.Should().Be(init);
		entity.OptionE.Should().Be(init);
		entity.Year.Should().Be(1942);
	}
}
