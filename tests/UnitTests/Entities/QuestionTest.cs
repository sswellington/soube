using Infrastructure.Database;

namespace UnitTests.Entities;

[Trait("Entities", "Question")]
public class QuestionFakeTest
{
	[Fact(DisplayName = "Get Software Engineering question returns successfully")]
	public void GetSoftwareEngineering_Should_ReturnSuccessfully()
	{
		//Arrange
		var questions = FakeDatabase.GetQuestions();

		//Act
		var question  = questions.FirstOrDefault(q => q.Discipline == "Software Engineering");

		//Assert
		question!.Id.Should().NotBeNull();
		question.Id.Should().BeOfType<string>();
		question.Id.Should().StartWithEquivalentOf(question.Discipline.ToLower() + "-");
		question.Address.Should().NotBeNull();
		question.Correct.Should().Be('E');
		question.Schooling.Should().Be('U');
		question.EntranceExam.Should().BeFalse();
		question.PublicTender.Should().BeTrue();
		question.Expired.Should().BeFalse();
		question.CreationDate.Date.Should().Be(DateTime.Today);
	}

	[Fact(DisplayName = "Get chemistry question returns successfully")]
	public void GetChemistry_Should_ReturnSuccessfully()
	{
		//Arrange
		var questions = FakeDatabase.GetQuestions();

		//Act
		var chemistry  = questions.FirstOrDefault(q => q.Discipline == "Chemistry");

		//Assert
		chemistry!.Id.Should().NotBeNull();
		chemistry.Id.Should().BeOfType<string>();
		chemistry.Id.Should().StartWithEquivalentOf(chemistry.Discipline.ToLower() + "-");
		chemistry.Address.Should().NotBeNull();
		chemistry.Correct.Should().Be('A');
		chemistry.Schooling.Should().Be('M');
		chemistry.EntranceExam.Should().BeTrue();
		chemistry.PublicTender.Should().BeFalse();
		chemistry.Expired.Should().BeFalse();
		chemistry.CreationDate.Date.Should().Be(DateTime.Today);
	}

	[Fact(DisplayName = "Primary Key Generator should return successfully")]
	public void PrimaryKeyGenerator_Should_ReturnSuccessfully()
	{
		//Arrange
		var chemistry = FakeDatabase.GetQuestionAboutChemistry();
		var physical = FakeDatabase.GetQuestionAboutPhysical();

		//Act

		//Assert
		chemistry.Id.Should().NotBeNull();
		chemistry.Id.Should().BeOfType<string>();
		chemistry.Id.Should().StartWithEquivalentOf(chemistry.Discipline.ToLower() + "-");
		chemistry.Address.Should().NotBeNull();
		chemistry.Correct.Should().Be('A');
		chemistry.Schooling.Should().Be('M');
		chemistry.EntranceExam.Should().BeTrue();
		chemistry.PublicTender.Should().BeFalse();
		chemistry.Expired.Should().BeFalse();
		chemistry.CreationDate.Date.Should().Be(DateTime.Today);

		physical.Id.Should().NotBeNull();
		physical.Id.Should().BeOfType<string>();
		physical.Id.Should().StartWithEquivalentOf(physical.Discipline.ToLower() + "-");
		physical.Address.Should().NotBeNull();
		physical.Correct.Should().Be('C');
		physical.Schooling.Should().Be('M');
		physical.EntranceExam.Should().BeTrue();
		physical.PublicTender.Should().BeFalse();
		physical.Expired.Should().BeFalse();
		physical.CreationDate.Date.Should().Be(DateTime.Today);
	}

	[Fact(DisplayName = "Entity is new should return default value of entity")]
	public void EntityIsNew_Should_ReturnDefaultValueOfEntity()
	{
		//Arrange
		var entity = FakeDatabase.GetQuestionEntityIsNew();
		string init = "empty";

		//Act
		var id = entity.Id;

		//Assert
		id.Should().NotBeNull();
		id.Should().BeOfType<string>();
		id.Should().StartWithEquivalentOf(init + "-");

		entity.Correct.Should().Be('W');
		entity.EntranceExam.Should().BeFalse();
		entity.PublicTender.Should().BeFalse();
		entity.Expired.Should().BeFalse();
		entity.CreationDate.Date.Should().Be(DateTime.Today);
		entity.Schooling.Should().Be('E');

		entity.Address.Should().Be(init);
		entity.NotebookDescription.Should().Be(init);
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
